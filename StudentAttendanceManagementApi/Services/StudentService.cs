using StudentAttendanceManagementApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAttendanceManagementApi.Models;

namespace StudentAttendanceManagementApi.Services
{
    public class StudentService : IStudentService
    {
        public bool ApplyLeave(int studentId, int noOfDays)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(int userID, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void Login(int userID, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Attendance> ViewAttendance(int studentId, int month)
        {
            throw new NotImplementedException();
        }
    }
}
