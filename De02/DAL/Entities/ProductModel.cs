using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
	public partial class ProductModel : DbContext
	{
		public ProductModel()
			: base("name=ProductModel")
		{
		}

		public virtual DbSet<LoaiSP> LoaiSP { get; set; }
		public virtual DbSet<SanPham> SanPham { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<LoaiSP>()
				.Property(e => e.MaLoai)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<LoaiSP>()
				.HasMany(e => e.SanPham)
				.WithRequired(e => e.LoaiSP)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SanPham>()
				.Property(e => e.MaSP)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<SanPham>()
				.Property(e => e.MaLoai)
				.IsFixedLength()
				.IsUnicode(false);
		}
	}
}
