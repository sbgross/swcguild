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
    public class SqlLMSRoleRepository : ILMSRoleRepository
    {
        public List<Role> RoleGetAll()
        {
            List<Role> roles = new List<Role>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("RoleGetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var role = new Role();                       
                        role.RoleID = dr["ID"].ToString();
                        role.RoleName= dr["Name"].ToString();

                        roles.Add(role);
                    }
                }
            }
            return roles;
        }

        public List<UserRole> UserGetAllRoles(int UserID)
        {
            List<UserRole> users = new List<UserRole>();

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
                        var user = new UserRole();
                        user.UserID = (int)dr["UserID"];
                        user.ID = dr["ID"].ToString();
                        user.FirstName = dr["FirstName"].ToString();
                        user.LastName = dr["LastName"].ToString();
                        user.UserId = dr["LastName"].ToString();
                        user.RoleID = dr["RoleId"].ToString();
                        user.RoleName = dr["Name"].ToString();

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public void RemoveRoles(string aspNetUserId)
        {
            List<UserRole> users = new List<UserRole>();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("AspNetUserDeleteRoles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", aspNetUserId);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var user = new UserRole();                       
                        user.RoleID = dr["UserId"].ToString();
                        user.RoleName = dr["RoleId"].ToString();

                        users.Add(user);
                    }
                }
            }
        }

        public void AddRole(string aspNetUserId, string roleName)
        {
            UserRole user = new UserRole();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("AspNetUserAddRole", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", aspNetUserId);
                cmd.Parameters.AddWithValue("@Name", roleName);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
