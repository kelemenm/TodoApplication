﻿namespace TodoApplication.Domain;

public sealed class Todo : Entity
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Descreption { get; set; }
    public PriorityLevel Priority { get; set; }
}