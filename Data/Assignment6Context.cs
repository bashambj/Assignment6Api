using Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment6Api.Data
{
    public class Assignment6ApiContext : DbContext
    {
        public Assignment6ApiContext(DbContextOptions<Assignment6ApiContext> options) : base(options)
        {
        }
        
       // DbSet<Assignment6Names> Name { get; set;}
    }
}
