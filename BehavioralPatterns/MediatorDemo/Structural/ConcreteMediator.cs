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
        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            colleagues.Add(colleague);
        }

        public override void Send(string message, Colleague colleague)
        {
            //if(colleague == ColleagueDev)
            //    ColleagueTest.HandleNotification(message);
            //else
            //    ColleagueDev.HandleNotification(message);

            colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
