using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();

            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();


            Test test = new Test();
            test.Id = 6;

            Person person = new Person();
           
            person.Speak();
            person.Eating(DateTime.Now);
        }
    }
}
 