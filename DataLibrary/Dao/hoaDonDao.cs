using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class hoaDonDao : DBContext
    {
        public int Add(HOADON p)
        {
            int result = 0;
            context.HOADON.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(HOADON pma)
        {
            int result = 0;
            HOADON k = context.HOADON.FirstOrDefault(m => m.MaHD == pma.MaHD);
            if (k != null)
            {
                k.MaKH = pma.MaKH;
                k.MaNV = pma.MaNV   ;
                k.DiaChi = pma.DiaChi;
                k.TongMatHang = pma.TongMatHang;
                k.TongTien = pma.TongTien;
                k.NgayLap = pma.NgayLap;
                k.NgayGiao = pma.NgayGiao;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            HOADON k = context.HOADON.FirstOrDefault(m => m.MaHD == pMa);
            context.HOADON.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<HOADON> GetList()
        {
            List<HOADON> list = new List<HOADON>();
            list = context.HOADON.ToList();
            return list;
        }

        public HOADON GetDVByMa(int pMa)
        {
            HOADON result = new HOADON();
            result = context.HOADON.FirstOrDefault(m => m.MaHD == pMa);
            return result;
        }
    }
}
