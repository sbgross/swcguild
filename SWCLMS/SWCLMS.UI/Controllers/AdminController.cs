using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Data.SQL;
using SWCLMS.Models;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;
using SWCLMS.UI.Models;


namespace SWCLMS.UI.Controllers
{
    public class AdminController : Controller
    {
        private LmsUserManager _lmsUserManager;

        public AdminController(LmsUserManager lmsUserManager)
        {
            _lmsUserManager = lmsUserManager;
        }

        public ActionResult Index()
        {
            var model = _lmsUserManager.GetUnassignedUsers();

            return View(model);
        }

        public ActionResult GetUserDetails(int ID)  //finished on 6/16 3:30pm
        {
            var gradeLevelRepo = new SqlLMSGradeLevelRepository();
            var user = _lmsUserManager.GetUnassignedUserDetails(ID);
            UserDetailsToEditVM model = new UserDetailsToEditVM();
            model.UserDetailsToEdit = user.Data;
            model.CreateGradeLevel(gradeLevelRepo.GradeLevelGetAll());

            return View(model);
        }
        
        [HttpPost]
        public ActionResult GetUserDetails(DataResponse<UserDetailsToEditVM> user) 
        {
            _lmsUserManager.UpdateUserDetails(user.Data.UserDetailsToEdit);

            return RedirectToAction("Index", "Admin");
        }

        //Allows Admins to search for users - both assigned and unassigned. 
        //Created: 06/15/2015 Nikki computer
        public ActionResult Search()
        {
            return View();
        }
    }
}