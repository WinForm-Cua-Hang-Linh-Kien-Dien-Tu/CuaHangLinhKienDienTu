using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class donHangDao : DBContext
    {
        public int Add(DONHANG p)
        {
            int result = 0;
            context.DONHANG.Add(p);
            result = context.SaveChanges();
            return result;
        }
        public int Update(DONHANG pma)
        {
            int result = 0;
            DONHANG k = context.DONHANG.FirstOrDefault(m => m.ID == pma.ID);
            if (k != null)
            {
                k.TrangThai = pma.TrangThai;
                k.NgayDat = pma.NgayDat;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            DONHANG k = context.DONHANG.FirstOrDefault(m => m.ID == pMa);
            context.DONHANG.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<DONHANG> GetList()
        {
            List<DONHANG> list = new List<DONHANG>();
            list = context.DONHANG.ToList();
            return list;
        }

        public DONHANG GetDVByMa(int pMa)
        {
            DONHANG result = new DONHANG();
            result = context.DONHANG.FirstOrDefault(m => m.MaHD == pMa);
            return result;
        }
    }
}
