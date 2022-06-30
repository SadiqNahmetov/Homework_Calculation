using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
     public abstract class Animal
    {
        public string Name { get; set; }


        public abstract void Eat();

        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
}
