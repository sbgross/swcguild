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
    }
}
