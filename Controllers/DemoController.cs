using Microsoft.AspNetCore.Mvc;
using LeThuTrangBTH.Models.Process;
using MvcMovie.Models.Process;

namespace LeThuTrangBTH.Controllers

{
    public class DemoController : Controller
    {
        //khai báo class theo tên của đối tựng
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        StringProcess strPro = new StringProcess();
        StringProcess1 src = new StringProcess1();
        StringProcess2 std = new StringProcess2();
         StringProcess3 abc = new StringProcess3();
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
        }public IActionResult Xulychuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Remove(string strInput)
        {
            ViewBag.mess = strPro.Remove(strInput);
            return View();
        }

        public IActionResult Viethoa()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Viethoa(string strInput)
        {
            ViewBag.mess = src.LowerToUpper(strInput);
            return View(); 
        }
        public IActionResult Vietthuong()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Vietthuong(string strInput)
        {
            ViewBag.mess = std.UpperToLower(strInput);
            return View(); 
        }

        public IActionResult Viethoakytudau()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Viethoakytudau(string strInput)
        {
            ViewBag.mess = abc.CapitalizeOneFirstCharacter(strInput);
            return View(); 
        }
    }
   
    
}
