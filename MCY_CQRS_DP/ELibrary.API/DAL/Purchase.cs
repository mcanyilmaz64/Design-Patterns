using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.DAL
{
	public class Purchase
	{
		[Key]
		public int PurchaseId { get; set; }
        public DateTime PurchaseTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
