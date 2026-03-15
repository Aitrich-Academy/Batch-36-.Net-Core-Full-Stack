using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class Television:IPower,IVolume
    {
        public void TurnOn()
        {
            Console.WriteLine("Television Turned On!!");
        }
        public void TurnOff()
        {
            Console.WriteLine("Television Turned Off!!");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("Volume Increased");
        }
        public void DecreaseVolume() {
            Console.WriteLine("Volume Decreased");
        }
    }
}
