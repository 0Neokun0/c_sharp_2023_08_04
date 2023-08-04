using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListernRadio();
            
            TV myTV = new TV(false, "Samsung");
            // Method of Parent Class
            myTV.SwitchOn();
            // Method of Child Class
            myTV.WatchTv();

        }
    }
}
