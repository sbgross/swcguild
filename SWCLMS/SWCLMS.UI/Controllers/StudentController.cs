using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Data.SQL;
using SWCLMS.Models;
using SWCLMS.UI.Models;

namespace SWCLMS.UI.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        private LmsStudentCourseGradeManager _lmsStudentCourseGradeManager;

        public StudentController(LmsStudentCourseGradeManager lmsStudentCourseGradeManager)
        {
            _lmsStudentCourseGradeManager = lmsStudentCourseGradeManager;

        }

        // GET: Student
        public ActionResult Index()
        {
            DataResponse<List<StudentCourse>> model = _lmsStudentCourseGradeManager.GetStudentCourses(1);
            
            return View(model);
        }
     
        [HttpPost]
        public ActionResult ViewGrades()
        {
            return View();
        }
    }
}