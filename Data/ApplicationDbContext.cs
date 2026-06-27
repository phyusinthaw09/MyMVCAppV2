using Microsoft.EntityFrameworkCore;
using MyMVCAppV2.Models; // ပရောဂျက်အသစ်ရဲ့ နာမည်အတိုင်း သုံးထားပါတယ်

namespace MyMVCAppV2.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}