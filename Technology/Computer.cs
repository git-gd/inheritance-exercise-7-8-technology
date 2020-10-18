using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : Device
    {
        public string CaseStyle { get; }

        public Computer(int displayWidth, int displayHeight, int maxStorage, string caseStyle) : base(displayWidth, displayHeight, maxStorage)
        {
            CaseStyle = caseStyle;
        }

        public void TypeOnKeyboard()
        {
            Console.WriteLine("Clickety-Clack");
        }
    }
}