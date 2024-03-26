using System;
namespace DesignPattern.Factory.Ex2
{
    public class WordDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}

