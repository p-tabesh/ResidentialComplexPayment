namespace ResidencialComplexPayment.Entity;

public class Unit
{
    public int UnitId { get; private set; }
    public int Area { get; private set; }
    public DateOnly ResidenceStartDate { get; private set; }
    public DateOnly ResidenceEndDate { get; private set; }
    public int CountOfResident { get; private set; }
}
