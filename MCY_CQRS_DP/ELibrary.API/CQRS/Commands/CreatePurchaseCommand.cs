using ELibrary.API.DAL;
using MediatR;

namespace ELibrary.API.CQRS.Commands
{
	public class CreatePurchaseCommand : IRequest<bool>
	{
	public int UserId { get; set; }
	public int BookId { get; set; }
	}
}
