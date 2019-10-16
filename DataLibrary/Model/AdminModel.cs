using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class AdminModel
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("User Name")]
        public string user { get; set; }

        [DisplayName("PassWord")]
        public string password { get; set; }
    }
}
