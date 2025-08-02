namespace ResidencialComplexPayment.Entity;

public class Cost
{
    public Factor Factor { get; private set; }
    public DateOnly FromDate { get; private set; }
    public DateOnly ToDate { get; private set; }
    public CostRange Range { get; private set; }
}

public enum CostRange
{
    PerBuilding = 1,
    AllBuilding = 2,
}
