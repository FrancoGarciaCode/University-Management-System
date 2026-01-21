using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionUniversidad.Models;

namespace SistemaGestionUniversidad.Interfaces
{
    public interface IGradingService
    {
        void AddGrade(Student student, double grade);
        double CalculateGPA(Student student);
        bool IsApproved(Student student);
    }
}
