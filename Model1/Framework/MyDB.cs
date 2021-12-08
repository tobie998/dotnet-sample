using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model1.Framework
{
    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
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
