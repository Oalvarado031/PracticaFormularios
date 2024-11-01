namespace EjercicioPacientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblDptoMedico = new System.Windows.Forms.Label();
            this.LblMotivoConsulta = new System.Windows.Forms.Label();
            this.LblAlergias = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cbxSi = new System.Windows.Forms.CheckBox();
            this.cbxNo = new System.Windows.Forms.CheckBox();
            this.cmbDptMedico = new System.Windows.Forms.ComboBox();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(84, 29);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(84, 62);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(47, 13);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(30, 102);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.LblFechaNacimiento.TabIndex = 2;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(86, 139);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(45, 13);
            this.LblGenero.TabIndex = 3;
            this.LblGenero.Text = "Género:";
            // 
            // LblDptoMedico
            // 
            this.LblDptoMedico.AutoSize = true;
            this.LblDptoMedico.Location = new System.Drawing.Point(26, 173);
            this.LblDptoMedico.Name = "LblDptoMedico";
            this.LblDptoMedico.Size = new System.Drawing.Size(115, 13);
            this.LblDptoMedico.TabIndex = 4;
            this.LblDptoMedico.Text = "Departamento Médico:";
            // 
            // LblMotivoConsulta
            // 
            this.LblMotivoConsulta.AutoSize = true;
            this.LblMotivoConsulta.Location = new System.Drawing.Point(40, 206);
            this.LblMotivoConsulta.Name = "LblMotivoConsulta";
            this.LblMotivoConsulta.Size = new System.Drawing.Size(101, 13);
            this.LblMotivoConsulta.TabIndex = 5;
            this.LblMotivoConsulta.Text = "Motivo de Consulta:";
            // 
            // LblAlergias
            // 
            this.LblAlergias.AutoSize = true;
            this.LblAlergias.Location = new System.Drawing.Point(75, 250);
            this.LblAlergias.Name = "LblAlergias";
            this.LblAlergias.Size = new System.Drawing.Size(56, 13);
            this.LblAlergias.TabIndex = 6;
            this.LblAlergias.Text = "¿Alergias?";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(156, 99);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 8;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(156, 136);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(69, 21);
            this.cmbGenero.TabIndex = 9;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(156, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // cbxSi
            // 
            this.cbxSi.AutoSize = true;
            this.cbxSi.Location = new System.Drawing.Point(156, 249);
            this.cbxSi.Name = "cbxSi";
            this.cbxSi.Size = new System.Drawing.Size(35, 17);
            this.cbxSi.TabIndex = 11;
            this.cbxSi.Text = "Si";
            this.cbxSi.UseVisualStyleBackColor = true;
            this.cbxSi.CheckedChanged += new System.EventHandler(this.cbxSi_CheckedChanged);
            // 
            // cbxNo
            // 
            this.cbxNo.AutoSize = true;
            this.cbxNo.Location = new System.Drawing.Point(216, 249);
            this.cbxNo.Name = "cbxNo";
            this.cbxNo.Size = new System.Drawing.Size(40, 17);
            this.cbxNo.TabIndex = 12;
            this.cbxNo.Text = "No";
            this.cbxNo.UseVisualStyleBackColor = true;
            this.cbxNo.CheckedChanged += new System.EventHandler(this.cbxNo_CheckedChanged);
            // 
            // cmbDptMedico
            // 
            this.cmbDptMedico.FormattingEnabled = true;
            this.cmbDptMedico.Items.AddRange(new object[] {
            "Cardiología",
            "Neurología",
            "Pediatría",
            "Ginecología",
            "Ortopedia"});
            this.cmbDptMedico.Location = new System.Drawing.Point(156, 170);
            this.cmbDptMedico.Name = "cmbDptMedico";
            this.cmbDptMedico.Size = new System.Drawing.Size(100, 21);
            this.cmbDptMedico.TabIndex = 13;
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(156, 206);
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.Size = new System.Drawing.Size(110, 20);
            this.txtMotivoConsulta.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(156, 297);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 332);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMotivoConsulta);
            this.Controls.Add(this.cmbDptMedico);
            this.Controls.Add(this.cbxNo);
            this.Controls.Add(this.cbxSi);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LblAlergias);
            this.Controls.Add(this.LblMotivoConsulta);
            this.Controls.Add(this.LblDptoMedico);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblDptoMedico;
        private System.Windows.Forms.Label LblMotivoConsulta;
        private System.Windows.Forms.Label LblAlergias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox cbxSi;
        private System.Windows.Forms.CheckBox cbxNo;
        private System.Windows.Forms.ComboBox cmbDptMedico;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

