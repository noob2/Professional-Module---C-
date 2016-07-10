public abstract class Couple : HouseHold
{
    private decimal televisionCost;
    private decimal fridgeCost;

    protected Couple(int numberOfRooms, decimal roomCost, decimal income, decimal televisionCost, decimal fridgeCost)
        : base(numberOfRooms, roomCost, income)
    {
        this.TelevisionCost = televisionCost;
        this.FridgeCost = fridgeCost;
    }

    public decimal TelevisionCost
    {
        get
        {
            return televisionCost;
        }

        set
        {
            televisionCost = value;
        }
    }

    public decimal FridgeCost
    {
        get
        {
            return fridgeCost;
        }

        set
        {
            fridgeCost = value;
        }
    }

    public override decimal Consumption()
    {
        return base.Consumption() + televisionCost + fridgeCost;
    }

    public override int Population()
    {
        return base.Population() + 1;
    }
}