using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studentList = new List<Student>
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18},
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21},
                new Student() { StudentID = 3, StudentName = "Bill", Age = 25},
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20},
                new Student() { StudentID = 5, StudentName = "Ron", Age = 21},
                new Student() { StudentID = 6, StudentName = "Chris", Age = 17},
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19}
            };

        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var student = studentList.Where(s => s.StudentID == id).FirstOrDefault();

            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //Find index of student in list
            int index = studentList.IndexOf(studentList.Find(std => std.StudentID == student.StudentID));

            //Edit values
            studentList.ElementAt(index).StudentID = student.StudentID;
            studentList.ElementAt(index).StudentName = student.StudentName;
            studentList.ElementAt(index).Age = student.Age;

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from database whose ID matches specified id

            return RedirectToAction("Index");
        }

        [ActionName("find")]
        public ActionResult GetByID(int id)
        {
            //get student from database

            return View();
        }

        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }

        /*
        [NonAction]
        public Student GetStudent(int id)
        {
            return studentList.Where(s => s.StudentID == id).FirstOrDefault();
        }
        */
    }
}