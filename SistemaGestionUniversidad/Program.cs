using System;
using SistemaGestionUniversidad.Interfaces;
using SistemaGestionUniversidad.Models;
using SistemaGestionUniversidad.Services;
// Esto le enseña a la consola a hablar en Emojis (UTF-8)
Console.OutputEncoding = System.Text.Encoding.UTF8;

// === SIMULACIÓN DE APLICACIÓN ENTERPRISE ===

Console.WriteLine("=== UNIVERSITY MANAGEMENT SYSTEM (PROFESSIONAL DEMO) ===");
Console.WriteLine("Loading System...\n");

// 1. COMPOSICIÓN ROOT (Donde se arman las dependencias)
// Preparamos el servicio que vamos a usar.
var gradingService = new GradingService();

var franco = new Student(
    1,
    "Franco",
    "Developer",
    new DateTime(2003, 12, 16), // Año, Mes, Día
    "franco.dev@university.edu",
    "+54 9 11 1234-5678",
    "Av. Corrientes 1234, Buenos Aires",
    "LEG-2026-AR"
);

Console.WriteLine($"Student Loaded: {franco.FullName} ({franco.StudentId})");
Console.WriteLine($"Contact: {franco.Email}");
Console.WriteLine("--------------------------------------------------\n");

// 3. LÓGICA DE NEGOCIO (Ejecución)
Console.WriteLine(">>> Starting Evaluation Process...");

// Cargamos notas (Simulando un cuatrimestre)
gradingService.AddGrade(franco, 8.5);  // Primer parcial
gradingService.AddGrade(franco, 7.0);  // Segundo parcial
gradingService.AddGrade(franco, 12.0); // Error de tipeo (El sistema debe rechazarla)
gradingService.AddGrade(franco, 4.0);  // (Nota baja)
gradingService.AddGrade(franco, 9.5);  // Recuperatorio o TP final

// 4. REPORTE FINAL
// Le pedimos al servicio que calcule los resultados
double finalGpa = gradingService.CalculateGPA(franco);
bool isApproved = gradingService.IsApproved(franco);

// Imprimimos el informe
Console.WriteLine("\n==========================================");
Console.WriteLine("             FINAL ACADEMIC REPORT        ");
Console.WriteLine("==========================================");
Console.WriteLine($"Student:    {franco.FullName}");
Console.WriteLine($"ID:         {franco.StudentId}");
Console.WriteLine($"Grades:     {string.Join(" | ", franco.Grades)}"); // Truco para mostrar la lista linda
Console.WriteLine("------------------------------------------");
Console.WriteLine($"FINAL GPA:  {finalGpa:F2} / 10.0");
Console.WriteLine($"STATUS:     {(isApproved ? "APPROVED ✅" : "FAILED ❌")}");
Console.WriteLine("==========================================");

// Mantener consola abierta
Console.ReadKey();