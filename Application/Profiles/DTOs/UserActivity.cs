namespace Application.Profiles.DTOs;

public class UserActivity
{
    public required string Id { get; set; }
    public required string Title { get; set; }
    public required string Category { get; set; }
    public DateTime Date { get; set; }
}
