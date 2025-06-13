using Chain_Of_Responsibility;
using Chain_Of_Responsibility.Core;

Employee emp = new Employee
{
    Id = 1,
    Name = "John Doe",
    JobTitle = JobTitle.CTO,
    DateOfBirth = new DateOnly(1990, 1, 1),
    HiringDate = new DateOnly(2020, 1, 1),
    IsTerminated = false
};

VacationRequest vacationRequest = new VacationRequest
{
    Employee = emp,
    StartDate = new DateOnly(2023, 10, 1),
    DurationInDays = 2,
    Status = VacationStatus.Pending
};

TeamLeaderApprovalHandler teamLeaderHandler = new ();
TechnicalManagerApprovalHandler technicalManagerHandler = new();
CTOApprovalHandler ctoHandler = new();
CEOApprovalHandler ceoHandler = new();

teamLeaderHandler.SetNextHandler(technicalManagerHandler);
technicalManagerHandler.SetNextHandler(ctoHandler);
ctoHandler.SetNextHandler(ceoHandler);


// beginning from the first node in the chain
teamLeaderHandler.Process(vacationRequest);

Console.ReadLine();