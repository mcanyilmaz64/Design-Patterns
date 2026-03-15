using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.Reports
{
	internal class PdfReport : ReportGenerator
	{
		protected override void Content()
		{
			const string content = "This is the content of the PDF report.";
		}

		protected override void Writer()
		{
			Console.WriteLine("Writing the PDF report to a file...");
			Console.WriteLine("PDF report has been written successfully.");
		}

	
	}
}
