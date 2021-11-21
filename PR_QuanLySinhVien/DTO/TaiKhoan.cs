using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string sMaTK { get; set; }
        public string sTaiKhoan { get; set; }
        public string sMatKhau { get; set; }
        public int FK_iMaQuyen { get; set; }
    }
}
