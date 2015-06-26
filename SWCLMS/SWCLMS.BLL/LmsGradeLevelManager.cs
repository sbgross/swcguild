using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;

namespace SWCLMS.BLL
{
    public class LMSGradeLevelManager  //aded 6/16 after Nikki left
    {
        private ILMSGradeLevelRepository _lmsGradeLevelRepository;

        public LMSGradeLevelManager(ILMSGradeLevelRepository lmsGradeLevelRepository)
        {
            _lmsGradeLevelRepository = lmsGradeLevelRepository;
        }
    }
}
