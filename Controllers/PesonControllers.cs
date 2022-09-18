using Microsoft.AspNetCore.Mvc;
using LeThuTrangBTH.Models;

namespace LeThuTrangBTH.Controllers
{
    public class PersonController: Controller
{
    
    public IActionResult Index(Person std)
    {
        ViewBag.Ps = std.PersonID + "-"+ std.PersonName + "-"+ std.PersonBir + "-" + std.Address; 
       return View();
    }
  public class EmployeeController : Controller
    {
        // Viết các phương thức
        public IActionResult List()
{
    
    // khoi tao list Student
     List<Person> listPerson = new List<Person>()
     {
         new Person {PersonID = 1, PersonName = "Nguyen Van A", PersonBir="03/09/2001", Address = "Hà Nội"},
         new Person {PersonID = 2, PersonName = "Nguyen Van B", PersonBir="30/04/2001", Address = "Sài Gòn"},
         new Person {PersonID = 3, PersonName = "Nguyen Van C", PersonBir="08/01/2001", Address= "Tuyên Quang"}
         
     };
     ViewData["Persons"] = listPerson;
    return View(listPerson);
}
[HttpPost]
 public IActionResult Create(Person std)
        {
            string mess = std.PersonID + "-";
            mess += std.PersonName + "-";
            mess += std.PersonBir + "-";
            mess += std.Address;
            ViewBag.EMPL = mess;
            return View();
        }
    }
}

}