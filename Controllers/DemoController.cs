using Microsoft.AspNetCore.Mvc;
using LeThuTrangBTH.Models.Process;
namespace LeThuTrangBTH.Controllers

{
    public class DemoController : Controller
    {
        //khai báo class theo tên của đối tựng
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        //tạo các action
        public IActionResult Index()
        {
            return View();
        }
        //action để nhận dữ liệu từ view gửi lên
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB)
        {
            //ép kiểu dữ liệu của tham số
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string mess = gpt.GiaiPhuongTrinhBacNhat(a, b);
            ViewBag.abc = mess;
            return View();
        }
        [HttpPost]

        public IActionResult Create(string heSoA, string heSoB, string heSoC)
        {
            // ep kieu du lieu cua tham so
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            double c = Convert.ToDouble(heSoC);
            string mess = gpt.GiaiPhuongTrinhBacHai(a, b, c);
            ViewBag.mess = mess;
            return View();
        }
    }
}
