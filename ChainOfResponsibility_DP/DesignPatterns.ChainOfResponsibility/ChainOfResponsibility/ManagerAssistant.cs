using DesignPatterns.ChainOfResponsibility.DAL;
using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
	public class ManagerAssistant : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			if (req.Amount <= 150000)
			{
				req.EmployeeName = "Manager Assistant - MCan";
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
				customerProcess.EmployeeName = "Manager Assistant - MCan";
				customerProcess.Description = "Para Çekme İşlemi Onaylanmadı. Limit aşımı olduğu için İşlem Şube Müdürüne Yönlendirildi ";

				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
