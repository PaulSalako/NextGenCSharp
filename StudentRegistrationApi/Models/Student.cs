using System;

namespace StudentRegistrationApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int Age { get; set; }
        public string? Course { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}