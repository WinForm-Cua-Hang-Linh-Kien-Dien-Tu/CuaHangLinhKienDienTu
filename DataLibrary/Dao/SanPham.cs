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

        public List<SANPHAM> GetList()
        {
            return db.SANPHAM.ToList();
        }

        public List<SanPhamModel> LoadSanPham()
        {
            var result = db.SANPHAM.Select(sp => new SanPhamModel()
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                TenLoai = (from b in db.LOAI where b.MaLoai == sp.MaLoai select b.TenLoai).FirstOrDefault(),
                TenNSX = (from b in db.NHASANXUAT where b.MaNSX == sp.MaNSX select b.TenNSX).FirstOrDefault(),
                MoTa = sp.MoTa,
                Gia = sp.Gia,
                SoLuong = sp.SoLuong,
                Size = sp.Size,
                XuatXu = sp.XuatXu,
                DacTinh = sp.DacTinh,
                TenHinh = sp.Hinh,
                MaNSX = sp.MaNSX,
                MaLoai = sp.MaLoai
            }).ToList();

            return result;
        }

        public int idMaNSX(string tenNSX)
        {
            var a = Convert.ToInt32((from b in db.NHASANXUAT where b.TenNSX == tenNSX select b.MaNSX).FirstOrDefault());
            return a;
        }

        public int idMaLoai(string teLoai)
        {
            var a = Convert.ToInt32((from b in db.LOAI where b.TenLoai == teLoai select b.MaLoai).FirstOrDefault());
            return a;
        }

        public List<SanPhamModel> loadTenNSX()
        {
            var result = db.NHASANXUAT.Select(ma => new SanPhamModel()
            {
                TenNSX = ma.TenNSX
            }).ToList();
            return result;
        }

        public List<SanPhamModel> loadTenLoai()
        {
            var result = db.LOAI.Select(ma => new SanPhamModel()
            {
                TenLoai = ma.TenLoai
            }).ToList();
            return result;
        }

        public List<SanPhamModel> loadXuatXu()
        {
            var result = db.SANPHAM.Select(ma => new SanPhamModel()
            {
               XuatXu = ma.XuatXu
            }).ToList();
            return result;
        }

        public void AddNew(SANPHAM modelsp)
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
            db.SaveChangesAsync();
            
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

        public SANPHAM GetDVByMa(int pMa)
        {
            SANPHAM result = new SANPHAM();
            result = db.SANPHAM.FirstOrDefault(m => m.MaSP == pMa);
            return result;
        }
    }

}
