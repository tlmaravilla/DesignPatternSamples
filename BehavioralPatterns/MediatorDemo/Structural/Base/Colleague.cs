﻿namespace MediatorDemo.Structural.Base
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        internal void SetMediator(Mediator mediator) => Mediator = mediator;

        // SEND MSGS
        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }

        // RECEIVE MSGS
        public abstract void HandleNotification(string message);
    }
}