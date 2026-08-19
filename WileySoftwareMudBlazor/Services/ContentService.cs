using System.Net.Http.Json;
using WileySoftwareMudBlazor.Models;

namespace WileySoftwareMudBlazor.Services
{
    /// <summary>
    /// Retrieves the dynamic navigation structure and maps virtual routes to physical Markdown files.
    /// </summary>
    public class ContentService
    {
        private readonly HttpClient _httpClient;
        private List<ContentNode>? _navigationTree;
        private Dictionary<string, string>? _routeToFileMap;

        public ContentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Fetches the navigation JSON from the external content repository.
        /// </summary>
        public async Task<List<ContentNode>> GetNavigationTreeAsync()
        {
            if (_navigationTree != null)
                return _navigationTree;

            var url = $"https://raw.githubusercontent.com/SithLord2K/portfolio-content/main/navigation.json?v={DateTime.Now.Ticks}";
            _navigationTree = await _httpClient.GetFromJsonAsync<List<ContentNode>>(url) ?? new List<ContentNode>();

            _routeToFileMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            BuildRouteMap(_navigationTree);

            return _navigationTree;
        }

        /// <summary>
        /// Retrieves the requested Markdown file name based on the captured route parameter.
        /// </summary>
        public async Task<string?> GetMarkdownFileNameAsync(string route)
        {
            if (_routeToFileMap == null)
            {
                await GetNavigationTreeAsync();
            }

            if (_routeToFileMap != null && _routeToFileMap.TryGetValue(route, out var fileName))
            {
                return fileName;
            }

            return null;
        }

        /// <summary>
        /// Recursively flattens the node tree to map routes to their corresponding files.
        /// </summary>
        private void BuildRouteMap(IEnumerable<ContentNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.IsGroup && !string.IsNullOrWhiteSpace(node.Route) && !string.IsNullOrWhiteSpace(node.MarkdownFile))
                {
                    _routeToFileMap[node.Route] = node.MarkdownFile;
                }

                if (node.Items != null && node.Items.Any())
                {
                    BuildRouteMap(node.Items);
                }
            }
        }
    }
}