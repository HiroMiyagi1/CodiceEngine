using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CodiceEngine
{
    public partial class Form1 : Form
    {
        // Estructura interna para almacenar estudiantes
        private class Estudiante
        {
            public string Rut { get; set; }
            public string Nombre { get; set; }
            public double? Nota { get; set; }
            public bool? Asistencia { get; set; }

            public Estudiante(string rut, string nombre)
            {
                Rut = rut;
                Nombre = nombre;
            }
        }

        private Dictionary<string, Estudiante> sistema = new Dictionary<string, Estudiante>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            dgvInforme.Columns.Clear();
            dgvInforme.Columns.Add("colAlumno", "Alumno");
            dgvInforme.Columns.Add("colNota", "Nota");
            dgvInforme.Columns.Add("colAsistencia", "Asist.");

            dgvInforme.Columns["colAlumno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInforme.Columns["colNota"].Width = 70;
            dgvInforme.Columns["colAsistencia"].Width = 80;
        }

        // ------------------ EVENTOS DE BOTONES ------------------

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            string rut = txtRut.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(rut) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor complete RUT y Nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!sistema.ContainsKey(rut))
            {
                sistema[rut] = new Estudiante(rut, nombre);
                ActualizarTabla();
                lblEstado.Text = "Alumno registrado";
                lblContador.Text = $"{sistema.Count} alumnos";
                btnLimpiar_Click(null, null);
            }
            else
            {
                errorProvider1.SetError(txtRut, "El RUT ya se encuentra registrado.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRut.Clear();
            txtNombre.Clear();
            errorProvider1.SetError(txtRut, "");
            errorProvider1.SetError(txtNombre, "");
            txtRut.Focus();
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim();

            if (sistema.ContainsKey(rut))
            {
                sistema[rut].Nota = (double)nudNota.Value;
                ActualizarTabla();
                lblEstado.Text = "Nota guardada";
            }
            else
            {
                MessageBox.Show("Ingrese un RUT registrado para asignar nota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text.Trim();

            if (sistema.ContainsKey(rut))
            {
                sistema[rut].Asistencia = chkPresente.Checked;
                ActualizarTabla();
                lblEstado.Text = "Asistencia guardada";
            }
            else
            {
                MessageBox.Show("Ingrese un RUT registrado para marcar asistencia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            lblEstado.Text = "Mostrando informe completo";
            MessageBox.Show($"Total de alumnos en sistema: {sistema.Count}", "Informe Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ------------------ VALIDACIÓN DE RUT ------------------

        private void txtRut_Validating(object sender, CancelEventArgs e)
        {
            string rut = txtRut.Text.Trim();
            if (string.IsNullOrEmpty(rut))
            {
                errorProvider1.SetError(txtRut, "");
                return;
            }

            if (!ValidarRutChileno(rut))
            {
                errorProvider1.SetError(txtRut, "Dígito verificador inválido");
            }
            else
            {
                errorProvider1.SetError(txtRut, "");
            }
        }

        private bool ValidarRutChileno(string rut)
        {
            rut = rut.Replace(".", "").Replace("-", "").ToUpper();
            if (rut.Length < 2) return false;

            string cuerpo = rut.Substring(0, rut.Length - 1);
            char dv = rut[rut.Length - 1];

            if (!int.TryParse(cuerpo, out int rutAux)) return false;

            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            char dvEsperado = (char)(s != 0 ? s + 47 : 75);

            return dv == dvEsperado;
        }

        // ------------------ ACTUALIZACIÓN DE INTERFAZ ------------------

        private void ActualizarTabla()
        {
            dgvInforme.Rows.Clear();
            foreach (var est in sistema.Values)
            {
                string strNota = est.Nota.HasValue ? est.Nota.Value.ToString("0.0") : "-";
                string strAsist = est.Asistencia.HasValue ? (est.Asistencia.Value ? "Presente" : "Ausente") : "-";

                int rowIndex = dgvInforme.Rows.Add(est.Nombre, strNota, strAsist);

                // Colorear asistencia
                if (est.Asistencia.HasValue)
                {
                    dgvInforme.Rows[rowIndex].Cells["colAsistencia"].Style.ForeColor =
                        est.Asistencia.Value ? Color.Green : Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}