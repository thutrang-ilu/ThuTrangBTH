using LeThuTrangBTH.Models.Process;
using Microsoft.AspNetCore.Mvc;

namespace LeThuTrangBTH.Controllers
{
    public class DemoController : Controller    
    {
        //khai bao class theo huong doi tuong
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
      
      public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du lieu gui len
      [HttpPost]
      public IActionResult Index(string heSoA, string heSoB)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        string thongBao = gpt.GiaiPhuongTrinhBacNhat(a, b);
        ViewBag.mess= "Kết quả: " + thongBao ; 
        return View();
      }
      [HttpPost]
      public IActionResult Creat(string heSoA, string heSoB, string heSoC)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        double c = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(a, b, c);
        ViewBag.mess= "Kết quả" + thongBao ; 
        return View();
      }
    }
}   