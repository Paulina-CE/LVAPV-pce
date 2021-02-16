namespace LVAPV07
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
            this.btnLlamarAFormaDos = new System.Windows.Forms.Button();
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLlamarAFormaDos
            // 
            this.btnLlamarAFormaDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamarAFormaDos.Location = new System.Drawing.Point(570, 350);
            this.btnLlamarAFormaDos.Name = "btnLlamarAFormaDos";
            this.btnLlamarAFormaDos.Size = new System.Drawing.Size(208, 78);
            this.btnLlamarAFormaDos.TabIndex = 0;
            this.btnLlamarAFormaDos.Text = "Llamar forma dos";
            this.btnLlamarAFormaDos.UseVisualStyleBackColor = true;
            this.btnLlamarAFormaDos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.AutoSize = true;
            this.lblFormaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFormaUno.Location = new System.Drawing.Point(66, 72);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(187, 39);
            this.lblFormaUno.TabIndex = 1;
            this.lblFormaUno.Text = "Forma Uno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormaUno);
            this.Controls.Add(this.btnLlamarAFormaDos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamarAFormaDos;
        private System.Windows.Forms.Label lblFormaUno;
    }
}

