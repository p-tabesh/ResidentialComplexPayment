namespace ResidencialComplexPayment.Entity;

public class Building
{
    public int BuildingId { get; private set; }
    public List<Unit> Units { get; private set; }
}
