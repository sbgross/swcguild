using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models;
using SWCLMS.Models.Tables;

namespace SWCLMS.Data.SQL
{
    public class SqlLMSCourseRepository : ILmsCourseRepository
    {
        public List<TeacherCourses> GetTeacherCourses(int userID)
        {
            List<TeacherCourses> courses = new List<TeacherCourses>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand("UserTeacherDashboard", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", userID);

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var course = new TeacherCourses();
                        course.CourseID = (int)dr["CourseID"];
                        course.CourseName = dr["CourseName"].ToString();
                        course.IsArchived = (bool)dr["IsArchived"];

                        courses.Add(course);
                    }
                }
            }
            return courses;
        }
    }
}
