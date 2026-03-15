using DesignPattern.TemplateMethod.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<ReportGenerator> reports = new List<ReportGenerator>
			{
				new ExcelReport(),
				new PdfReport(),
				new HtmlReport()
			};

			Console.WriteLine("Please Choose The Report Type ");
			Console.WriteLine("1. Excel Report");
			Console.WriteLine("2. PDF Report");
			Console.WriteLine("3. HTML Report");

			var input = Console.ReadLine();
			for (int i = 0; i < reports.Count; i++)
			{
				if (input == (i + 1).ToString())
				{
					reports[i].GenerateReport();
					break;
				}
			}
			Console.ReadLine();
		}
	}
}
