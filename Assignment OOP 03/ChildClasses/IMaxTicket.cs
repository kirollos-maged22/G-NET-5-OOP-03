using Assignment_OOP01.classes;
using Assignment_OOP01.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_03.ChildClasses
{
    internal class IMaxTicket : Ticket
    {
        private bool _is3D;

        public bool Is3D
        {
            get { return _is3D; }
            set
            {
                if(Is3D == false && value == true)
                    Price += 30;
                Is3D = value;
            }
        }

        public IMaxTicket(string movieName, int type, SeatLocation seatLocation, decimal price) : base(movieName, type, seatLocation, price)
        {
        }


        public override string ToString()
        {
            return base.ToString() + $"\nIs 3D :   {Is3D}";
        }
    }
}
