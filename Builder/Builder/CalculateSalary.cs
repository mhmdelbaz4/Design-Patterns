namespace Builder;
internal class CalculateSalary
{
    public CalculateSalary(double taxPercentage, double bonusPercentage = 0,
                           double transportation = 0, double educationalPackage = 0,
                           bool sendPayslip = false, bool showPayslip = false)
    {
        TaxPercentage = taxPercentage;
        BonusPercentage = bonusPercentage;
        Transportation = transportation;
        EducationalPackage = educationalPackage;
        SendPayslip = sendPayslip;
        ShowPayslip = showPayslip;
    }

    public double TaxPercentage { get; }
    public double BonusPercentage { get;}
    public double Transportation { get; }
    public double EducationalPackage { get; }
    public bool SendPayslip { get; }
    public bool ShowPayslip { get; }

    public void Calcaulate(Employee employee)
    {
        double bonus = employee.BasicSalary * BonusPercentage / 100;
        double tax = employee.BasicSalary * TaxPercentage / 100;
        double totalSalary = employee.BasicSalary + bonus + Transportation + EducationalPackage - tax;
        
        Console.ForegroundColor = ConsoleColor.Green;
        if(SendPayslip)
            Console.WriteLine($"Sending payslip to {employee.Email}");

        if (ShowPayslip)
            Console.WriteLine($"Employee: {employee.Name} has total salary ={totalSalary}");

        Console.ForegroundColor = ConsoleColor.White;
    }
}
