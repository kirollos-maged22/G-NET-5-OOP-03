using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP01.Structs
{
    public struct SeatLocation
    {
        public string SeatRow;
        public int SeatNumber;


        public SeatLocation(string seatRow, int seatNumber)

        {
            SeatRow = seatRow;
            SeatNumber = seatNumber;
        }
        public override string ToString()
        {
            return $"{SeatRow}{SeatNumber}";
        }
    }
}
