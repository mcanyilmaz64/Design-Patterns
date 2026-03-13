using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.DAL
{
	public class Book
	{
		[Key]
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string Url { get; set; }
		public decimal Price { get; set; }
        public bool Status { get; set; }
		public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Purchase> Purchases { get; set; }
		
    }
}
