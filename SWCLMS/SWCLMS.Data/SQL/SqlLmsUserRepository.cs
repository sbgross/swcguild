using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;

namespace SWCLMS.Data.SQL
{
    public class SqlLmsUserRepository : ILmsUserRepository
    {
        public List<LmsUser> GetUnassignedUsers()
        {
            List<LmsUser> users = new List<LmsUser>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("AdministratorDashboardSlide2", cn);  //Name of Eric's sproc--AdministratorDashboard
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var user = new LmsUser();
                        user.UserID = (int)dr["UserID"];
                        //user.Id = dr["ID"].ToString();
                        user.FirstName = dr["FirstName"].ToString();
                        user.LastName = dr["LastName"].ToString();
                        user.Email = dr["Email"].ToString();
                        user.SuggestedRole = dr["SuggestedRole"].ToString();

                        if (dr["GradeLevelID"] != DBNull.Value)
                            user.GradeLevelID = (byte) dr["GradeLevelID"];

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public LmsUser GetUnassignedUserDetails(int UserID)
        {           
            LmsUser user = new LmsUser();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("UserViewDetails", cn);  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", UserID);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {                        
                        user.UserID = (int)dr["UserID"];
                        //user.Id = dr["ID"].ToString();
                        user.FirstName = dr["FirstName"].ToString();
                        user.LastName = dr["LastName"].ToString();
                        user.Email = dr["Email"].ToString();
                        user.SuggestedRole = dr["SuggestedRole"].ToString();

                        if (dr["GradeLevelID"] != DBNull.Value)
                            user.GradeLevelID = (byte)dr["GradeLevelID"];                       
                    }
                }
            }
            return user;
        }
    }
}
