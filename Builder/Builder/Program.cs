using Builder;

Employee employee = new Employee("Mohamed Ibrahim", 20000, "mhmdibrahim33@gmail.com");

#region without builder
//double bonus = 0;
//double tax = 0;
//double transportation = 0;
//double educationalPackage = 0;
//bool sendPayslip = false;
//bool showPayslip = false;

//while (true)
//{
//    Console.WriteLine("Please select an option:");
//    Console.WriteLine("\t 1. add 10% bonus.");
//    Console.WriteLine("\t 2. add 5% tax.");
//    Console.WriteLine("\t 3. add 1000 transportation.");
//    Console.WriteLine("\t 4. add 1500 eduncational package.");
//    Console.WriteLine("\t 5. send payslip via email.");
//    Console.WriteLine("\t 6. show payslip.");
//    Console.WriteLine("\t 0. exit.");
//    Console.Write("Option: ");
//    int option = int.Parse(Console.ReadLine() ?? "0");

//    if (option == 1)
//        bonus += 10;
//    else if (option == 2)
//        tax += 5;
//    else if (option == 3)
//        transportation += 1000;
//    else if (option == 4)
//        educationalPackage += 15000;
//    else if (option == 5)
//        sendPayslip = true;
//    else if (option == 6)
//        showPayslip = true;
//    else 
//    {
//        CalculateSalary calculateSalary = new CalculateSalary(tax, bonus, transportation, educationalPackage,
//                                                             sendPayslip, showPayslip);
//        calculateSalary.Calcaulate(employee);
//    }
//}
#endregion

#region with builder
CalculateSalaryBuilder calculateSalaryBuilder = new CalculateSalaryBuilder();
while (true)
{
    Console.WriteLine("Please select an option:");
    Console.WriteLine("\t 1. add 10% bonus.");
    Console.WriteLine("\t 2. add 5% tax.");
    Console.WriteLine("\t 3. add 1000 transportation.");
    Console.WriteLine("\t 4. add 1500 eduncational package.");
    Console.WriteLine("\t 5. send payslip via email.");
    Console.WriteLine("\t 6. show payslip.");
    Console.WriteLine("\t 0. exit.");
    Console.Write("Option: ");
    int option = int.Parse(Console.ReadLine() ?? "0");

    if (option == 1)
        calculateSalaryBuilder.WithBonus(10);
    else if (option == 2)
        calculateSalaryBuilder.WithBonus(5);
    else if (option == 3)
        calculateSalaryBuilder.WithTransportation(1000);
    else if (option == 4)
        calculateSalaryBuilder.WithEducationalPackage(1500);
    else if (option == 5)
        calculateSalaryBuilder.WithSendPayslip(true);
    else if (option == 6)
        calculateSalaryBuilder.WithShowPayslip(true);
    else
    {
        CalculateSalary calculateSalary = calculateSalaryBuilder.Build();
        calculateSalary.Calcaulate(employee);
        break;
    }
}
#endregion