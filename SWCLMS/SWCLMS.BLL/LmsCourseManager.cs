using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCLMS.Models;
using SWCLMS.Models.Interfaces;
using SWCLMS.Models.Tables;

namespace SWCLMS.BLL
{
    public class LmsCourseManager
    {
        private ILmsCourseRepository _lmsCourseRepository;

        public LmsCourseManager(ILmsCourseRepository lmsCourseRepository)
        {
            _lmsCourseRepository = lmsCourseRepository;
        }

        public DataResponse<List<TeacherCourses>> GetTeacherCourses(int userID)
        {
            var response = new DataResponse<List<TeacherCourses>>();

            try
            {
                response.Data = _lmsCourseRepository.GetTeacherCourses(userID);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}