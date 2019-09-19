using StudentAttendanceManagementApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAttendanceManagementApi.Models;

namespace StudentAttendanceManagementApi.Services
{
    public class TeacherService : ITeacherService
    {
        public void ChangePassword(int userID, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void Login(int userID, string password)
        {
            throw new NotImplementedException();
        }

        public void MarkAttendance(int studentId, int classId, char section, int period, bool HasAttended, DateTime dateTime, int subjectId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAttendance(int studentId, DateTime dateTime, int period)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEnumerable<Attendance>> ViewAttendance(int studentId, int month, int subjectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEnumerable<IEnumerable<Attendance>>> ViewAttendance(int classId, char section, int month, int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
