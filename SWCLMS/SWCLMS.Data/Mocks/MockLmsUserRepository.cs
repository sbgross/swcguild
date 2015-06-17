using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;

namespace SWCLMS.Data.Mocks
{
    public class MockLmsUserRepository : ILmsUserRepository
    {
        public List<LmsUser> GetUnassignedUsers()
        {
            return new List<LmsUser>()
            {
                new LmsUser()
                {
                    Email = "eric@swcguild.com",
                    FirstName = "Eric",
                    LastName = "Wise",
                    SuggestedRole = "Admin",
                    GradeLevelID = null,
                    Id = "1",
                    UserID = 1
                },
                new LmsUser()
                {
                    Email = "alincoln@swcguild.com",
                    FirstName = "Abraham",
                    LastName = "Lincoln",
                    SuggestedRole = "Teacher",
                    GradeLevelID = null,
                    Id = "2",
                    UserID = 2
                },
                new LmsUser()
                {
                    Email = "joe.schmoe@swcguild.com",
                    FirstName = "Joe",
                    LastName = "Schmoe",
                    SuggestedRole = "Student",
                    GradeLevelID = null,
                    Id = "3",
                    UserID = 3
                },
                new LmsUser()
                {
                    Email = "jane.schmoe@swcguild.com",
                    FirstName = "Jane",
                    LastName = "Schmoe",
                    SuggestedRole = "Parent",
                    GradeLevelID = null,
                    Id = "4",
                    UserID = 4
                }
            };
        }

        public LmsUser GetUnassignedUserDetails(int UserID)
        {
            LmsUser user = new LmsUser();
          
            return user;
        }

        public LmsUser UpdateUserDetails(LmsUser user)
        {
          LmsUser user1 = new LmsUser();

            return user1;
        }
    }
}
