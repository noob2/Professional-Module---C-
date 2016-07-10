
public class AlloneYoung : Single
{
    private const decimal RoomElectricity = 10;

    private decimal laptopCost;

    public AlloneYoung(decimal income,decimal laptopCost) : base(RoomElectricity, income)
    {
        this.LaptopCost = laptopCost;
    }

    public decimal LaptopCost
    {
        get
        {
            return laptopCost;
        }

        set
        {
            laptopCost = value;
        }
    }

    public override decimal Consumption()
    {
        return base.Consumption() + laptopCost;
    }
}