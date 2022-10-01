using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyNhanVien.Models
{
    public class Staffs
    {
        public int ID_Staff { set; get; }
        [Required(ErrorMessage ="Mời nhập họ và tên nhân viên")]
        [Display (Name ="Họ và tên")]
        public string FullName { set; get; }
        [Required(ErrorMessage = "Mời nhập email")]
        [Display(Name = "Email")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Mời nhập địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string Address { set; get; }
        [Required(ErrorMessage = "Mời số điện thoại")]
        [Display(Name = "SĐT")]
        public string Phone { set; get; }
    }
}