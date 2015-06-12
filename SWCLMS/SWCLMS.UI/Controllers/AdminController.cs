using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;

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

        public ActionResult GetUserDetails(int ID)
        {
            var model = _lmsUserManager.GetUnassignedUserDetails(ID);

            return View(model);
        }
    }
}