using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;

namespace SWCLMS.Data.Mocks
{
    public class MockLmsRoleRepository : ILmsRoleRepository
    {
        public List<Role> RoleGetAll()
        {
            List<Role> role = new List<Role>();

            return role;
        }

        public List<LMSUserUpdateRequest> UserGetAllRoles(int UserID)
        {
            List<LMSUserUpdateRequest> role = new List<LMSUserUpdateRequest>();

            return role;
        }

        public void RemoveRoles(string aspNetUserId)
        {
            
        }

        public void AddRole(string aspNetUserId, string roleName)
        {
            
        }
    }
}
