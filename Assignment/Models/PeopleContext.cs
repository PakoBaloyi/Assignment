using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }
        public DbSet<PersonalDetail> People { get; set; }
    }
}
