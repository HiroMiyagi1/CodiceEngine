using System;
using System.Collections.Generic;

namespace CodiceEngine
{
    public class Estudiante
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public List<double> Notas { get; set; } = new List<double>();
        public List<bool> Asistencias { get; set; } = new List<bool>();

        public Estudiante(string rut, string nombre)
        {
            Rut = rut;
            Nombre = nombre;
        }

        public double Promedio => Notas.Count > 0 ? System.Linq.Enumerable.Average(Notas) : 0.0;

        public double PorcentajeAsistencia()
        {
            if (Asistencias.Count == 0) return 0.0;
            int presentes = 0;
            foreach (var a in Asistencias) if (a) presentes++;
            return ((double)presentes / Asistencias.Count) * 100.0;
        }
    }
}