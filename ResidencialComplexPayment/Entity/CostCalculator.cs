namespace ResidencialComplexPayment.Entity;

public abstract class CostCalculator
{
    public abstract decimal Calculate(Building building, Cost cost);
}

public class CalculatePerUnit : CostCalculator
{
    public override decimal Calculate(Building building, Cost cost)
    {
        throw new NotImplementedException();
    }
}

public class CalcualtePerAreaOfUnit : CostCalculator
{
    public override decimal Calculate(Building building, Cost cost)
    {
        throw new NotImplementedException();
    }
}
