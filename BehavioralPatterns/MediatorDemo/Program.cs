using System;
using MediatorDemo.Structural;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var dev = new ColleagueDev(mediator);
            var test = new ColleagueTest(mediator);

            // Mediator needs to kno about all Colleagues
            mediator.ColleagueDev = dev;
            mediator.ColleagueTest = test;

            dev.Send("Hello from DEV World, its better here");
            test.Send("We are the testers, beeboop");

        }
    }
}
