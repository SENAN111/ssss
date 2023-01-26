using lumia.DAL;
using lumia.Models;
using lumia.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace lumia.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PositionController : Controller
    {
        readonly AppDbContext _context;
        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Position position)
        {
            if(ModelState.IsValid)
            {
                return View(position);
            }
            _context.Positions.Add(position);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Position exsit = _context.Positions.FirstOrDefault(p => p.Id == id);
            if (exsit is null)
            {
                return NotFound();
            }
            _context.Positions.Remove(exsit);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Uptade(int? id) 
        {
            if (id == null || id == 0)
            {
                return BadRequest();
            }
            Position exist= _context.Positions.FirstOrDefault(p=>p.Id == id);
            if(exist is null)
            {
                return NotFound();
            }
            return View(exist);

        }
        [HttpPost]
        public IActionResult Uptade(int? id, Position position)
        {
            if (id == null || id == 0)
            {
                return BadRequest();
            }
            if(ModelState.IsValid)
            {
                return (View());

            }
            Position exist = _context.Positions.FirstOrDefault(p => p.Id == id);
            if(exist== null)
            {
                return NotFound();
            }
            exist.Name= position.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
