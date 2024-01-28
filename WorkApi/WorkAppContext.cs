using Microsoft.EntityFrameworkCore;
using WorkApi.Models;

namespace WorkApi {
    public class WorkAppContext: DbContext
    {
        public WorkAppContext(DbContextOptions<WorkAppContext> contextOptions): base(contextOptions)
        {
            Database.EnsureCreated();
        }

        public DbSet<Job> Jobs { get; set; }
    }
}