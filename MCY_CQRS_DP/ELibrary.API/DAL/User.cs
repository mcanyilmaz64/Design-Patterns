using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.DAL
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string NameSurname { get; set; }
		public string UserName { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
		public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool Status { get; set; }
    }
}
