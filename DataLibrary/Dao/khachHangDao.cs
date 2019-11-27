using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class khachHangDao : DBContext
    {
        public int Add(KHACHHANG p)
        {
            int result = 0;
            context.KHACHHANG.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(KHACHHANG pma)
        {
            int result = 0;
            KHACHHANG k = context.KHACHHANG.FirstOrDefault(m => m.MaKH == pma.MaKH);
            if (k != null)
            {
                k.TenKH = pma.TenKH;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.SDT = pma.SDT;
                k.LoaiKH = pma.LoaiKH;
                k.SoTaiKhoan = pma.SoTaiKhoan;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            KHACHHANG k = context.KHACHHANG.FirstOrDefault(m => m.MaKH == pMa);
            context.KHACHHANG.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<KHACHHANG> GetList()
        {
            List<KHACHHANG> list = new List<KHACHHANG>();
            list = context.KHACHHANG.ToList();
            return list;
        }

        public KHACHHANG GetDVByMa(int pMa)
        {
            KHACHHANG result = new KHACHHANG();
            result = context.KHACHHANG.FirstOrDefault(m => m.MaKH == pMa);
            return result;
        }
    }
}
