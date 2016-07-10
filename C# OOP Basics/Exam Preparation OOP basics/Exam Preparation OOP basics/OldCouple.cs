using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exam_Preparation_OOP_basics;

public class OldCouple : Couple
{
    private const int NumberOfRooms = 3;
    private const decimal RoomElectricity = 15;

    private decimal stoveCost;

    public OldCouple(decimal pensionOne, decimal pensionTwo, decimal televisionCost, decimal fridgeCost, decimal stoveCost) 
        : base(NumberOfRooms, RoomElectricity, pensionOne+ pensionTwo, televisionCost, fridgeCost)
    {
        this.StoveCost = stoveCost;
    }

    public decimal StoveCost
    {
        get
        {
            return stoveCost;
        }

        set
        {
            stoveCost = value;
        }
    }

    public override decimal Consumption()
    {
        return base.Consumption() + this.stoveCost;
    }
}