using Assignment_OOP_03.classes;
using Assignment_OOP01.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02.classes
{
    internal class Cinema
    {

        public string CinemaName { get; set; }
        public Projector projector { get; set; }

        private Ticket[] maxemimTicketsHolding = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index < maxemimTicketsHolding.Length || index > 0)
                {
                    return maxemimTicketsHolding[index];
                }
                return null;
            }
        }


        public void OpenCinema(Cinema cinema , string cinemaName)
        {
            Console.WriteLine($"{cinemaName} Cinema opend!");
        }
        public void CloseCinema(Cinema cinema)
        {
            Console.WriteLine("Cinema Closed!");
        }



        public void AddTicket(int index, Ticket t)
        {
            if (index < 0 || index >= maxemimTicketsHolding.Length)
                return;
            maxemimTicketsHolding[index] = t;
        }

        public Ticket GetMovieByName(string movieName)
        {
            foreach (Ticket t in maxemimTicketsHolding)
            {
                if (t != null && t.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                    return t;
            }
            return null;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < maxemimTicketsHolding.Length; i++)
            {
                if (maxemimTicketsHolding[i] == null)
                {
                    maxemimTicketsHolding[i] = t;
                    return true;
                }
            }
            return false;
        }
        
    }
}
