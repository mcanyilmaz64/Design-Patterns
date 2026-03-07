using DesignPatterns.ChainOfResponsibility.DAL;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
	public class AreaDirector : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			if (req.Amount <= 400000)
			{
				req.EmployeeName = "Area Director - Mahmut Can Yılmaz";
				req.Description = "Para Çekme İşlemi Onaylandı. Müşteriye tutar ödendi";
				context.CustomerProcesses.Add(new CustomerProcess
				{
					Name = req.Name,
					Amount = req.Amount.ToString(),
					EmployeeName = req.EmployeeName,
					Description = req.Description
				});
				context.SaveChanges();
			}
			else
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Area Director - Mahmut Can Yılmaz";
				customerProcess.Description = "Para Çekme İşlemi Onaylanmadı.Müşterinin Günlük Limiti Maksimum 400.000 TL'dir. !!";

				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
		}
	}
}
