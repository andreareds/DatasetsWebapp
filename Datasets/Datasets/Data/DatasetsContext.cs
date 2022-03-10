using Microsoft.EntityFrameworkCore;
using Datasets.Models;

namespace Datasets.Data
{
    public class DatasetsContext : DbContext
    {
        public DatasetsContext(DbContextOptions<DatasetsContext> options)
            : base(options)
        {
        }

        public DbSet<Dataset> Dataset { get; set; }
    }
}