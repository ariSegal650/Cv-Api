
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StatisticsInfoClass> Users { get; set; }

        internal StatisticsInfoClass Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}