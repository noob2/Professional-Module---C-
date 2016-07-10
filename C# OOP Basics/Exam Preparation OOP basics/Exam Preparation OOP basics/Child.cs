using System.Linq;

public class Child
{
    private decimal[] consumptions;

    public Child(decimal[] consumptions)
    {
        this.Consumptions = consumptions;
    }

    public decimal TotalConsumption()
    {
        return consumptions.Sum();
    }

    public decimal[] Consumptions
    {
        get
        {
            return consumptions;
        }

        set
        {
            consumptions = value;
        }
    }
}