using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.Reports
{
	public abstract class ReportGenerator
	{
		public void GenerateReport()
		{
			Header();
			Date();
			Content();
			Writer();
		}
		private void Header() 
		{
			Console.WriteLine("MCY COMPANY DAILY REPORT");
		}
		private void Date()
		{
			var date = DateTime.Now;
			Console.WriteLine($"Date: {date.ToShortDateString()}");
		}
		protected abstract void Content();
		protected abstract void Writer();


    }
}
