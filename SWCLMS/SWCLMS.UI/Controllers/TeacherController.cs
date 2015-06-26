//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using SWCLMS.BLL;
//using SWCLMS.Models;
//using SWCLMS.UI.Models;

//namespace SWCLMS.UI.Controllers
//{
//    [Authorize(Roles = "Teacher")]
//    public class TeacherController : Controller
//    {
//        private LmsCourseManager _lmsCourse;

//        // GET: Teacher
//        public ActionResult Index(int UserID)
//        {
//            var model = _lmsCourse.GetTeacherCourses(UserID);
//            return View(model);
//        }


        //     public class AdminController : Controller
        //{
        //    private LmsUserManager _lmsUserManager;
        //    private LMSRoleManager _lmsRoleManager;


        //    public AdminController(LmsUserManager lmsUserManager, LMSRoleManager lmsRoleManager)
        //    {
        //        _lmsUserManager = lmsUserManager;
        //        _lmsRoleManager = lmsRoleManager;
        //    }       

        //    public ActionResult Index()
        //    {
        //        var model = _lmsUserManager.GetUnassignedUsers();

        //        return View(model);
        //    }
        //}
//    }
//}