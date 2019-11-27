using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class loaiDao : DBContext
    {
            public int Add(LOAI p)
            {
                int result = 0;
                context.LOAI.Add(p);
                result = context.SaveChanges();
                return result;
            }
            public int Update(LOAI pma)
            {
                int result = 0;
                LOAI k = context.LOAI.FirstOrDefault(m => m.MaLoai == pma.MaLoai);
                if (k != null)
                {
                    k.TenLoai = pma.TenLoai;
                }
                result = context.SaveChanges();
                return result;
            }

            public int Delete(int pMa)
            {
                int result = 0;
                LOAI k = context.LOAI.FirstOrDefault(m => m.MaLoai == pMa);
                context.LOAI.Remove(k);
                result = context.SaveChanges();
                return result;
            }
            public List<LOAI> GetList()
            {
                List<LOAI> list = new List<LOAI>();
                list = context.LOAI.ToList();
                return list;
            }

            public LOAI GetDVByMa(int pMa)
            {
                LOAI result = new LOAI();
                result = context.LOAI.FirstOrDefault(m => m.MaLoai == pMa);
                return result;
            }
        }
}
