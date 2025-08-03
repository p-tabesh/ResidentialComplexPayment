using ResidencialComplexPayment.Entity;

namespace ResidencialComplexPayment;

public class CalculateService
{
    public void CalculatePayment(Building building, Cost cost)
    {
        var calculator = CreateCalculator(cost.Invoice);

        calculator.Calculate(building, cost);
    }

    public CostCalculator CreateCalculator(Invoice invoice)
    {
        CostCalculator calculator;

        switch (invoice.InvoiceType)
        {
            case InvoiceType.X:
                calculator = new CalcualtePerAreaOfUnit();
                break;
            default:
                calculator = new CalculatePerUnit();
                break;
        }

        return calculator;
    }
}
