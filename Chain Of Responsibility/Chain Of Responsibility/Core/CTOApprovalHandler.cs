namespace Chain_Of_Responsibility.Core;
internal class CTOApprovalHandler : VacationApprovalHandler
{
    public override void Process(VacationRequest vacationRequest)
    {
        // CTO can approve vacation requests for technical managers only
        if (vacationRequest.Employee.JobTitle == JobTitle.TechnicalManager)
        {
            vacationRequest.Status = VacationStatus.Approved;
            Console.WriteLine($"Vacation is approved by CTO.");
        }
        else
            CallNextHandler(vacationRequest);
    }
}
