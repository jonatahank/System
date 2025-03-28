﻿using Data.Context.Models;
using Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Api.Extensions
{
	public static class IdentityServiceExtensions
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
		{
			var builder = services.AddIdentityCore<AppUser>();
			builder = new IdentityBuilder(builder.UserType, builder.Services);
			builder.AddEntityFrameworkStores<AppIdentityDbContext>();
			builder.AddSignInManager<SignInManager<AppUser>>();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
					.AddJwtBearer(options => {
						options.TokenValidationParameters = new TokenValidationParameters
						{
							ValidateIssuerSigningKey = true,
							IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"])),
							ValidIssuer = configuration["Token:Issuer"],
							ValidateIssuer = true,
							ValidateAudience = false
						};
					});

			return services;
		}
	}
}
