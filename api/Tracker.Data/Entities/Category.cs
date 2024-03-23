namespace Tracker.Data.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string UserId { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public bool Active { get; set; }
}