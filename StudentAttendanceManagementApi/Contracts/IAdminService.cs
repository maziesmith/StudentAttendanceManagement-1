using System;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IAdminService : IStaff
    {
        void AddStudent(int studentId, int Class, char section, string name);
        void AddTeacher(string name);
    }
}
