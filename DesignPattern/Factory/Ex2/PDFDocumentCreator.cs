using System;
namespace DesignPattern.Factory.Ex2
{
    public class PDFDocumentCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new PDFDocument();
        }
    }
}

