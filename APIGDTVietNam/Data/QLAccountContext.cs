using APIGDTVietNam.Models;
using Microsoft.EntityFrameworkCore;

namespace APIGDTVietNam.Data{
    public class QLAccountContext : DbContext{
    public QLAccountContext(DbContextOptions<QLAccountContext> opt) : base(opt)
    {

    }
    public DbSet<Account> accounts{get; set;}
    }
}