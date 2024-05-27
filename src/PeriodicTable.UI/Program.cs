using Microsoft.EntityFrameworkCore;
using PeriodicTable.Application.ServiceContracts;
using PeriodicTable.Application.Services;
using PeriodicTable.Domain.RepositoryContracts;
using PeriodicTable.Infrastructure.Database;
using PeriodicTable.Infrastructure.Repositories;

namespace PeriodicTable.UI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});

			builder.Services.AddScoped<IElementsRepository, ElementsRepository>();
			builder.Services.AddScoped<IElementsService, ElementsService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseHsts();
			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();
			app.MapControllers();

			app.Run();
		}
	}
}
