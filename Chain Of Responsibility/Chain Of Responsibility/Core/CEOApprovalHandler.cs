namespace Chain_Of_Responsibility.Core;
internal class CEOApprovalHandler : VacationApprovalHandler
{
    public override void Process(VacationRequest vacationRequest)
    {
        // Approve CTO's vacation requests only
        if (vacationRequest.Employee.JobTitle == JobTitle.CTO)
        {
            vacationRequest.Status = VacationStatus.Approved;
            Console.WriteLine($"Vacation is approved by CEO.");
        }
        else
            CallNextHandler(vacationRequest);
    }
}
