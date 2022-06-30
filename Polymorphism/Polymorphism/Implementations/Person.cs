using Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Person : Test, ISpeak , IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person eating -" + time);
        }

        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }
    }
    
}
