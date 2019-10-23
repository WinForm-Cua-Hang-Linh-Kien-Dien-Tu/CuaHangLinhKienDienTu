using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EF;
using DataLibrary.Model;

namespace DataLibrary.Dao
{
    public class SanPham
    {
        ModelCuaHang db = new ModelCuaHang();

        public List<SanPhamModel> LoadSanPham()
        {
            var result = db.SANPHAM.Select(sp => new SanPhamModel()
            {
                MaSP = sp.MaSP,
                MaNSX = sp.MaNSX,
                MaLoai = sp.MaLoai,
                TenSP = sp.TenSP,
                MoTa = sp.MoTa,
                Gia = sp.Gia,
                SoLuong = sp.SoLuong,
                Size = sp.Size,
                XuatXu = sp.XuatXu,
                DacTinh = sp.DacTinh,
                Hinh = sp.Hinh
            }).ToList();

            return result;
        }

        public List<SanPhamModel> combo()
        {
            var result = db.NHASANXUAT.Select(ma => new SanPhamModel()
            {
                MaNSX = ma.MaNSX
            }).ToList();
            return result;
        }

        public void AddNew(SanPhamModel modelsp)
        {
            SANPHAM sp = new SANPHAM();

            sp.MaSP = modelsp.MaSP;
            sp.MaNSX = modelsp.MaNSX;
            sp.MaLoai = modelsp.MaLoai;
            sp.TenSP = modelsp.TenSP;
            sp.MoTa = modelsp.MoTa;
            sp.Gia = modelsp.Gia;
            sp.SoLuong = modelsp.SoLuong;
            sp.Size = modelsp.Size;
            sp.XuatXu = modelsp.XuatXu;
            sp.DacTinh = modelsp.DacTinh;
            sp.Hinh = modelsp.Hinh;

            db.SANPHAM.Add(sp);
            db.SaveChanges();
            
        }

        public bool Delete(int id)
        {
            var item = GetID(id);
            if (item != null)
            {
                db.SANPHAM.Remove(item);
                db.SaveChanges();
                
                return true;
            }
            return false;
        }

        public void Edit(int id, SANPHAM sp)
        {
            var item = GetID(id);
            if(item != null)
            {
                item.MaNSX = sp.MaNSX;
                item.MaLoai = sp.MaLoai;
                item.TenSP = sp.TenSP;
                item.MoTa = sp.MoTa;
                item.Gia = sp.Gia;
                item.SoLuong = sp.SoLuong;
                item.Size = sp.Size;
                item.XuatXu = sp.XuatXu;
                item.DacTinh = sp.DacTinh;
                item.Hinh = sp.Hinh;

                db.SaveChanges();
            }
        }

        public SANPHAM GetID(int id)
        {
            return db.SANPHAM.Where(x => x.MaSP == id).FirstOrDefault();
        }
    }

}
