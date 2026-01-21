using System;
using System.Collections.Generic;

namespace SistemaGestionUniversidad.Models
{
    public class Student(
        int id,
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        string email,
        string phoneNumber,
        string address,
        string studentId)
    {
        public int Id { get; set; } = id;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; } = dateOfBirth;
        public string Email { get; set; } = email;
        public string PhoneNumber { get; set; } = phoneNumber;
        public string Address { get; set; } = address;
        public string StudentId { get; set; } = studentId;
        public List<double> Grades { get; set; } = [];
    }
}
