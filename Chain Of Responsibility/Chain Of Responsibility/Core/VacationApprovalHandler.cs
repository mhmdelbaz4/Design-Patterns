namespace Chain_Of_Responsibility.Core;
internal abstract class VacationApprovalHandler
{
    private VacationApprovalHandler? _nextHandler;
    public abstract void Process(VacationRequest vacationRequest);

    public void SetNextHandler(VacationApprovalHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void CallNextHandler(VacationRequest vacationRequest)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Process(vacationRequest);
        }
    }
}