using StudentAttendanceManagementApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAttendanceManagementApi.Models;

namespace StudentAttendanceManagementApi.Services
{
    public class AdminService : IAdminService
    {
        private DatabaseContext _context = DatabaseContext.GetInstance();
        public void AddStudent(int studentId, int Class, char section, string studentName)
        {
            var newStudent = new Student();
            newStudent.StudentId = studentId;
            newStudent.Class = Class;
            newStudent.Section = section;
            newStudent.Name = studentName;
            _context.Students.Add(newStudent);
            _context.SaveChanges();
        }

        public void AddTeacher(string name)
        {
            var newTeacher = new Teacher();
            newTeacher.Name = name;
            _context.Teachers.Add(newTeacher);
            _context.SaveChanges();
        }

        public void ChangePassword(int userID, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void Login(int userID, string password)
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
