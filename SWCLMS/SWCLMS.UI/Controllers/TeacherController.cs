using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Data.SQL;
using SWCLMS.Models;
using SWCLMS.Models.Tables;
using SWCLMS.UI.Models;
using SWCLMS.UI.Utilities;

namespace SWCLMS.UI.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherController : Controller
    {
        private LmsCourseManager _lmsCourse;
        private LMSRosterManager _lmsRosterManager;
        private LMSGradeLevelManager _lmsGradeLevelManager;

        public TeacherController(LmsCourseManager lmscourse, LMSRosterManager lmsRosterManager, LMSGradeLevelManager lmsGradeLevelManager)
        {
            _lmsCourse = lmscourse;
            _lmsRosterManager = lmsRosterManager;
            _lmsGradeLevelManager = lmsGradeLevelManager;
        }

        // GET: Teacher
        public ActionResult Index()
        {
            var currentUser = IdentityHelper.GetLmsUserForCurrentUser(this);
            var model = _lmsCourse.GetTeacherCourses(currentUser.UserID);
            return View(model);
        }

        public ActionResult Roster()  //TODO Add CourseID as a parameter
        {
            var currentUser = IdentityHelper.GetLmsUserForCurrentUser(this);
            var roster = _lmsRosterManager.GetRosterStudents(currentUser.UserID, 2);

            RosterViewModel model = new RosterViewModel();
            model.CourseRoster = roster.Data;            
            model.CreateGradeLevel(_lmsGradeLevelManager.GradeLevelGetAll());

            return View(model);            
        }

        [HttpPost]
        public ActionResult RosterRemove(int RosterID)
        {
            _lmsRosterManager.RemoveStudent(RosterID);

            return RedirectToAction("Roster", "Teacher");

            //return View("Roster","Teacher");
        }

        public ActionResult Search()
        {
            RosterViewModel model = new RosterViewModel();

            model.CreateGradeLevel(_lmsGradeLevelManager.GradeLevelGetAll());

            return View(model);
        }
        
        [HttpPost]
        public ActionResult Roster(RosterStudent student)
        {
            student.CourseID = 2;
            var studentSearch = _lmsRosterManager.RosterUserSearch(student);
            var currentUser = IdentityHelper.GetLmsUserForCurrentUser(this);
            var roster = _lmsRosterManager.GetRosterStudents(currentUser.UserID, 2);

          
            RosterViewModel model = new RosterViewModel();

            model.CreateGradeLevel(_lmsGradeLevelManager.GradeLevelGetAll());
            model.StudentSearchResults = studentSearch.Data;
            model.CourseRoster = roster.Data; 

            return View(model);
        }

        [HttpPost]
        public ActionResult RosterAdd(RosterStudent student)
        {
            student.CourseID = 2;
            _lmsRosterManager.AddStudent(student);

            var studentSearch = _lmsRosterManager.RosterUserSearch(student);
            var currentUser = IdentityHelper.GetLmsUserForCurrentUser(this);
            var roster = _lmsRosterManager.GetRosterStudents(currentUser.UserID, 2);


            RosterViewModel model = new RosterViewModel();

            model.CreateGradeLevel(_lmsGradeLevelManager.GradeLevelGetAll());
            model.StudentSearchResults = studentSearch.Data;
            model.CourseRoster = roster.Data; 

            return RedirectToAction("Roster", "Teacher");
        }
    }
}