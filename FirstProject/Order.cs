using System;

namespace FirstProject
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime OrderTime { get; set; }

        public int OrderedItemID { get; set; }

        public decimal TotalPrice { get; set; }

        private static int startingIdnumber = 1;

        public Order(int movieID, decimal price)
        {
            OrderedItemID = movieID;
            TotalPrice = price;
            OrderTime = DateTime.Now;
            ID = startingIdnumber;
            startingIdnumber++;
        }

        public Order()
        {
        }
    }
}