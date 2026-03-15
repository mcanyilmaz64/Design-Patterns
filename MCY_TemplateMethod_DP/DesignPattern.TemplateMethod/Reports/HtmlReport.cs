using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.Reports
{
	internal class HtmlReport : ReportGenerator
	{	
		protected override void Content()
		{
			Console.WriteLine("This is the content of the HTML report.");
		}

		protected override void Writer()
		{
			Console.WriteLine("Writing the Html report to a file...");
			Console.WriteLine("Html report has been written successfully.");
		}
	
	}
}
