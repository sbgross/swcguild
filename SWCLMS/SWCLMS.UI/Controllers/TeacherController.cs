using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Models;
using SWCLMS.UI.Models;
using SWCLMS.UI.Utilities;

namespace SWCLMS.UI.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        private LmsCourseManager _lmsCourse;

        public TeacherController(LmsCourseManager lmscourse)
        {
            _lmsCourse = lmscourse;
        }

        // GET: Teacher
        public ActionResult Index()
        {
            var currentUser = IdentityHelper.GetLmsUserForCurrentUser(this);
            var model = _lmsCourse.GetTeacherCourses(currentUser.UserID);
            return View(model);
        }
    }
}