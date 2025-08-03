namespace ResidencialComplexPayment.Entity;

public class Cost
{
    public Invoice Invoice { get; private set; }
    public DateOnly FromDate { get; private set; }
    public DateOnly ToDate { get; private set; }
    public Cost(Invoice invoice, DateOnly fromDate, DateOnly toDate)
    {
        Invoice = invoice;
        FromDate = fromDate;
        ToDate = toDate;
    }
}
