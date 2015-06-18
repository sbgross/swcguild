using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWCLMS.Models.Tables;
using System.Web.Mvc;

namespace SWCLMS.UI.Models
{
    public class UserDetailsToEditVM
    {
        public LmsUser UserDetailsToEdit { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string SuggestedRole { get; set; }
        public int UserID { get; set; }
        public Role RoleFields { get; set; }  //**new 6/17**

        public List<SelectListItem> GradeLevels { get; set; }
        public List<SelectListItem> Roles { get; set; }

        public void CreateGradeLevel(List<GradeLevel> gradeLevels)
        {
            GradeLevels = new List<SelectListItem>();

            foreach (var g in gradeLevels)
            {
                GradeLevels.Add(
                    new SelectListItem() { Text = g.GradeLevelName, Value = g.GradeLevelID.ToString() }
                    );
            }
        }

        public void CreateRole(List<Role> roles)
        {
            Roles = new List<SelectListItem>();

            foreach (var r in roles)
            {
                Roles.Add(
                    new SelectListItem() { Text = r.RoleName, Value = r.RoleID}
                    );
            }
        }
    }
}