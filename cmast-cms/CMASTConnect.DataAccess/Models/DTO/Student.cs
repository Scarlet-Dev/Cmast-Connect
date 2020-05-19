using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMASTConnect.DataAccess.Models.DTO
{
    public class Student
    {
        [Required, Key]
        public string Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, ForeignKey("")]
        public int ProgramId { get; set; }

        [DataType(DataType.Date)]
        public string StudentType { get; set; }

        [DataType(DataType.Text)]
        public string s { get; set; }

        [DataType(DataType.Text)]
        public string CurrentProgramEnrolled { get; set; }

        [DataType(DataType.Text)]
        public string EnrollmentType { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentYear { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
