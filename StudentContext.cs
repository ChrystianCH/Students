using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Students
{
	public class StudentContext : IdentityDbContext<UserEntity,
	UserRole, int>
	{ 
		public StudentContext(DbContextOptions options) : base(options) { }
		public DbSet<Student> Students { get; set; } = null!;
	}
}
