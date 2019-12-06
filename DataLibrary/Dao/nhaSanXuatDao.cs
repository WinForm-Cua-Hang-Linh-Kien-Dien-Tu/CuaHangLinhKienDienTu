using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class nhaSanXuatDao : DBContext
    {
        public int Add(NHASANXUAT p)
        {
            int result = 0;
            context.NHASANXUAT.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(NHASANXUAT pma)
        {
            int result = 0;
            NHASANXUAT k = context.NHASANXUAT.FirstOrDefault(m => m.MaNSX == pma.MaNSX);
            if (k != null)
            {
                k.TenNSX = pma.TenNSX;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            NHASANXUAT k = context.NHASANXUAT.FirstOrDefault(m => m.MaNSX == pMa);
            context.NHASANXUAT.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<NHASANXUAT> GetList()
        {
            List<NHASANXUAT> list = new List<NHASANXUAT>();
            list = context.NHASANXUAT.ToList();
            return list;
        }

        public List<string> GetDSTen()
        {
            var list = from a in context.NHASANXUAT select a.TenNSX;
            return list.ToList();
        }

        public NHASANXUAT GetDVByMa(int? pMa)
        {
            NHASANXUAT result = new NHASANXUAT();
            result = context.NHASANXUAT.FirstOrDefault(m => m.MaNSX == pMa);
            return result;
        }

        public NHASANXUAT GetDVByMa(string pten)
        {
            NHASANXUAT result = new NHASANXUAT();
            result = context.NHASANXUAT.FirstOrDefault(m => m.TenNSX == pten);
            return result;
        }
    }
}
