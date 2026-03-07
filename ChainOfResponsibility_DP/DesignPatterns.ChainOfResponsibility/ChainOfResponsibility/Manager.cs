using DesignPatterns.ChainOfResponsibility.DAL;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
	public class Manager : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			if (req.Amount <= 250000)
			{
				req.EmployeeName = "Manager - Mahmut Can Y";
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
			else if (NextApprover != null)
			{
				CustomerProcess customerProcess = new CustomerProcess();
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Manager - Mahmut Can Y";
				customerProcess.Description = "Para Çekme İşlemi Onaylanmadı. Limit aşımı olduğu için İşlem Bölge Müdürüne Yönlendirildi ";

				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
