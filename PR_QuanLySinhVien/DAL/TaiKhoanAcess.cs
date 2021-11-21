using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAcess:DatabaseAccess
    {
        public string CheckLogic(TaiKhoan taikhoan)
        {
            string info = CheckLogicDTO(taikhoan);
            return info;
        }
    }
}
