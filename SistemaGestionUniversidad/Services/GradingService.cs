using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionUniversidad.Interfaces;
using SistemaGestionUniversidad.Models;

namespace SistemaGestionUniversidad.Services
{
    public class GradingService : IGradingService
    {
        public void AddGrade(Student student, double grade)
        {
            if (grade < 0 || grade > 10)
            {
                Console.WriteLine($"[ERROR] Invalid grade: {grade}. Must be between 0 and 10.");
                return;
            }

            student.Grades.Add(grade);
            Console.WriteLine($"[INFO] Grade {grade} added to {student.FullName}.");
        }
        public double CalculateGPA(Student student)
        {
            if (student.Grades.Count == 0)
                return 0.0;
            return student.Grades.Average();
        }
        public bool IsApproved(Student student)
        {
            double gpa = CalculateGPA(student);
            return gpa >= 4.0; // Assuming 4 is the passing grade
        }
    }
}
