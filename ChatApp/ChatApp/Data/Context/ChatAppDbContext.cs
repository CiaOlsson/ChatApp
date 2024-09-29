using ChatApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Data.Context
{
	public class ChatAppDbContext : DbContext
	{
		public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options): base(options)
		{

		}

		public DbSet<ChatMessage> ChatMessages { get; set; }
		public DbSet<Conversation> Conversations { get; set; }
		public DbSet<User> Users { get; set; }

	}
}
