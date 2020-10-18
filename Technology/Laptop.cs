using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Device
    {
        public int BatteryCharge { get; set; } = 100;

        public Laptop(int displayWidth, int displayHeight, int maxStorage) : base(displayWidth, displayHeight, maxStorage)
        {
        }

        public bool LowPower()
        {
            return (BatteryCharge < 20) ? true : false;
        }
    }
}