using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class person
    {
        private byte age { get; set; }
        private bool dui { get; set; }
        private byte speeding { get; set; }
        public person(byte age, bool dui, byte speeding)
        {
            this.age = age;
            this.dui = dui;
            this.speeding = speeding;
        }
        public void CanGetInsurance()
        {
            bool insure = age > 15 && dui == false && speeding < 3;
            Console.WriteLine("Qualified\n{0}", insure);
        }
    }
}
