namespace Builder;
internal class Employee
{
    public string Name { get; set; }
    public double BasicSalary { get; set; }
    public string Email { get; set; }
    public Employee(string name, int salary, string email)
    {
        Name = name;
        BasicSalary = salary;
        Email = email;
    }
    public override string ToString()
    {
        return $"{Name},${Email}, ${BasicSalary}";
    }
}
