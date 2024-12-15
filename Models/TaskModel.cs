namespace ToDoAppWeb.Models
{
    public class TaskModel
    {
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; } = false;
        public bool IsRemoving { get; set; } = false;
    }
}