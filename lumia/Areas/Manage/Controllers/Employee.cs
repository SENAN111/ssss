using lumia.DAL;
using lumia.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace lumia.Areas.Manage.Controllers
{
    public class Employee : Controller
    {
        readonly AppDbContext _context;
        public Employee()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create(CreateEmployeeVm) 
        //{
        //    if(ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //}

    }
}
