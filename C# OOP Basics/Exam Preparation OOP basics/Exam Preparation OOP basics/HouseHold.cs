public abstract class HouseHold
{
    private int numberOfRooms;
    private decimal roomCost;
    private decimal income;
    private decimal money;

    protected HouseHold(int numberOfRooms, decimal roomCost, decimal income)
    {
        this.NumberOfRooms = numberOfRooms;
        this.RoomCost = roomCost;
        this.Income = income;
        this.Money = 0;
    }

    public int NumberOfRooms
    {
        get
        {
            return numberOfRooms;
        }

        set
        {
            numberOfRooms = value;
        }
    }

    public decimal RoomCost
    {
        get
        {
            return roomCost;
        }

        set
        {
            roomCost = value;
        }
    }

    public decimal Income
    {
        get
        {
            return income;
        }

        set
        {
            income = value;
        }
    }
    public decimal Money
    {
        get
        {
            return money;
        }

        set
        {
            money = value;
        }
    }

    public void GetIncome()
    {
        this.money += this.income;
    }

    public void PayBills()
    {
        this.money -= this.Consumption();
    }

    public virtual decimal Consumption()
    {
        return this.numberOfRooms*this.roomCost;
    }

    public virtual int Population()
    {
        return 1;
    }
}