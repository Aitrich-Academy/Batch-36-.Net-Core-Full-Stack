using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_5_Encapsulation
{
    internal class Product
    {
        // Private field
        private double price;

        // Public Property with validation
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("\nPrice cannot be negative.");
            }
        }

        // Method to apply discount
        public void ApplyDiscount(double percent)
        {
            if (percent > 0 && percent <= 100)
            {
                double discountAmount = price * percent / 100;
                price -= discountAmount;

                Console.WriteLine("Discount applied.");
                Console.WriteLine("New Price: " + price);
            }
            else
            {
                Console.WriteLine("Invalid discount percentage.");
            }
        }
    }
}
