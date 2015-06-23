using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;
using System.Transactions;

namespace SWCLMS.BLL
{
    public class LMSRoleManager
    {
        private ILMSRoleRepository _lmsRoleRepository;

        public LMSRoleManager(ILMSRoleRepository lmsRoleRepository)
        {
            _lmsRoleRepository = lmsRoleRepository;
        }

        public void Update(UserRole request)
        {
            using (var transactionScope = new TransactionScope())
            {
                _lmsRoleRepository.RemoveRoles(request.ID);
                _lmsRoleRepository.Update(request);

                foreach (var role in request.RoleNames)
                {
                    _lmsRoleRepository.AddRole(request.ID, role);
                }

                transactionScope.Complete();
            }
        }
    }
}
