using System;
using System.Collections.Generic;

namespace CodiceEngine
{
    class Program
    {
        static Dictionary<string, Estudiante> sistema = new Dictionary<string, Estudiante>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== CODICE ENGINE - GESTION ACADEMICA ===");
                Console.WriteLine("1. Registrar Estudiante");
                Console.WriteLine("2. Ingresar Calificación");
                Console.WriteLine("3. Registrar Asistencia");
                Console.WriteLine("4. Ver Informe del Estudiante");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese RUT: ");
                    string rut = Console.ReadLine().Trim();
                    Console.Write("Ingrese Nombre: ");
                    string nombre = Console.ReadLine().Trim();

                    if (!sistema.ContainsKey(rut))
                    {
                        sistema[rut] = new Estudiante(rut, nombre);
                        Console.WriteLine("Estudiante registrado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("El RUT ya está registrado.");
                    }
                }
                else if (opcion == "2")
                {
                    Console.Write("RUT del estudiante: ");
                    string rut = Console.ReadLine().Trim();
                    if (sistema.ContainsKey(rut))
                    {
                        Console.Write("Ingrese Nota (1.0 a 7.0): ");
                        if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 1.0 && nota <= 7.0)
                        {
                            sistema[rut].Notas.Add(nota);
                            Console.WriteLine("Nota registrada con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Nota inválida.");
                        }
                    }
                    else Console.WriteLine("Estudiante no encontrado.");
                }
                else if (opcion == "3")
                {
                    Console.Write("RUT del estudiante: ");
                    string rut = Console.ReadLine().Trim();
                    if (sistema.ContainsKey(rut))
                    {
                        Console.Write("¿Está presente? (s/n): ");
                        string resp = Console.ReadLine().Trim().ToLower();
                        sistema[rut].Asistencias.Add(resp == "s");
                        Console.WriteLine("Asistencia registrada.");
                    }
                    else Console.WriteLine("Estudiante no encontrado.");
                }
                else if (opcion == "4")
                {
                    Console.Write("RUT del estudiante: ");
                    string rut = Console.ReadLine().Trim();
                    if (sistema.ContainsKey(rut))
                    {
                        var est = sistema[rut];
                        Console.WriteLine($"\n--- INFORME: {est.Nombre} ({est.Rut}) ---");
                        Console.WriteLine($"Promedio de Notas: {est.Promedio:F2}");
                        Console.WriteLine($"Asistencia: {est.PorcentajeAsistencia():F1}%");
                    }
                    else Console.WriteLine("Estudiante no encontrado.");
                }
                else if (opcion == "5") break;
            }
        }
    }
}