using StudentAttendanceManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Contracts
{
    public interface ISubjectService
    {
        void AddSubject(string subjectName);
        void RemoveSubject(int subjectId);
        Subject GetSubjectById(int subjectId);
        IEnumerable<Subject> GetSubjects();
    }
}
