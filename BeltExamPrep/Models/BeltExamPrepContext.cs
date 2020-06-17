using BeltExamPrep.Models;
using Microsoft.EntityFrameworkCore;

namespace BeltExamPrep.Models
{
    public class BeltExamPrepContext : DbContext
    {
        public BeltExamPrepContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }
        // public DbSet<Widget> Widgets { get; set; }
        // public DbSet<Item> Items { get; set; }
    }
}