namespace Builder;
internal class CalculateSalaryBuilder
{
    double taxPercentage;
    double bonusPercentage = 0;
    double transportation = 0;
    double educationalPackage = 0;
    bool sendPayslip = false;
    bool showPayslip = false;


    public CalculateSalaryBuilder WithTax(double tax)
    {
        taxPercentage = tax;
        return this;
    }

    public CalculateSalaryBuilder WithBonus(double bonus)
    {
        bonusPercentage = bonus;
        return this;
    }

    public CalculateSalaryBuilder WithTransportation(double transportation)
    {
        this.transportation = transportation;
        return this;
    }

    public CalculateSalaryBuilder WithEducationalPackage(double educationalPackage)
    {
        this.educationalPackage = educationalPackage;
        return this;
    }

    public CalculateSalaryBuilder WithSendPayslip(bool sendPayslip)
    {
        this.sendPayslip = sendPayslip;
        return this;
    }

    public CalculateSalaryBuilder WithShowPayslip(bool showPayslip)
    {
        this.showPayslip = showPayslip;
        return this;
    }

    public CalculateSalary Build()
    {
        return new CalculateSalary(taxPercentage, bonusPercentage, transportation,
                                    educationalPackage, sendPayslip, showPayslip);
    }
}
