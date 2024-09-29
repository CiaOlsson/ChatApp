using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ChatApp.Data.Entities
{
	public class Conversation
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public bool IsPrivate { get; set; }
		[AllowNull]
		public string AuthCode { get; set; }

		public virtual ICollection<ChatMessage> Messages { get; set; }
	}
}
