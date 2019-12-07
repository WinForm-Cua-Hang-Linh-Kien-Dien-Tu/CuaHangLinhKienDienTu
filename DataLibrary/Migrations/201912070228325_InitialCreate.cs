namespace DataLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CART_ITEM",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        MA_KH = c.Int(),
                        SoLuong = c.Int(),
                        NgayTao = c.DateTime(),
                        MA_SP = c.Int(),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.KHACHHANG", t => t.MA_KH)
                .ForeignKey("dbo.SANPHAM", t => t.MA_SP)
                .Index(t => t.MA_KH)
                .Index(t => t.MA_SP);
            
            CreateTable(
                "dbo.KHACHHANG",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        TenKH = c.String(maxLength: 50),
                        Phai = c.String(maxLength: 3, fixedLength: true),
                        DiaChi = c.String(maxLength: 200),
                        SDT = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        LoaiKH = c.String(maxLength: 6),
                        SoTaiKhoan = c.String(maxLength: 7, fixedLength: true, unicode: false),
                        TaiKhoan = c.String(maxLength: 50, fixedLength: true, unicode: false),
                        MatKhau = c.String(maxLength: 50, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.DONHANG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaKH = c.Int(),
                        MaHD = c.Int(),
                        TrangThai = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HOADON", t => t.MaHD)
                .ForeignKey("dbo.KHACHHANG", t => t.MaKH)
                .Index(t => t.MaKH)
                .Index(t => t.MaHD);
            
            CreateTable(
                "dbo.HOADON",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        MaKH = c.Int(),
                        MaNV = c.Int(),
                        DiaChi = c.String(maxLength: 100),
                        TongMatHang = c.Int(),
                        TongTien = c.Double(),
                        NgayLap = c.DateTime(storeType: "date"),
                        NgayGiao = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.CHITIETHOADON",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaHD = c.Int(nullable: false),
                        MaSP = c.Int(nullable: false),
                        SoLuong = c.Int(),
                        DonGia = c.Double(),
                        ThanhTien = c.Double(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SANPHAM", t => t.MaSP)
                .ForeignKey("dbo.HOADON", t => t.MaHD)
                .Index(t => t.MaHD)
                .Index(t => t.MaSP);
            
            CreateTable(
                "dbo.SANPHAM",
                c => new
                    {
                        MaSP = c.Int(nullable: false, identity: true),
                        MaNSX = c.Int(),
                        MaLoai = c.Int(),
                        TenSP = c.String(maxLength: 100),
                        MoTa = c.String(maxLength: 500),
                        Gia = c.Double(),
                        SoLuong = c.Int(),
                        Size = c.String(maxLength: 100),
                        XuatXu = c.String(maxLength: 30),
                        DacTinh = c.String(maxLength: 500),
                        Hinh = c.String(maxLength: 500, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaSP)
                .ForeignKey("dbo.LOAI", t => t.MaLoai)
                .ForeignKey("dbo.NHASANXUAT", t => t.MaNSX)
                .Index(t => t.MaNSX)
                .Index(t => t.MaLoai);
            
            CreateTable(
                "dbo.LOAI",
                c => new
                    {
                        MaLoai = c.Int(nullable: false, identity: true),
                        TenLoai = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            CreateTable(
                "dbo.NHASANXUAT",
                c => new
                    {
                        MaNSX = c.Int(nullable: false, identity: true),
                        TenNSX = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNSX);
            
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        TenNV = c.String(maxLength: 50),
                        NgaySinh = c.DateTime(storeType: "date"),
                        Phai = c.String(maxLength: 5),
                        DiaChi = c.String(maxLength: 200),
                        SDT = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        ChucVu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.QUYEN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaNV = c.Int(),
                        User = c.String(maxLength: 12, fixedLength: true),
                        PassWord = c.String(maxLength: 20, fixedLength: true),
                        Quyen = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV)
                .Index(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DONHANG", "MaKH", "dbo.KHACHHANG");
            DropForeignKey("dbo.QUYEN", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.HOADON", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.DONHANG", "MaHD", "dbo.HOADON");
            DropForeignKey("dbo.CHITIETHOADON", "MaHD", "dbo.HOADON");
            DropForeignKey("dbo.SANPHAM", "MaNSX", "dbo.NHASANXUAT");
            DropForeignKey("dbo.SANPHAM", "MaLoai", "dbo.LOAI");
            DropForeignKey("dbo.CHITIETHOADON", "MaSP", "dbo.SANPHAM");
            DropForeignKey("dbo.CART_ITEM", "MA_SP", "dbo.SANPHAM");
            DropForeignKey("dbo.CART_ITEM", "MA_KH", "dbo.KHACHHANG");
            DropIndex("dbo.QUYEN", new[] { "MaNV" });
            DropIndex("dbo.SANPHAM", new[] { "MaLoai" });
            DropIndex("dbo.SANPHAM", new[] { "MaNSX" });
            DropIndex("dbo.CHITIETHOADON", new[] { "MaSP" });
            DropIndex("dbo.CHITIETHOADON", new[] { "MaHD" });
            DropIndex("dbo.HOADON", new[] { "MaNV" });
            DropIndex("dbo.DONHANG", new[] { "MaHD" });
            DropIndex("dbo.DONHANG", new[] { "MaKH" });
            DropIndex("dbo.CART_ITEM", new[] { "MA_SP" });
            DropIndex("dbo.CART_ITEM", new[] { "MA_KH" });
            DropTable("dbo.QUYEN");
            DropTable("dbo.NHANVIEN");
            DropTable("dbo.NHASANXUAT");
            DropTable("dbo.LOAI");
            DropTable("dbo.SANPHAM");
            DropTable("dbo.CHITIETHOADON");
            DropTable("dbo.HOADON");
            DropTable("dbo.DONHANG");
            DropTable("dbo.KHACHHANG");
            DropTable("dbo.CART_ITEM");
        }
    }
}
