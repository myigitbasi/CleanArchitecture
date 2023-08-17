using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : DbContext
{
    //private readonly IConfiguration _configuration;

    //public AppDbContext(IConfiguration configuration)
    //{
    //    _configuration = configuration;
    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    IConfiguration configuration = ServiceTool.ServiceProvider.GetRequiredService<IConfiguration>();
    //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer");
    //}
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
