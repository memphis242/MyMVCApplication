using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            // update student to the database

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

        [NonAction]
        public Student GetStudent(int id)
        {
            return studentList.Where(s => s.StudentID == id).FirstOrDefault();
        }
    }
}