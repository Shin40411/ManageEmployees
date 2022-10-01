using QuanLyNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanVien.Controllers
{
    public class StaffsController : Controller
    {
        // GET: Staffs
        StaffsMangementEntities1 db = new StaffsMangementEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStaffList()
        {
            List<Staffs> obj = db.Staffs.Select(x => new Staffs
            {
                ID_Staff = x.ID_Staff,
                FullName = x.FullName,
                Email = x.Email,
                Address = x.Address,
                Phone = x.Phone
            }).ToList();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CreateStaffs(Staffs sta)
        {
            var result = false;
            try
            {
                if (sta.ID_Staff > 0)
                {
                    Staff Sta = db.Staffs.SingleOrDefault(x => x.ID_Staff == sta.ID_Staff);
                    Sta.FullName = sta.FullName;
                    Sta.Email = sta.Email;
                    Sta.Address = sta.Address;
                    Sta.Phone = sta.Phone;
                    result = true;
                    db.SaveChanges();
                }
                else
                {
                    Staff Sta = new Staff();
                    Sta.FullName = sta.FullName;
                    Sta.Email = sta.Email;
                    Sta.Address = sta.Address;
                    Sta.Phone = sta.Phone;
                    db.Staffs.Add(Sta);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteStaffRecord(int StaffId)
        {
            bool result = false;
            Staff Sta = db.Staffs.SingleOrDefault(x => x.ID_Staff == StaffId);
            if (Sta != null)
            {
                db.Staffs.Remove(Sta);
                db.SaveChanges();
                result = true;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}