using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Framework
{
    public partial class ManagerDBContext : DbContext
    {
        public ManagerDBContext()
            : base("name=ManagerDBContext")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<AssignRecord> AssignRecords { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DoneJob> DoneJobs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Footer> Footers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAssign> JobAssigns { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.StartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.EndTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.Shift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AssignRecord>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<DoneJob>()
                .Property(e => e.SoLoSanPham)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DoneJob>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DoneJob>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ContractWage)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.InsuranceWage)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Job>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<JobAssign>()
                .Property(e => e.Shift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobAssign>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<JobAssign>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.RegisterCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
