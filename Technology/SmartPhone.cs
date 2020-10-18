using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Device
    {
        public bool hasBrokenScreen { get; private set; } = false;

        public SmartPhone(int displayWidth, int displayHeight, int maxStorage) : base(displayWidth, displayHeight, maxStorage)
        {
        }

        public void DropPhone()
        {
            hasBrokenScreen = true;
        }
    }
}