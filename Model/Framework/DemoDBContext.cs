using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class DemoDBContext : DbContext
    {
        public DemoDBContext()
            : base("DemoDBContext")
        {
        }

        public virtual DbSet<DangNhap> DangNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangNhap>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
