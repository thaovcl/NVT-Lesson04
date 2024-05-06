using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVT.lsonline.Controllers
{
    public class NVTStudentController : Controller
    {
        // GET: NVTStudent
        public ActionResult Index()
        {
            //Truyền dữ liệu từ controller -> view
            ViewBag.fullName = "Nguyễn Văn Thạo";
            ViewData["Birthday"] = "17/05/2004";
            TempData["Phone"] = "0382658414";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Details = "";
            string nvtstr = "";
            nvtstr += "<h3>Họ và tên: Nguyễn Văn Thạo</h3>";
            nvtstr += "<p>Mã số: 2210900125</p>";
            nvtstr += "<p>Địa chỉ mail: nguyenvanthao1705@gmail.com</p>";

            ViewBag.Details = nvtstr;
            return View("chi tiết ");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Bùi Văn C", };

            return View();
        }
        //HTMLhelper
        //Get: NVT
        public ActionResult Addnewstudent()
        {
            return View ();
        }
        [HttpPost]
        public ActionResult Addnewstudent(FormCollection form)
        {
            //lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string taikhoan = form["Taikhoan"];
            string matkhau = form["Matkhau"];

            string nvtStr = "<h3>" + fullname + "</h3>";
            nvtStr += "<p>" + masv;
            nvtStr += "<p>" + taikhoan;
            nvtStr += "<p>" + matkhau;

            ViewBag.info = nvtStr;
            return View("Ketqua");
        }
    }
}