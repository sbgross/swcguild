﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Tables;

namespace SWCLMS.Models.Interfaces
{
    public interface ILmsUserRepository
    {
        List<LmsUser> GetUnassignedUsers();
        LmsUser GetUnassignedUserDetails(int UserID);
    }
}