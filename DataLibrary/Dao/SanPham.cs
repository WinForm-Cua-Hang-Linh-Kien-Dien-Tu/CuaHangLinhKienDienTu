using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.EF;

namespace DataLibrary.Dao
{
    public class SanPham
    {
        ModelCuaHang db = new ModelCuaHang();

        public List<SANPHAM> loadSanPham()
        {  
            return db.SANPHAM.ToList();
        }
    }
}
