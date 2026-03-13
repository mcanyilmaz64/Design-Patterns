using MediatR;
using System.Reflection.Metadata.Ecma335;

namespace ELibrary.API.CQRS.Commands
{
	public class DeleteBookCommand : IRequest<bool>
	{
        public int ID { get; set; }
    }
}
