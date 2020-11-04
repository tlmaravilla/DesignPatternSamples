using MediatorDemo.Structural.Base;
using System;

namespace MediatorDemo.Structural
{
    public class ColleagueTest : Colleague
    {
        public ColleagueTest(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Test receives notification message: {message}");
        }
    }
}
