using a;
using Microsoft.EntityFrameworkCore;

namespace b
{
    public class DbCon:DbContext
    {
        public DbSet<Student> students { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlite(@"Data Source=studb.dat");
        }
    }
}
