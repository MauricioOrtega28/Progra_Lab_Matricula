using Microsoft.AspNetCore.Mvc;
using Progra_Lab_Matricula.Models;
using Progra_Lab_Matricula.Data;


namespace Progra_Lab_Matricula.Controllers
{
    public class AlumnoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public AlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Alumno objAlumno)
        {
            _context.Add(objAlumno);
            _context.SaveChanges();
            ViewData["Message"] = "El alumno ya esta registrado"; 
            return View("Index");
        }
    }
}