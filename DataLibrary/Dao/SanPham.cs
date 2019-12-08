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

        public SANPHAM GetDVByMa(int pMa)
        {
            SANPHAM result = new SANPHAM();
            result = context.SANPHAM.FirstOrDefault(m => m.MaSP == pMa);
            return result;
        }
        
    }

}
