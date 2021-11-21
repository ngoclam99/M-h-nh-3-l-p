using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAcess tkAccess = new TaiKhoanAcess();
        public string CheckLogic(TaiKhoan taikhoan)
        {
            // Kiểm tra nghiệp vụ
            if (taikhoan.sTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }

            if (taikhoan.sMatKhau == "")
            {
                return "requeid_password";
            }

            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }
    }
}
