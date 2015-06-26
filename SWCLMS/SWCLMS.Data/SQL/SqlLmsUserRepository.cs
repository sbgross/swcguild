﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models;
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
                var cmd = new SqlCommand("LMSUserSelectUnassigned", cn);  //Name of Eric's sproc--AdministratorDashboard
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
                        user.ID = dr["ID"].ToString();
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

        public LmsUser UpdateUserDetails(LMSUserUpdateRequest user)
        {
            LmsUser user1 = new LmsUser();
            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("UserUpdateDetails", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@GradeLevelID", user.GradeLevelID);                  

                cn.Open();
                cmd.ExecuteNonQuery();               
            }

            return user1;
        }

        public List<LmsUser> UserSearch(AdminUserSearch searchName)
        {
            List<LmsUser> users = new List<LmsUser>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("UserSearch", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (!string.IsNullOrEmpty(searchName.FirstName))
                    cmd.Parameters.Add(new SqlParameter("@FirstNamePartial", searchName.FirstName));

                if (!string.IsNullOrEmpty(searchName.LastName))
                    cmd.Parameters.Add(new SqlParameter("@LastNamePartial", searchName.LastName));

                if (!string.IsNullOrEmpty(searchName.Email))
                    cmd.Parameters.Add(new SqlParameter("@EmailPartial", searchName.Email));

                if (!string.IsNullOrEmpty(searchName.SelectedRoleID))
                    cmd.Parameters.Add(new SqlParameter("@RoleID", searchName.SelectedRoleID));

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var user = new LmsUser();
                        user.UserID = (int)dr["UserID"];
                        user.FirstName = dr["FirstName"].ToString();
                        user.LastName = dr["LastName"].ToString();
                        user.Email = dr["Email"].ToString();

                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}
