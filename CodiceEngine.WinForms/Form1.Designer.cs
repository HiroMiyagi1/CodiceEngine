namespace CodiceEngine
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpAlumno = new GroupBox();
            lblRut = new Label();
            txtRut = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            grpEvaluacion = new GroupBox();
            lblNota = new Label();
            nudNota = new NumericUpDown();
            chkPresente = new CheckBox();
            btnGuardarNota = new Button();
            btnGuardarAsistencia = new Button();
            grpInforme = new GroupBox();
            dgvInforme = new DataGridView();
            btnVerInforme = new Button();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            lblContador = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            grpAlumno.SuspendLayout();
            grpEvaluacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            grpInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpAlumno
            // 
            grpAlumno.Controls.Add(lblRut);
            grpAlumno.Controls.Add(txtRut);
            grpAlumno.Controls.Add(lblNombre);
            grpAlumno.Controls.Add(txtNombre);
            grpAlumno.Controls.Add(btnRegistrar);
            grpAlumno.Controls.Add(btnLimpiar);
            grpAlumno.Location = new Point(14, 16);
            grpAlumno.Margin = new Padding(3, 4, 3, 4);
            grpAlumno.Name = "grpAlumno";
            grpAlumno.Padding = new Padding(3, 4, 3, 4);
            grpAlumno.Size = new Size(434, 187);
            grpAlumno.TabIndex = 0;
            grpAlumno.TabStop = false;
            grpAlumno.Text = "Datos del alumno";
            // 
            // lblRut
            // 
            lblRut.AutoSize = true;
            lblRut.Location = new Point(17, 40);
            lblRut.Name = "lblRut";
            lblRut.Size = new Size(36, 20);
            lblRut.TabIndex = 0;
            lblRut.Text = "RUT";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(86, 36);
            txtRut.Margin = new Padding(3, 4, 3, 4);
            txtRut.MaxLength = 12;
            txtRut.Name = "txtRut";
            txtRut.PlaceholderText = "12.345.678-9";
            txtRut.Size = new Size(314, 27);
            txtRut.TabIndex = 1;
            txtRut.Validating += txtRut_Validating;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 83);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(314, 27);
            txtNombre.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(17, 131);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(189, 40);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "&Registrar";
            toolTip1.SetToolTip(btnRegistrar, "Registra un nuevo alumno en el sistema");
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(211, 131);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(189, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "&Limpiar";
            toolTip1.SetToolTip(btnLimpiar, "Limpia los campos de texto");
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grpEvaluacion
            // 
            grpEvaluacion.Controls.Add(lblNota);
            grpEvaluacion.Controls.Add(nudNota);
            grpEvaluacion.Controls.Add(chkPresente);
            grpEvaluacion.Controls.Add(btnGuardarNota);
            grpEvaluacion.Controls.Add(btnGuardarAsistencia);
            grpEvaluacion.Location = new Point(14, 213);
            grpEvaluacion.Margin = new Padding(3, 4, 3, 4);
            grpEvaluacion.Name = "grpEvaluacion";
            grpEvaluacion.Padding = new Padding(3, 4, 3, 4);
            grpEvaluacion.Size = new Size(434, 173);
            grpEvaluacion.TabIndex = 1;
            grpEvaluacion.TabStop = false;
            grpEvaluacion.Text = "Evaluación";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(17, 40);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(42, 20);
            lblNota.TabIndex = 0;
            lblNota.Text = "Nota";
            // 
            // nudNota
            // 
            nudNota.DecimalPlaces = 1;
            nudNota.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudNota.Location = new Point(86, 37);
            nudNota.Margin = new Padding(3, 4, 3, 4);
            nudNota.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nudNota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(91, 27);
            nudNota.TabIndex = 5;
            nudNota.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(86, 80);
            chkPresente.Margin = new Padding(3, 4, 3, 4);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(87, 24);
            chkPresente.TabIndex = 6;
            chkPresente.Text = "Presente";
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.Location = new Point(17, 117);
            btnGuardarNota.Margin = new Padding(3, 4, 3, 4);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(189, 40);
            btnGuardarNota.TabIndex = 7;
            btnGuardarNota.Text = "Guardar nota";
            toolTip1.SetToolTip(btnGuardarNota, "Guarda la nota seleccionada para el RUT escrito");
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.Location = new Point(211, 117);
            btnGuardarAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.Size = new Size(189, 40);
            btnGuardarAsistencia.TabIndex = 8;
            btnGuardarAsistencia.Text = "Guardar asistencia";
            toolTip1.SetToolTip(btnGuardarAsistencia, "Registra la asistencia para el RUT escrito");
            btnGuardarAsistencia.Click += btnGuardarAsistencia_Click;
            // 
            // grpInforme
            // 
            grpInforme.Controls.Add(dgvInforme);
            grpInforme.Controls.Add(btnVerInforme);
            grpInforme.Location = new Point(14, 397);
            grpInforme.Margin = new Padding(3, 4, 3, 4);
            grpInforme.Name = "grpInforme";
            grpInforme.Padding = new Padding(3, 4, 3, 4);
            grpInforme.Size = new Size(434, 293);
            grpInforme.TabIndex = 2;
            grpInforme.TabStop = false;
            grpInforme.Text = "Informe";
            // 
            // dgvInforme
            // 
            dgvInforme.AllowUserToAddRows = false;
            dgvInforme.AllowUserToDeleteRows = false;
            dgvInforme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(17, 29);
            dgvInforme.Margin = new Padding(3, 4, 3, 4);
            dgvInforme.MultiSelect = false;
            dgvInforme.Name = "dgvInforme";
            dgvInforme.ReadOnly = true;
            dgvInforme.RowHeadersVisible = false;
            dgvInforme.RowHeadersWidth = 51;
            dgvInforme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInforme.Size = new Size(400, 193);
            dgvInforme.TabIndex = 9;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Location = new Point(17, 233);
            btnVerInforme.Margin = new Padding(3, 4, 3, 4);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(400, 40);
            btnVerInforme.TabIndex = 10;
            btnVerInforme.Text = "Ver informe completo";
            toolTip1.SetToolTip(btnVerInforme, "Muestra resumen completo");
            btnVerInforme.Click += btnVerInforme_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado, lblContador });
            statusStrip1.Location = new Point(0, 695);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(463, 26);
            statusStrip1.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(368, 20);
            lblEstado.Spring = true;
            lblEstado.Text = "Listo";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContador
            // 
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(77, 20);
            lblContador.Text = "0 alumnos";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 721);
            Controls.Add(grpAlumno);
            Controls.Add(grpEvaluacion);
            Controls.Add(grpInforme);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de alumnos";
            Load += Form1_Load;
            grpAlumno.ResumeLayout(false);
            grpAlumno.PerformLayout();
            grpEvaluacion.ResumeLayout(false);
            grpEvaluacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            grpInforme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlumno;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.GroupBox grpEvaluacion;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Button btnGuardarAsistencia;

        private System.Windows.Forms.GroupBox grpInforme;
        private System.Windows.Forms.DataGridView dgvInforme;
        private System.Windows.Forms.Button btnVerInforme;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblContador;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}