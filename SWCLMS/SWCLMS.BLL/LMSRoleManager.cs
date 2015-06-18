using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;

namespace SWCLMS.BLL
{
    public class LMSRoleManager
    {
        private ILMSRoleRepository _lmsRoleRepository;

        public LMSRoleManager(ILMSRoleRepository lmsRoleRepository)
        {
            _lmsRoleRepository = lmsRoleRepository;
        }
    }
}
