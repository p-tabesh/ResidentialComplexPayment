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

public class CostCalculatorService
{
    private readonly CostCalculator _costCalculator;
    private readonly Building _building;
    private readonly Cost _cost;

    public CostCalculatorService(Building building, Cost cost, CostCalculator costCalculator)
    {

        _costCalculator = costCalculator;
        _cost = cost;
        _building = building;
    }

    public decimal Calculate()
    {
        var result = _costCalculator.Calculate(_building, _cost);
        return result;
    }
}