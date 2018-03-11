using System.Collections.Generic;
using MDS.Entities;
using Microsoft.EntityFrameworkCore;

namespace MDS.Persistence
{

    public class MdsDbContext : DbContext
    {

        public MdsDbContext(DbContextOptions<MdsDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
               modelBuilder.Entity<OrganizationCategory>()
                .HasKey(x => new { x.Organization_Id, x.Category_Id });
            modelBuilder.Entity<OrganizationCategory>()
                .HasOne(x => x.Organization)
                .WithMany(m => m.Categories)
                .HasForeignKey(x => x.Category_Id);
            modelBuilder.Entity<OrganizationCategory>()
                .HasOne(x => x.Category)
                .WithMany(e => e.Organizations)
                .HasForeignKey(x => x.Category_Id);


        }

        public virtual DbSet<Shop> Shops { get; set; }

        public virtual DbSet<OrganizationCategory> OrganizationCategories { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ShareItem> ShareItems { get; set; }
        public virtual DbSet<UserShare> UserShare { get; set; }
        public virtual DbSet<PhoneVerificationToken> PhoneVerificationToken { get; set; }
        public virtual DbSet<NotificationTamplate> NotificationTemplates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Country> Contries { get; set; }
    }

}