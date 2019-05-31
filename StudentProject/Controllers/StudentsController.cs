using StudentProject.DataAccess;
using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProject.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Student
        private readonly FakeDbRepo _context;
        public StudentsController()
        {
            _context = new FakeDbRepo();
        }

        public ActionResult Index()
        {
            var model = _context.GetAllStudents().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(List<StudentViewModel> students)
        {
            _context.InsertStudent(students.FirstOrDefault());
            var result = _context.UpdateStudents(students);
            TempData["Message"] = result > 0 ? "Öğrenciler Güncellendi" : "Bir Hata Oluştu";

            return RedirectToAction("Index", "Students");
        }

        public ActionResult Detail(int? id)
        {
            var student = _context.GetStudent(id);

            if (student != null)
                return View(student);

            TempData["Message"] = "Öğrenci Bulunamadı";
            return RedirectToAction("Index", "Students");
        }
    }
}