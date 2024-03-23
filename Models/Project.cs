namespace WebApplication15.Models
{
    public class Project
    {
        public int ProjectId { get; set; } // Assuming you have an ID property for the project
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
