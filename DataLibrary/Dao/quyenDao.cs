using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Dao
{
    public class quyenDao : DBContext
    {
        public int Add(QUYEN p)
        {
            int result = 0;
            context.QUYEN.Add(p);
            result = context.SaveChanges();
            return result;
        }

        public int Update(QUYEN pma, int ma)
        {
            int result = 0;
            QUYEN k = context.QUYEN.FirstOrDefault(m => m.MaNV == ma);
            if (k != null)
            {
                k.Quyen1 = pma.Quyen1;
            }
            result = context.SaveChanges();
            return result;
        }

        public int UpdateHoanChinh(QUYEN pma, int ma)
        {
            int result = 0;
            QUYEN k = context.QUYEN.FirstOrDefault(m => m.MaNV == ma);
            if (k != null)
            {
                k.User = pma.User;
                k.PassWord = pma.PassWord;
            }
            result = context.SaveChanges();
            return result;
        }

        public int Delete(int pMa)
        {
            int result = 0;
            QUYEN k = context.QUYEN.FirstOrDefault(m => m.MaNV == pMa);
            context.QUYEN.Remove(k);
            result = context.SaveChanges();
            return result;
        }
        public List<QUYEN> GetList()
        {
            List<QUYEN> list = new List<QUYEN>();
            list = context.QUYEN.ToList();
            return list;
        }

        public List<string> GetTenQuyen()
        {
            var list = from a in context.QUYEN select a.Quyen1;
            return list.ToList();

        }

        public List<QUYEN> GetList(string pTenQuyen)
        {
            List<QUYEN> list = new List<QUYEN>();
            list = context.QUYEN.Where(t=>t.Quyen1 == pTenQuyen).ToList();
            return list;
        }

        public List<QUYEN> GetList(int pMA)
        {
            List<QUYEN> list = new List<QUYEN>();
            list = context.QUYEN.Where(t => t.MaNV == pMA).ToList();
            return list;
        }

        public QUYEN GetDVByMa(string userName, string pass)
        {
            QUYEN result = new QUYEN();
            result = context.QUYEN.FirstOrDefault(m => m.User == userName && m.PassWord == pass);
            return result;
        }

        public QUYEN GetQuyenByMaNV(int pMa)
        {
            QUYEN result = new QUYEN();
            result = context.QUYEN.FirstOrDefault(m => m.MaNV == pMa);
            return result;
        }

        public QUYEN GetDVByMa(string userName)
        {
            QUYEN result = new QUYEN();
            result = context.QUYEN.FirstOrDefault(m => m.User == userName);
            return result;
        }
    }
}
