using System;
namespace DesignPattern.Command
{
    public class OpenCommand : ICommand
    {
        //Reference of Receiver Object
        private Document document;
        //Initializing the Receiver Object using the Constructor
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Open Method
        public void Execute()
        {
            document.Open();
        }
    }
}
	

