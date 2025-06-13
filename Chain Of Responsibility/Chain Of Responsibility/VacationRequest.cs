namespace Chain_Of_Responsibility;
internal class VacationRequest
{
    public Employee Employee { get; set; }
    public DateOnly StartDate { get; set; }
    public int DurationInDays { get; set; }
    public DateOnly EndDate { get => StartDate.AddDays(DurationInDays); }
    public VacationStatus Status { get; set; }
}
