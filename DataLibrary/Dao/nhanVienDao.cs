using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class nhanVienDao : DBContext
    {
        public int Add(NHANVIEN p)
        {
            int result = 0;
            context.NHANVIEN.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(NHANVIEN pma)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIEN.FirstOrDefault(m => m.MaNV == pma.MaNV);
            if (k != null)
            {
                k.TenNV = pma.TenNV;
                k.NgaySinh = pma.NgaySinh;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.ChucVu = pma.ChucVu;
                k.SDT = pma.SDT;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Update(NHANVIEN pma, int ma)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIEN.FirstOrDefault(m => m.MaNV == ma);
            if (k != null)
            {
                k.TenNV = pma.TenNV;
                k.NgaySinh = pma.NgaySinh;
                k.Phai = pma.Phai;
                k.DiaChi = pma.DiaChi;
                k.ChucVu = pma.ChucVu;
                k.SDT = pma.SDT;
            }
            result = context.SaveChanges();
            return result;
        }


        public int Delete(int pMa)
        {
            int result = 0;
            NHANVIEN k = context.NHANVIEN.FirstOrDefault(m => m.MaNV == pMa);
            context.NHANVIEN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHANVIEN> GetList()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = context.NHANVIEN.ToList();
            return list;
        }

        public List<NHANVIEN> GetList(string pTen)
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = context.NHANVIEN.Where(t => t.TenNV == pTen).ToList();
            return list;
        }

        public NHANVIEN GetDVByMa(int pMa)
        {
            NHANVIEN result = new NHANVIEN();
            result = context.NHANVIEN.FirstOrDefault(m => m.MaNV == pMa);
            return result;
        }
    }
}
