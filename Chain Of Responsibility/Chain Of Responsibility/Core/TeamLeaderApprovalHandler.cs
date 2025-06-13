namespace Chain_Of_Responsibility.Core;
internal class TeamLeaderApprovalHandler : VacationApprovalHandler
{
    public override void Process(VacationRequest vacationRequest)
    {
         // Team leader can only approve developer's vacation less than or eaual 3 days
         if(vacationRequest.Employee.JobTitle == JobTitle.Developer && vacationRequest.DurationInDays <= 3)
         {
            vacationRequest.Status = VacationStatus.Approved;
            Console.WriteLine($"Vacation is approved by team leader."); 
         }else
            CallNextHandler(vacationRequest);
    }
}
