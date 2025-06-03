namespace TaskTrackerWeb.Models
{
    public class Task
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public required string Priority { get; set; }

    }
}
