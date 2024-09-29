using System.ComponentModel.DataAnnotations;

namespace ChatApp.Data.Entities
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string PasswordHash { get; set; }

		public virtual ICollection<ChatMessage> Messages { get; set; }

	}
}
