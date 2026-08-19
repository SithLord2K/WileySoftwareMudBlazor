namespace WileySoftwareMudBlazor.Models
{
    /// <summary>
    /// Represents a single navigation node or nested group retrieved from the remote content repository.
    /// </summary>
    public class ContentNode
    {
        public string Title { get; set; } = string.Empty;
        public bool IsGroup { get; set; }
        public string? Route { get; set; }
        public string? MarkdownFile { get; set; }
        public string? Icon { get; set; }
        public List<ContentNode>? Items { get; set; }
    }
}