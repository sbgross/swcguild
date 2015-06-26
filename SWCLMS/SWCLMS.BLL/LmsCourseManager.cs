//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SWCLMS.Models;
//using SWCLMS.Models.Interfaces;
//using SWCLMS.Models.Tables;

//namespace SWCLMS.BLL
//{
//    public class LmsCourseManager
//    {
//        private ILmsCourseRepository _lmsCourseRepository;

//        public LmsCourseManager(ILmsCourseRepository lmsCourseRepository)
//        {
//            _lmsCourseRepository = lmsCourseRepository;
//        }

//        public DataResponse<List<TeacherCourse>> GetTeacherCourses() //removed parameter UserID
//        {
//            var response = new DataResponse<List<TeacherCourse>>();

//            try
//            {
//                response.Data = _lmsCourseRepository.GetTeacherCourses();  //removed parameter UserID
//                response.Success = true;
//            }
//            catch (Exception ex)
//            {
//                response.Message = ex.Message;
//            }

//            return response;
//        }
//    }
//}
