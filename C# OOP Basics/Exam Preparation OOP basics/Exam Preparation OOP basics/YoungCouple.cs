public class YoungCouple : Couple
{
    private const int NumberOfRooms = 2;
    private const decimal RoomElectricity = 20;

    private decimal laptopCost;

    public YoungCouple(decimal salaryOne, decimal salaryTwo, decimal televisionCost, decimal fridgeCost, decimal laptopCost)
        : base(NumberOfRooms, RoomElectricity, salaryOne + salaryTwo, televisionCost, fridgeCost)
    {
        this.LaptopCost = laptopCost;
    }

    protected YoungCouple(int numberOfRooms, decimal roomElectricity, decimal income, decimal televisionCost, decimal fridgeCost, decimal laptopCost)
        : base(numberOfRooms, roomElectricity, income, televisionCost, fridgeCost)
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
        return base.Consumption() + laptopCost*2;
    }
}