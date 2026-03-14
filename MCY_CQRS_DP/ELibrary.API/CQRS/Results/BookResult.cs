using ELibrary.API.DAL;

namespace ELibrary.API.CQRS.Results
{
	public class BookResult
	{
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string Url { get; set; }
		public decimal Price { get; set; }
		public int CategoryId { get; set; }
	}
}
