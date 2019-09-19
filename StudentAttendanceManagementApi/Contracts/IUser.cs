using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IUser
    {
        void Login(int userID, string password);
        void ChangePassword(int userID, string oldPassword, string newPassword);
    }
}
