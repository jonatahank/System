using Microsoft.AspNetCore.Identity;

namespace Data.Context.Models
{
	public class AppUser: IdentityUser
	{
		public string DisplayName { get; set; }
	}
}
