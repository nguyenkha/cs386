using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityDbContext _context;
        public StudentController(UniversityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.FromSql("SELECT * FROM Students").ToList();
            return View(students);
        }
    }
}