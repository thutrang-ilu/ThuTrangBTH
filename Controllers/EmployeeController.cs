using Microsoft.AspNetCore.Mvc;
using LeThuTrangBTH.Models;

namespace LeThuTrangBTH.Controllers
{
    public class EmployeeController : Controller
    {
        // Viết các phương thức
    
        [HttpPost]
        public IActionResult Index( Employee std)
        {
            ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAddress;
       
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
    
}