using Assignment_OOP_02.Helper_Classes;
using Assignment_OOP01.Enums;
using Assignment_OOP01.Structs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Assignment_OOP01.classes
{
    internal class Ticket
    {
        public string _movieName;
        public int _Type;
        public SeatLocation SeatLocation;
        private decimal _Price;
        public decimal _DiscountedPrice;
        public static int _ticketCounter = 0;
        public int TicketId { get; set; }
        public decimal PriceAfterTax => Price = _Price - (_Price * 0.14m);

        public Ticket(string movieName, int type, SeatLocation seatLocation, decimal price)

        {
            _movieName = movieName;
            _Type = type;
            SeatLocation = seatLocation;
            Price = price;
            _ticketCounter++;
            TicketId = _ticketCounter;
        }
        public Ticket(string name) : this(name, 0, new SeatLocation("A", 1), 50)
        {
            _movieName = name;
        }
        public Ticket(string movieName , decimal price)
        {
            _movieName = movieName;
            _Price = price;
        }

        public string MovieName
        {
            get { return _movieName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                _movieName = value;
            }
        }

        public decimal Price
        {
            get { return _Price; }

            set
            {
                if (_Price < 0)
                {
                    Console.WriteLine("invalid Price");
                    return;
                }
                _Price = value;
            }
        }
        public TicketType ticketType
        {
            get { return new TicketType(); }
            set { ticketType = value; }
        }

        public SeatLocation seats
        {
            get { return SeatLocation; }
            set { SeatLocation = value; }
        }





        // OK --------
        public decimal CalcTotal(decimal taxAmount = 0.14m)
        {
            decimal total = _Price + (_Price * taxAmount);
            return total;
        }



        public decimal ApplyDiscount(decimal discountAmount)
        {

            if (discountAmount > 0 && discountAmount <= _Price)
            {

                _DiscountedPrice = _Price - (CalcTotal() * discountAmount);
                return _DiscountedPrice;
            }
            return _Price;
        }

        public void TicketInfo()
        {
            Console.WriteLine($"===== Ticket Info =====");
            Console.WriteLine($"Movie Name    : {MovieName}");
            Console.WriteLine($"Type    : {ticketType}");
            Console.WriteLine($"Seat    : {SeatLocation.SeatRow}" + $"{SeatLocation.SeatNumber}");
            Console.WriteLine($"original Price   : {Price}");
            Console.WriteLine($"price After (14% tax)   : {CalcTotal()}");
            Console.WriteLine($"Ticket Id   : {TicketId}");
            Console.WriteLine($"Bookig Reference    : {BookingHelper.GenerateBookingReference()}");
        }

        public void DiscountedTicketInfo()
        {
            bool haveDiscount = true;
            Console.WriteLine($"Seat    : {SeatLocation.SeatRow}" + $"{SeatLocation.SeatNumber}");
            Console.WriteLine($"original Price   : {Price}");
            Console.WriteLine($"price After (14% tax):   {CalcTotal()}");
            Console.WriteLine($"Ticket Id   : {TicketId}");
        }

        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

        public override string ToString()
        {
            Console.WriteLine($"===== Ticket Info =====");
            return $"Movie Name    : {MovieName}\nType    : {ticketType}\n Seat    : {SeatLocation.SeatRow} {SeatLocation.SeatNumber}\noriginal Price   : {Price}\nprice After (14% tax)   : {CalcTotal()}\nTicket Id   : {TicketId}\nBookig Reference    : {BookingHelper.GenerateBookingReference()}";
        }

    }
} 