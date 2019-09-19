using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }
        public string Name { get; set; }

    }
}
