namespace Chain_Of_Responsibility;
internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public JobTitle JobTitle { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public DateOnly HiringDate { get; set; }
    public bool IsTerminated { get; set; }
}
