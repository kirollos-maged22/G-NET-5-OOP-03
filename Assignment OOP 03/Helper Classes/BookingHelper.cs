namespace Assignment_OOP_02.Helper_Classes
{
    internal static class BookingHelper
    {
        private static int ReferenceCounter = 0;
        public static double GetGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
                return totalPrice;
            }
            return totalPrice;
        }


        public static string GenerateBookingReference()
        {
            ReferenceCounter++;
            return $"BK-{ReferenceCounter}";
        }
    }
}
