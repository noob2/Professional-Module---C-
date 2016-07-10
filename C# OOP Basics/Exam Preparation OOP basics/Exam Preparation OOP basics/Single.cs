public abstract class Single : HouseHold
{
    private const int NumberOfRooms = 1;

    public Single(decimal roomCost, decimal income) : base(NumberOfRooms, roomCost, income)
    {
    }
}
