using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.Models.DTO
{
    public class Student
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int ProgramId { get; set; }

        public string StudentType { get; set; }

        public string s { get; set; }

        public string CurrentProgramEnrolled { get; set; }

        public string EnrollmentType { get; set; }

        public DateTime EnrollmentYear { get; set; }

        public DateTime DOB { get; set; }
    }
}
