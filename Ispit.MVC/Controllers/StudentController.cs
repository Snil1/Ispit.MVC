using Ispit.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ispit.MVC.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> studenti = new List<Student>()
        {
            new Student(){Id = 1, Name = "Ana Anić", Age = 32, Bio = "FSB" },
            new Student(){Id = 2, Name = "Ivo Ivić", Age = 35, Bio = "FER"},
            new Student(){Id = 3, Name = "Mate Matić", Age = 20, Bio = "Filozofski fakultet"},
            new Student(){Id = 4, Name = "Iva Ivić", Age = 22, Bio = "Ekonomski fakultet"},
            new Student(){Id = 5, Name = "Ante Antić", Age = 25, Bio = "FESB"}
        };


        public IActionResult Index()
        {


            return View(studenti);
        }

        public IActionResult Details(int id)
        {
            Student student = studenti.FirstOrDefault(s=>s.Id == id);
            return View(student);
        }
    } 
}
