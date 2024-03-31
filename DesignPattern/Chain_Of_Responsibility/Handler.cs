using System;
namespace DesignPattern.Chain_Of_Responsibility
{
	public abstract class Handler
	{
        public Handler NextHandler;
        //Initializing NextHandler reference using the class constructor
        public void SetNextHandler(Handler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle a request.
        public abstract void DispatchNote(long requestedAmount);
    }
}

