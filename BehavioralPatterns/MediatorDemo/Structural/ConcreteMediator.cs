using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorDemo.Structural.Base;

namespace MediatorDemo.Structural
{
    public class ConcreteMediator : Mediator
    {
        public ColleagueDev ColleagueDev { get; set; }
        
        public ColleagueTest ColleagueTest { get; set; }

        public override void Send(string message, Colleague colleague)
        {
           
            if(colleague == ColleagueDev)
                ColleagueTest.HandleNotification(message);
            else
                ColleagueDev.HandleNotification(message);

        }
    }
}
