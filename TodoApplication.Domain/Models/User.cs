namespace TodoApplication.Domain;

public sealed class User : Entity
{
    public required string Email{ get; set; }
}