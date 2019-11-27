namespace DataLibrary.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCuaHang : DbContext
    {
        public ModelCuaHang()
            : base("name=ModelCuaHang")
        {
        }

        public virtual DbSet<CART_ITEM> CART_ITEM { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADON { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOAI> LOAI { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<NHASANXUAT> NHASANXUAT { get; set; }
        public virtual DbSet<QUYEN> QUYEN { get; set; }
        public virtual DbSet<SANPHAM> SANPHAM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.Phai)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SoTaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.CART_ITEM)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.MA_KH);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QUYEN>()
                .Property(e => e.User)
                .IsFixedLength();

            modelBuilder.Entity<QUYEN>()
                .Property(e => e.PassWord)
                .IsFixedLength();

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CART_ITEM)
                .WithOptional(e => e.SANPHAM)
                .HasForeignKey(e => e.MA_SP);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETHOADON)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);
        }
    }
}
