namespace WebApplication15.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        // Additional properties like status or due date, if needed
    }
}
