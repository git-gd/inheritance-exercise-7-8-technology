using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Device : AbstractEntity
    {
        public bool IsPoweredOn { get; private set; } = false;
        public int DisplayWidth { get; private set; }
        public int DisplayHeight { get; private set; }
        public int CurrentStorage { get; private set; } = 0;
        public readonly int MaxStorageSpace;

        public Device(int displayWidth, int displayHeight, int maxStorage)
        {
            DisplayWidth = displayWidth;
            DisplayHeight = displayHeight;
            MaxStorageSpace = maxStorage;
        }

        // toggle the power state and return the result as a bool
        public bool TogglePower()
        {
            IsPoweredOn = !IsPoweredOn;
            return IsPoweredOn;
        }

        public bool StoreData(int data)
        {
            if ((CurrentStorage + data) < MaxStorageSpace)
            {
                CurrentStorage += data;
                // return true on successful data storage
                return true;
            } else
            {
                // return false if data could not be stored
                return false;
            }
        }
    }
}