﻿using System;
namespace DesignPattern.Builder
{
	public class Client
	{
		public static void Call()
		{
            // Constructing the PDF Report
            // Step1: Create a Builder Object 
            // Creating PDFReport Builder Object
            PDFReport pdfReport = new PDFReport();
            // Step2: Pass the Builder Object to the Director
            // First Create an instance of ReportDirector
            ReportDirector reportDirector = new ReportDirector();
            // Then Pass the pdfReport Builder Object to the MakeReport Method of ReportDirector
            // The ReportDirector will return one of the Representations of the Product
            Report report = reportDirector.MakeReport(pdfReport);
            // Step3: Display the Report by calling the DisplayReport method of the Product
            report.DisplayReport();
            Console.WriteLine("-------------------");
            // Constructing the Excel Report
            // The Process is going to be the same
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
	}
}

