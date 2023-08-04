﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age) {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }
        
        public virtual void MakeSound()
        {
            Console.WriteLine("Woooof");
        }

        public override void Play()
        {
            base.Play();
        }
    }
}
