namespace Planer.Model;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; }

    public int UserId { get; set; } 
    public int DayId { get; set; }  
}