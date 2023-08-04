using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ElecticalDevice
    {

        public TV(bool isOn, string brand): base(isOn, brand)
        {

        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");

            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
