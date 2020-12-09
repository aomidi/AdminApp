using AdminApp.Infra.Data.Context;
using AdminApp.Mvc.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersianTranslation.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminApp.Infra.IoC;

namespace AdminApp.Mvc
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews().AddRazorRuntimeCompilation();

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("AdminAppConnection")));

			services.AddDbContext<AdminAppDbContext>(options =>
			{
				options.UseSqlServer(Configuration.GetConnectionString("AdminAppConnection"));
			});

			services.AddDefaultIdentity<IdentityUser>(options =>
				{
					options.SignIn.RequireConfirmedAccount = false;
					options.Password.RequiredLength = 3;
					options.Password.RequireLowercase = false;
					options.Password.RequireNonAlphanumeric = false;
					options.Password.RequireUppercase = false;
					options.Password.RequiredUniqueChars = 0;
					options.Password.RequireDigit = false;

				})
				.AddEntityFrameworkStores<ApplicationDbContext>();

			//services.AddIdentity<IdentityUser, IdentityRole>(options => {
			//		options.Password.RequiredLength = 3;
			//		options.Password.RequireLowercase = false;
			//		options.Password.RequireNonAlphanumeric = false;
			//		options.Password.RequireUppercase = false;
			//		options.Password.RequiredUniqueChars = 0;
			//		options.Password.RequireDigit = false;
			//		options.User.RequireUniqueEmail = true;
			//		options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
			//		options.Lockout.MaxFailedAccessAttempts = 3;

			//	})
			//	.AddEntityFrameworkStores<ApplicationDbContext>()
			//	.AddDefaultTokenProviders()
			//	.AddErrorDescriber<PersianIdentityErrorDescriber>();


			services.AddRazorPages();

			services.AddMemoryCache();

			RegisterServices(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}

		public static void RegisterServices(IServiceCollection service)
		{
			DependencyContainer.RegisterServices(service);
		}

	}
}
