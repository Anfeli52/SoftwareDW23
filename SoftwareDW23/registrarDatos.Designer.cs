namespace SoftwareDW23
{
    partial class registrarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarCuerpo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigoAgua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.txtNombreCuerpo = new System.Windows.Forms.TextBox();
            this.txtNivelPH = new System.Windows.Forms.TextBox();
            this.txtTurbidad = new System.Windows.Forms.TextBox();
            this.cbCuerpoAgua = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(537, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cerrar Sesión";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrarCuerpo
            // 
            this.btnRegistrarCuerpo.Location = new System.Drawing.Point(437, 417);
            this.btnRegistrarCuerpo.Name = "btnRegistrarCuerpo";
            this.btnRegistrarCuerpo.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarCuerpo.TabIndex = 1;
            this.btnRegistrarCuerpo.Text = "Registrar";
            this.btnRegistrarCuerpo.UseVisualStyleBackColor = true;
            this.btnRegistrarCuerpo.Click += new System.EventHandler(this.btnRegistrarCuerpo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATOS DEL SENSOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(393, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(393, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuerpo de Agua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(393, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel de PH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(393, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Turbidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblCodigoAgua);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ptbImagen);
            this.panel1.Controls.Add(this.btnSeleccionarImagen);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 520);
            this.panel1.TabIndex = 7;
            // 
            // lblCodigoAgua
            // 
            this.lblCodigoAgua.AutoSize = true;
            this.lblCodigoAgua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAgua.Location = new System.Drawing.Point(137, 426);
            this.lblCodigoAgua.MaximumSize = new System.Drawing.Size(150, 20);
            this.lblCodigoAgua.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCodigoAgua.Name = "lblCodigoAgua";
            this.lblCodigoAgua.Size = new System.Drawing.Size(100, 20);
            this.lblCodigoAgua.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Código Agua: ";
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(35, 85);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(263, 224);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 1;
            this.ptbImagen.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(75, 353);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(194, 31);
            this.btnSeleccionarImagen.TabIndex = 0;
            this.btnSeleccionarImagen.Text = "Agregar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // txtNombreCuerpo
            // 
            this.txtNombreCuerpo.Location = new System.Drawing.Point(397, 140);
            this.txtNombreCuerpo.Name = "txtNombreCuerpo";
            this.txtNombreCuerpo.Size = new System.Drawing.Size(275, 20);
            this.txtNombreCuerpo.TabIndex = 8;
            // 
            // txtNivelPH
            // 
            this.txtNivelPH.Location = new System.Drawing.Point(397, 289);
            this.txtNivelPH.Name = "txtNivelPH";
            this.txtNivelPH.Size = new System.Drawing.Size(275, 20);
            this.txtNivelPH.TabIndex = 9;
            // 
            // txtTurbidad
            // 
            this.txtTurbidad.Location = new System.Drawing.Point(397, 353);
            this.txtTurbidad.Name = "txtTurbidad";
            this.txtTurbidad.Size = new System.Drawing.Size(273, 20);
            this.txtTurbidad.TabIndex = 10;
            // 
            // cbCuerpoAgua
            // 
            this.cbCuerpoAgua.FormattingEnabled = true;
            this.cbCuerpoAgua.Items.AddRange(new object[] {
            "Lago",
            "Rio",
            "Oceano",
            "Mar"});
            this.cbCuerpoAgua.Location = new System.Drawing.Point(399, 216);
            this.cbCuerpoAgua.Name = "cbCuerpoAgua";
            this.cbCuerpoAgua.Size = new System.Drawing.Size(273, 21);
            this.cbCuerpoAgua.TabIndex = 11;
            this.cbCuerpoAgua.Text = "Seleccione...";
            // 
            // registrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(760, 515);
            this.Controls.Add(this.cbCuerpoAgua);
            this.Controls.Add(this.txtTurbidad);
            this.Controls.Add(this.txtNivelPH);
            this.Controls.Add(this.txtNombreCuerpo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarCuerpo);
            this.Controls.Add(this.btnCancelar);
            this.Name = "registrarDatos";
            this.Text = "registrarDatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrarCuerpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNivelPH;
        private System.Windows.Forms.TextBox txtTurbidad;
        private System.Windows.Forms.ComboBox cbCuerpoAgua;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCodigoAgua;
        public System.Windows.Forms.TextBox txtNombreCuerpo;
    }
}