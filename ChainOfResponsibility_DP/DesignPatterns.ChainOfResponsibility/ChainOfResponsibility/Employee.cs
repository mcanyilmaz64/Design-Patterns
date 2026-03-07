using DesignPatterns.ChainOfResponsibility.Models;
using System.Runtime.CompilerServices;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
	public abstract class Employee
	{
		protected Employee NextApprover;
		public void SetNextApprover(Employee superVisor)
		{
			this.NextApprover = superVisor;
		}
		public abstract void ProcessRequest(CustomerProcessViewModel req);
	}
}
