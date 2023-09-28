namespace TodoApplication.Domain;

public sealed class Todo
{
    public long Id { get; set; }
    public required string Title { get; set; }
    public string? Descreption { get; set; }
    public PriorityLevel Priority { get; set; }
}