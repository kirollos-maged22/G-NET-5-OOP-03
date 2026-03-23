using Assignment_OOP01.classes;
using Assignment_OOP_02.Helper_Classes;
using System.Diagnostics.Metrics;
using Assignment_OOP_02.classes;
using Assignment_OOP01.Enums;
using Assignment_OOP01.Structs;


namespace Assignment_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Theoretical part
            #region Question 01
            // Q1 : Identify the type of relationship in each scenario below  
            // (Inheritance, Association, Aggregation, Composition, or  Dependency):

            // Answer:
            // a) A University has Departments. If the university is closed, the departments no longer exist. // [Composition]
            // b) A Driver uses a Car. The driver does not own the car. 
            // [Association]
            // c) A Dog is an Animal. // [Inheritance]
            // d) A Team has Players. If the team is deleted, the players still exist. // [Aggregation]
            // e) A method receives a Logger as a parameter and calls it inside the method only. // [Dependency]

            #endregion

            #region Question 02
            // Q2: Access Modifiers and Sealed classes
            //
            // ─────────────────────────────────────────────────────────────
            // a) A parent class has a protected field.
            //    Can a child class in a DIFFERENT assembly access it?
            //    What about through an object instance from outside?
            // ─────────────────────────────────────────────────────────────
            //
            //  yes — a child class in a different assembly can access a
            //  protected field, but only through inheritance ( inside
            //  the derived class body using "this" or base).
            //
            //  no — you cant access a protected field through an object
            //  instance from outside the class hierarchy, even inside a
            //  derived class. For example:
            //
            //      ParentClass obj = new ParentClass();
            //      obj.protectedField;
            //      inside a child class:
            //      this.protectedField;  
            //
            // ─────────────────────────────────────────────────────────────
            // b) Difference between "protected internal" and
            //    "private protected"
            // ─────────────────────────────────────────────────────────────
            //
            //  protected internal  --> accessible from:
            //       Any derived class (any assembly)
            //       Any code within the SAME assembly (even non-derived)
            //      (union of protected OR internal)
            //
            //  private protected   --> accessible from:
            //       Derived classes, but only within the SAME assembly
            //       Derived classes in a different assembly
            //       Non-derived code, even in the same assembly
            //      (intersection of protected AND internal)
            //
            // ─────────────────────────────────────────────────────────────
            // c) What does the "sealed" keyword do?
            // ─────────────────────────────────────────────────────────────
            //
            //  Applied to a class:
            //      Prevents the class from being inherited (subclassed).
            //
            //  Applied to a method (must be an override):
            //      Prevents further overriding of that method in
            //      deeper derived classes. It stops the override chain.

            //
            // ─────────────────────────────────────────────────────────────
            // d) Can you create an object from a sealed class using "new"?
            // ─────────────────────────────────────────────────────────────
            //
            //  yes — you can instantiate a sealed class with new.
            //  "sealed classes" only prevents inheritance, not instantiation.
            //
            //      sealed class MyClass { }
            //      MyClass obj = new MyClass();  
            //
            //  The sealed keyword just means no other class can extend it.
            #endregion
            #endregion

            #region Practical Part :
            Cinema cinema = new Cinema();
            cinema.OpenCinema(new Cinema(), "Top Films");
            for (int i = 0; i < 3; i++)
            {
                // movie name 
                Console.Write("Movie Name: ");
                string? name = Console.ReadLine();

                // Ticke Type
                Console.Write("Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ) : ");
                bool Type = int.TryParse(Console.ReadLine(), out int typeParsed);

                // Seats Row
                Console.Write("Seat Class (A - Z) : ");
                string Seatclass = Console.ReadLine();

                // Seat Number
                Console.Write("Enter Seat Number : ");
                bool seatnumber = int.TryParse(Console.ReadLine(), out int number);

                // Price
                Console.Write("Price : ");
                bool price = decimal.TryParse(Console.ReadLine(), out decimal ParsedPrice);

                SeatLocation sl = new SeatLocation(Seatclass, number);

                Ticket tic01 = new Ticket(name, typeParsed, sl, ParsedPrice);
                tic01.TicketInfo();
                Console.WriteLine("======================");
                Console.WriteLine();


                // Discount Implementation
                decimal Amount = 0.00m;
                Console.Write("Have Discount (0.00) : ");
                bool DiscountAmount = decimal.TryParse(Console.ReadLine(), out Amount);

                while (true)
                {
                    if (Amount > 0.00m)
                    {
                        decimal FinalPice = tic01.ApplyDiscount(Amount);
                        tic01.DiscountedTicketInfo();
                        Console.WriteLine($"Final Price After Discount {FinalPice}");
                        break;
                    }

                    Console.WriteLine("invalid Discount Amount");
                    break;

                }

            }

            Console.Write("Enter a movie name to search: ");
            string searchName = Console.ReadLine();
            Ticket found = cinema.GetMovieByName(searchName);
            if (found != null)
                Console.WriteLine($"Found: {found}");
            else
                Console.WriteLine("Not found.");

            // Printing Total Tickets Sold
            Console.WriteLine($"Total Tickets sold : {Ticket.GetTotalTickets()}");
;

            cinema.CloseCinema(new Cinema());

            #endregion
        }
    }
}
