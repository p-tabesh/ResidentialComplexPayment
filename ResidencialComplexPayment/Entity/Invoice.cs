namespace ResidencialComplexPayment.Entity;

public class Invoice
{
    public decimal Amount { get; private set; }
    public DateTime DateTime { get; private set; }
    public InvoiceType InvoiceType { get; private set; }
    public Invoice(decimal amount, DateTime dateTime)
    {
        Amount = amount;
        DateTime = dateTime;
    }

    

}
public enum InvoiceType
{
    Qabz,
    X,
    Y
}