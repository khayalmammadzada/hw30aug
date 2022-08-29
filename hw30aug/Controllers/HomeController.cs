using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hw30aug.Models;

namespace hw30aug.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            Student std1 = new Student {Name="Xeyal", Surname="Memmedzade", Age=25 };
            Student std2 = new Student { Name = "Hesen", Surname = "Hesenov", Age = 22 };
            Student std3 = new Student { Name = "Eli", Surname = "Veliyev", Age = 20 };
            List<Student> students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);

            return View(students);
        }

    }
}
