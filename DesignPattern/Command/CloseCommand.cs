using System;
namespace DesignPattern.Command
{
	public class CloseCommand : ICommand
    {
        //Reference of Receiver Object
        private Document document;
        //Initializing the Receiver Object using the Constructor
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Close Method
        public void Execute()
        {
            document.Close();
        }
    }
}

