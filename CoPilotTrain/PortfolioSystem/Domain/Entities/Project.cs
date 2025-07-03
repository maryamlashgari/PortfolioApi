namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; } // Comma-separated
        public string RepoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}