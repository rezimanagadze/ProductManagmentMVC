using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductManagmentMVC.Areas.Identity.Data;
using ProductManagmentMVC.Entity;

namespace ProductManagmentMVC.Data;

public class ProductManagmentMVCContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Category>Categories { get; set; }



    public ProductManagmentMVCContext(DbContextOptions<ProductManagmentMVCContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new CategoryConfiguration());


        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
