using Assignment_OOP01.classes;
using Assignment_OOP01.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_03.ChildClasses
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, int type, SeatLocation seatLocation, decimal price) : base(movieName, type, seatLocation, price)
        {
        }


        public override string ToString()
        {
            return base.ToString() + $"\nseat number :    {SeatNumber}";
        }


    }
}
