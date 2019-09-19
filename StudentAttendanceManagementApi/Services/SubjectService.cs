using Microsoft.EntityFrameworkCore;
using StudentAttendanceManagementApi.Contracts;
using StudentAttendanceManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Services
{
    public class SubjectService : ISubjectService
    {
        private DatabaseContext _context = DatabaseContext.GetInstance();

        public void AddSubject(string subjectName)
        {
            _context.Subjects.Add(new Subject() { SubjectName = subjectName });
            _context.SaveChanges();
        }

        public Subject GetSubjectById(int subjectId)
        {
            return _context.Subjects.Find(subjectId);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        public void RemoveSubject(int subjectId)
        {
            _context.Subjects.Remove(_context.Subjects.Find(subjectId));
            _context.SaveChanges();
        }
    }
}
