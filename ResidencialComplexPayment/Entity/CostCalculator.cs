namespace ResidencialComplexPayment.Entity;

public abstract class CostCalculator
{
    public abstract decimal Calculate(Building building, Cost cost);
}
