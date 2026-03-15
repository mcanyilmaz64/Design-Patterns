using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.Reports
{
	public class ExcelReport : ReportGenerator
	{
		protected override void Content()
		{
			Console.WriteLine("This is the content of the Excel report.");
		}

		protected override void Writer()
		{
			
			Console.WriteLine("Writing the Excel report to a file...");
			Console.WriteLine("Excel report has been written successfully.");
		}

	}
}
