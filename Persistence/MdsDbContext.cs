using System.Collections.Generic;
using System.Linq;
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

         public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ShareItem> ShareItems { get; set; }
        public virtual DbSet<UserShare> UserShare { get; set; }
        public virtual DbSet<PhoneVerificationToken> PhoneVerificationToken { get; set; }
        public virtual DbSet<NotificationTamplate> NotificationTemplates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Country> Contries { get; set; }
        public virtual DbSet<NotificationsLog> NotificationsLogs { get; set; }

        public virtual DbSet<IBeacon> Biacons { get; set; }


        public override int SaveChanges()
        {
            var added = ChangeTracker.Entries<BaseEntity>().Where(c => c.State == EntityState.Added);

            if (added != null)
            {
                foreach (var entry in added)
                {
                    ((BaseEntity)entry.Entity).SetDateCreated();
                }
            }

            var modified = this.ChangeTracker.Entries<BaseEntity>().Where(c => c.State == EntityState.Modified);

            if (modified != null)
            {
                foreach (var entry in modified)
                {
                    ((BaseEntity)entry.Entity).SetDateUpdated();
                }
            }
            base.SaveChanges();

            return base.SaveChanges();
        }

    }
}