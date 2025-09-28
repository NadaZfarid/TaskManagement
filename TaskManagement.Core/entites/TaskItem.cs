namespace TaskManagement.Core.entites
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime DueDate { get; set; }
        public Guid UserId { get; set; }
       // public User User { get; set; }
    }
}
