using System.Collections.Generic;
using System.Web.Mvc;
using SWCLMS.BLL;
using SWCLMS.Data.SQL;
using SWCLMS.UI.Models;

namespace SWCLMS.UI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private LmsUserManager _lmsUserManager;
        private LMSGradeLevelManager _gradeLevelManager;

        public AdminController(LmsUserManager lmsUserManager, LMSGradeLevelManager gradeLevelManager)
        {
            _lmsUserManager = lmsUserManager;
            _gradeLevelManager = gradeLevelManager;
        }

        public ActionResult Index()
        {
            var model = _lmsUserManager.GetUnassignedUsers();

            return View(model);
        }

        public ActionResult GetUserDetails(int ID)
        {
            var gradeLevelRepo = new SqlLMSGradeLevelRepository();
            var roleRepo = new SqlLMSRoleRepository();
            var user = _lmsUserManager.GetUnassignedUserDetails(ID);     
       
            UserDetailsToEditVM model = new UserDetailsToEditVM();
            model.UserDetailsToEdit = user.Data;
            model.CreateGradeLevel(gradeLevelRepo.GradeLevelGetAll());
            model.CreateRole(roleRepo.RoleGetAll());
            var userAllRoles = model.CreateUserRoleList(roleRepo.UserGetAllRoles(ID));
            model.PopulateRolesCheckbox(userAllRoles);

            //model.PopulateSelectListItems(gradeLevelRepo.GradeLevelGetAll());
            //model.SelectedRoles = _lmsUserManager.GetRoleNamesFor(ID);

            return View(model);
        }

        [HttpPost]
        public ActionResult GetUserDetails(UserDetailsToEditVM user)
        {
            _lmsUserManager.UpdateUserDetails(user.UserDetailsToEdit);

            foreach (var roleSelection in user.SelectedRoles)
            {
                if (roleSelection.CheckedStatus)
                {
                    //Request.RoleNames.Add(roleSelection.RoleName);
                    _lms
                }
            }

            return RedirectToAction("Index", "Admin");
        }            
        
        public ActionResult Search()
        {
            var roleRepo = new SqlLMSRoleRepository();
            UserDetailsToEditVM model = new UserDetailsToEditVM();
            model.CreateRole(roleRepo.RoleGetAll());

            return View(model);
        }       
    }
}