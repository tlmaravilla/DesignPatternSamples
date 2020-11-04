using System;
using MediatorDemo.Structural;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var dev = new ColleagueDev();
            var test = new ColleagueTest();

            mediator.Register(dev);
            mediator.Register(test);

            dev.Send("Hello from DEV World, its better here");
            test.Send("We are the testers, beeboop");

        }
    }
}
