using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EF;

namespace DataLibrary.Dao
{
    public class SanPham : DBContext
    {
        public int Add(SANPHAM p)
        {
            int result = 0;
            context.SANPHAM.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(SANPHAM pma, int ma)
        {
            int result = 0;
            SANPHAM k = context.SANPHAM.FirstOrDefault(m => m.MaSP == ma);
            if (k != null)
            {
                k.MaNSX = pma.MaNSX;
                k.MaLoai = pma.MaLoai;
                k.TenSP = pma.MoTa;
                k.Gia = pma.Gia;
                k.SoLuong = pma.SoLuong;
                k.Size = pma.Size;
                k.XuatXu = pma.XuatXu;
                k.DacTinh = pma.DacTinh;
                k.Hinh = pma.Hinh;
            }
            result = context.SaveChanges();
            return result;
        }

        public int UpdateSoLuong(SANPHAM pma)
        {
            int result = 0;
            SANPHAM k = context.SANPHAM.FirstOrDefault(m => m.MaSP == pma.MaSP);
            if (k != null)
            {
                k.SoLuong = pma.SoLuong;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            SANPHAM k = context.SANPHAM.FirstOrDefault(m => m.MaSP == pMa);
            context.SANPHAM.Remove(k);
            result = context.SaveChanges();
            return result;
        }

        public List<SANPHAM> GetList()
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = context.SANPHAM.ToList();
            return list;
        }

        public List<SANPHAM> GetList(string pTen)
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = context.SANPHAM.Where(t => t.TenSP == pTen).ToList();
            return list;
        }

        public List<SANPHAM> GetListLoai(int pMaLoai)
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = context.SANPHAM.Where(t =>t.MaLoai == pMaLoai).ToList();
            return list;
        }

        public List<SANPHAM> GetListNSX(int pMaNSX)
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = context.SANPHAM.Where(t => t.MaNSX == pMaNSX).ToList();
            return list;
        }

        public int GetMaSP(string ten)
        {
            int ma;
            SANPHAM k = context.SANPHAM.FirstOrDefault(m => m.TenSP == ten);
            ma = Convert.ToInt32(k.MaSP);
            return ma;
        }

        public SANPHAM GetDVByMa(int pMa)
        {
            SANPHAM result = new SANPHAM();
            result = context.SANPHAM.FirstOrDefault(m => m.MaSP == pMa);
            return result;
        }

        public List<string> GetDSTen()
        {
            var list = from a in context.SANPHAM select a.TenSP;
            return list.ToList();
        }

        public double GetGiaSP(string ten)
        {
            double gia;
            SANPHAM k = context.SANPHAM.FirstOrDefault(m => m.TenSP == ten);
            gia = Convert.ToDouble(k.Gia);
            return gia;
        }
    }

}
