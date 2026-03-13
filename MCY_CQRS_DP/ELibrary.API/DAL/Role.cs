using System.ComponentModel.DataAnnotations;

namespace ELibrary.API.DAL
{
	public class Role
	{
		[Key]
		public int RoleId { get; set; }
        public string  RoleName { get; set; }
		public List<User> Users { get; set; }
    }
}
