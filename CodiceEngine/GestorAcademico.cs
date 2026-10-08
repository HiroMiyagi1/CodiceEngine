using System.Collections.Generic;

namespace CodiceEngine
{
    public class GestorAcademico
    {
        private readonly List<double> _notas = new List<double>();
        private readonly List<bool> _asistencias = new List<bool>();

        public bool RegistrarNota(double nota)
        {
            if (nota < 1.0 || nota > 7.0) return false;
            _notas.Add(nota);
            return true;
        }

        public double CalcularPromedio()
        {
            if (_notas.Count == 0) return 0.0;
            double suma = 0;
            foreach (var n in _notas) suma += n;
            return suma / _notas.Count;
        }

        public void RegistrarAsistencia(bool presente)
        {
            _asistencias.Add(presente);
        }

        public double CalcularPorcentajeAsistencia()
        {
            if (_asistencias.Count == 0) return 0.0;
            int presentes = 0;
            foreach (var a in _asistencias) if (a) presentes++;
            return ((double)presentes / _asistencias.Count) * 100;
        }
    }
}