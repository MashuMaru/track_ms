namespace Tracker.Data.Entities;

public class User
{
    public int Id { get; set; } 
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Active { get; set; }
}
