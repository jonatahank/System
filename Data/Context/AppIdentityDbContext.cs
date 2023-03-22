using Data.Context.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
	public class AppIdentityDbContext: IdentityDbContext<AppUser>
	{
		public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }
		public DbSet<Category> Categories { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
