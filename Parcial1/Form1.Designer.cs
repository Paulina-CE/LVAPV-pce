namespace Parcial1
{
    partial class frmAsignacion
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
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblTelFijo = new System.Windows.Forms.Label();
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtTelFijo = new System.Windows.Forms.TextBox();
            this.txtTelMov = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatosCarrera = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.chcServicioSocial = new System.Windows.Forms.CheckBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.grpDatosPersonales.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDatosCarrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDatosPersonales.Controls.Add(this.txtApellidoP);
            this.grpDatosPersonales.Controls.Add(this.txtTelMov);
            this.grpDatosPersonales.Controls.Add(this.txtTelFijo);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoM);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblTelMovil);
            this.grpDatosPersonales.Controls.Add(this.lblTelFijo);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(9, 6);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(476, 199);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            this.grpDatosPersonales.Enter += new System.EventHandler(this.grpDatosPersonales_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(21, 62);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(116, 17);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(21, 99);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblTelFijo
            // 
            this.lblTelFijo.AutoSize = true;
            this.lblTelFijo.Location = new System.Drawing.Point(21, 131);
            this.lblTelFijo.Name = "lblTelFijo";
            this.lblTelFijo.Size = new System.Drawing.Size(94, 17);
            this.lblTelFijo.TabIndex = 3;
            this.lblTelFijo.Text = "Télefono Fijo:";
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.Location = new System.Drawing.Point(21, 164);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(104, 17);
            this.lblTelMovil.TabIndex = 4;
            this.lblTelMovil.Text = "Télefono Móvil:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(141, 96);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(319, 22);
            this.txtApellidoM.TabIndex = 6;
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.Location = new System.Drawing.Point(141, 128);
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(319, 22);
            this.txtTelFijo.TabIndex = 7;
            // 
            // txtTelMov
            // 
            this.txtTelMov.Location = new System.Drawing.Point(141, 161);
            this.txtTelMov.Name = "txtTelMov";
            this.txtTelMov.Size = new System.Drawing.Size(319, 22);
            this.txtTelMov.TabIndex = 8;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(141, 60);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(319, 22);
            this.txtApellidoP.TabIndex = 9;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbF);
            this.grpGenero.Controls.Add(this.rdbM);
            this.grpGenero.Location = new System.Drawing.Point(498, 6);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(73, 101);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbE);
            this.grpTipo.Controls.Add(this.rdbN);
            this.grpTipo.Location = new System.Drawing.Point(498, 113);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(73, 92);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(15, 24);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(40, 21);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(15, 55);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(37, 21);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(17, 26);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(39, 21);
            this.rdbN.TabIndex = 0;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Location = new System.Drawing.Point(15, 57);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(38, 21);
            this.rdbE.TabIndex = 1;
            this.rdbE.TabStop = true;
            this.rdbE.Text = "E";
            this.rdbE.UseVisualStyleBackColor = true;
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pictureBox1);
            this.grpFoto.Location = new System.Drawing.Point(586, 6);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(140, 198);
            this.grpFoto.TabIndex = 3;
            this.grpFoto.TabStop = false;
            this.grpFoto.Text = "Fotografía";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial1.Properties.Resources.IMG_20201122_113529_016;
            this.pictureBox1.Location = new System.Drawing.Point(31, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpDatosCarrera
            // 
            this.grpDatosCarrera.Controls.Add(this.cmbSemestre);
            this.grpDatosCarrera.Controls.Add(this.cmbCarrera);
            this.grpDatosCarrera.Controls.Add(this.chcServicioSocial);
            this.grpDatosCarrera.Controls.Add(this.txtPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblCarrera);
            this.grpDatosCarrera.Location = new System.Drawing.Point(9, 220);
            this.grpDatosCarrera.Name = "grpDatosCarrera";
            this.grpDatosCarrera.Size = new System.Drawing.Size(716, 121);
            this.grpDatosCarrera.TabIndex = 4;
            this.grpDatosCarrera.TabStop = false;
            this.grpDatosCarrera.Text = "Datos Carrera:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(21, 28);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(21, 57);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(72, 17);
            this.lblSemestre.TabIndex = 1;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(21, 86);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(72, 17);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(141, 83);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(185, 22);
            this.txtPromedio.TabIndex = 3;
            // 
            // chcServicioSocial
            // 
            this.chcServicioSocial.AutoSize = true;
            this.chcServicioSocial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocial.Location = new System.Drawing.Point(497, 82);
            this.chcServicioSocial.Name = "chcServicioSocial";
            this.chcServicioSocial.Size = new System.Drawing.Size(188, 21);
            this.chcServicioSocial.TabIndex = 4;
            this.chcServicioSocial.Text = "Servicio Social Concluido";
            this.chcServicioSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocial.UseVisualStyleBackColor = true;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Software",
            "Mecatronica",
            "Industrial",
            "IT",
            "Diseño Grápfico",
            "Psicología",
            "Derecho",
            "Idiomas"});
            this.cmbCarrera.Location = new System.Drawing.Point(141, 21);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(544, 24);
            this.cmbCarrera.TabIndex = 5;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "Sexto",
            "Séptimo",
            "Octavo",
            "Noveno"});
            this.cmbSemestre.Location = new System.Drawing.Point(141, 50);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(544, 24);
            this.cmbSemestre.TabIndex = 6;
            // 
            // frmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(748, 688);
            this.Controls.Add(this.grpDatosCarrera);
            this.Controls.Add(this.grpFoto);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "frmAsignacion";
            this.Text = "Asignación Práctica Profesional";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDatosCarrera.ResumeLayout(false);
            this.grpDatosCarrera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtTelMov;
        private System.Windows.Forms.TextBox txtTelFijo;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.Label lblTelFijo;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpDatosCarrera;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.CheckBox chcServicioSocial;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
    }
}

