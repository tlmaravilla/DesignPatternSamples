using MediatorDemo.Structural.Base;
using System;

namespace MediatorDemo.Structural
{
    public class ColleagueDev : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Dev receives notification message: {message}");
        }
    }
}
