namespace KidsAbroad.Models;

public class Child
{
    public Guid ChildID { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateOnly BirthDate { get; set; }
    public string Country { get; set; } = string.Empty;
    public string Guardian { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
