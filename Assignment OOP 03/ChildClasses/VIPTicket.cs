using Assignment_OOP01.classes;
using Assignment_OOP01.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_03.ChildClasses
{
    internal class VIPTicket : Ticket
    {
        private bool LoungeAccess { get; set; }
        private static decimal ServiceFees { get; set; } = 50;

        public VIPTicket(string movieName, int type, SeatLocation seatLocation, decimal price) : base(movieName, type, seatLocation, price)
        {
        }
        
        public override string ToString()
        {
            return base.ToString() + $"\nlounge Access :    {LoungeAccess} | service fees {ServiceFees}";

        }
    }
}
