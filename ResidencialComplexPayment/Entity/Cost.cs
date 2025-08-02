namespace ResidencialComplexPayment.Entity;

public class Cost
{
    public Invoice Invoice { get; private set; }
    public DateOnly FromDate { get; private set; }
    public DateOnly ToDate { get; private set; }
}
