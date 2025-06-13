namespace Chain_Of_Responsibility.Core;
internal class TechnicalManagerApprovalHandler : VacationApprovalHandler
{
    public override void Process(VacationRequest vacationRequest)
    {
        // Technical manager can approve developer's vacation more than 3 days or any team leader's vacation
        if ((vacationRequest.Employee.JobTitle == JobTitle.Developer && vacationRequest.DurationInDays > 3) ||
            vacationRequest.Employee.JobTitle == JobTitle.TeamLeader)
        {
            vacationRequest.Status = VacationStatus.Approved;
            Console.WriteLine($"Vacation is approved by technical manager.");
        }
        else
            CallNextHandler(vacationRequest);
    }
}
