namespace MobiNews.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MobiNews.Data.Models;

    public partial class MobiNewsContext : DbContext
    {
        public MobiNewsContext()
            : base("name=MobiNewsDb")
        {
        }

        public virtual DbSet<NewStory> NewStories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
