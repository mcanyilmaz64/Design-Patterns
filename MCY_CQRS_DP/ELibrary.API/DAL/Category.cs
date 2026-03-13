using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.DAL
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
        public string CategoryName { get; set; }
		public List <Book> Books { get; set; }
    }
}
