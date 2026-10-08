using Xunit;

namespace CodiceEngine
{
    public class PruebasCodice
    {
        [Fact]
        public void RegistrarNota_NotaValida_RetornaTrue()
        {
            var gestor = new GestorAcademico();
            bool resultado = gestor.RegistrarNota(6.5);
            Assert.True(resultado);
        }

        [Fact]
        public void RegistrarNota_NotaInvalida_RetornaFalse()
        {
            var gestor = new GestorAcademico();
            bool resultado = gestor.RegistrarNota(7.5);
            Assert.False(resultado);
        }

        [Fact]
        public void CalcularPromedio_NotasCorrectas_RetornaPromedioExacto()
        {
            var gestor = new GestorAcademico();
            gestor.RegistrarNota(5.0);
            gestor.RegistrarNota(7.0);

            double promedio = gestor.CalcularPromedio();
            Assert.Equal(6.0, promedio);
        }

        [Fact]
        public void CalcularPorcentajeAsistencia_AsistenciaMixta_CalculaPorcentajeCorrecto()
        {
            var gestor = new GestorAcademico();
            gestor.RegistrarAsistencia(true);
            gestor.RegistrarAsistencia(false);

            double porcentaje = gestor.CalcularPorcentajeAsistencia();
            Assert.Equal(50.0, porcentaje);
        }
    }
}