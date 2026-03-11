using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_5_Encapsulation
{
    internal class Car
    {
     
        private int speed;


        // Public method to increase speed
        public void Accelerate(int increment)
        {
            if (increment > 0)
            {
                speed += increment;
                Console.WriteLine("\nCar accelerated. Current Speed: " + speed);
            }
            else
            {
                Console.WriteLine("Acceleration must be positive.");
            }
        }

        // Public method to decrease speed
        public void Brake(int decrement)
        {
            if (decrement > 0)
            {
                speed -= decrement;

                // Prevent speed from going below 0
                if (speed < 0)
                {
                    speed = 0;
                }

                Console.WriteLine("Car slowed down. Current Speed: " + speed);
            }
            else
            {
                Console.WriteLine("Brake value must be positive.");
            }
        }

        // Method to display speed
        public void DisplaySpeed()
        {
            Console.WriteLine("Current Speed: " + speed);
        }
    }
}
