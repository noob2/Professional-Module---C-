using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class YoungCoupleWithChildren : YoungCouple
{
    private const int NumberOfRooms = 2;
    private const decimal RoomElectricity = 20;

    private Child[] children;

    public YoungCoupleWithChildren(decimal salaryOne,decimal salaryTwo, decimal televisionCost, decimal fridgeCost, decimal laptopCost) 
        : base(NumberOfRooms, RoomElectricity, salaryOne+ salaryTwo, televisionCost, fridgeCost, laptopCost)
    {
    }

    public override decimal Consumption()
    {
        return base.Consumption() + children.Sum(c => c.TotalConsumption());
    }

    public override int Population()
    {
        return base.Population() + children.Length;
    }
}