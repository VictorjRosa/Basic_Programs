namespace Cedula
{
    partial class Cedula
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtTipoSangre = new System.Windows.Forms.TextBox();
            this.TxtOcupacion = new System.Windows.Forms.TextBox();
            this.TxtFechaExpiracion = new System.Windows.Forms.TextBox();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtProvincia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.CbbEstadoCivil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(26, 354);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(537, 43);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Text = "Nombres";
            // 
            // TxtApellido
            // 
            this.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(26, 395);
            this.TxtApellido.MaxLength = 20;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(537, 43);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.Text = "Apellidos";
            // 
            // TxtFechaNacimiento
            // 
            this.TxtFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaNacimiento.Location = new System.Drawing.Point(260, 192);
            this.TxtFechaNacimiento.MaxDate = new System.DateTime(2022, 11, 23, 0, 0, 0, 0);
            this.TxtFechaNacimiento.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.TxtFechaNacimiento.Name = "TxtFechaNacimiento";
            this.TxtFechaNacimiento.Size = new System.Drawing.Size(303, 29);
            this.TxtFechaNacimiento.TabIndex = 2;
            this.TxtFechaNacimiento.Value = new System.DateTime(2000, 11, 23, 0, 0, 0, 0);
            this.TxtFechaNacimiento.ValueChanged += new System.EventHandler(this.FechaNacimiento_ValueChanged);
            // 
            // TxtTipoSangre
            // 
            this.TxtTipoSangre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTipoSangre.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoSangre.Location = new System.Drawing.Point(443, 247);
            this.TxtTipoSangre.MaxLength = 2;
            this.TxtTipoSangre.Name = "TxtTipoSangre";
            this.TxtTipoSangre.Size = new System.Drawing.Size(48, 25);
            this.TxtTipoSangre.TabIndex = 3;
            this.TxtTipoSangre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtOcupacion
            // 
            this.TxtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOcupacion.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOcupacion.Location = new System.Drawing.Point(383, 273);
            this.TxtOcupacion.MaxLength = 20;
            this.TxtOcupacion.Name = "TxtOcupacion";
            this.TxtOcupacion.Size = new System.Drawing.Size(241, 25);
            this.TxtOcupacion.TabIndex = 4;
            // 
            // TxtFechaExpiracion
            // 
            this.TxtFechaExpiracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFechaExpiracion.Font = new System.Drawing.Font("Segoe UI Variable Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaExpiracion.Location = new System.Drawing.Point(260, 316);
            this.TxtFechaExpiracion.MaxLength = 50;
            this.TxtFechaExpiracion.Name = "TxtFechaExpiracion";
            this.TxtFechaExpiracion.ReadOnly = true;
            this.TxtFechaExpiracion.Size = new System.Drawing.Size(270, 32);
            this.TxtFechaExpiracion.TabIndex = 5;
            // 
            // TxtSexo
            // 
            this.TxtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSexo.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSexo.Location = new System.Drawing.Point(316, 245);
            this.TxtSexo.MaxLength = 1;
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.Size = new System.Drawing.Size(37, 25);
            this.TxtSexo.TabIndex = 7;
            this.TxtSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCedula
            // 
            this.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCedula.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(260, 82);
            this.TxtCedula.MaxLength = 13;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.ReadOnly = true;
            this.TxtCedula.Size = new System.Drawing.Size(437, 43);
            this.TxtCedula.TabIndex = 8;
            this.TxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProvincia.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProvincia.Location = new System.Drawing.Point(261, 144);
            this.TxtProvincia.MaxLength = 20;
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.Size = new System.Drawing.Size(218, 29);
            this.TxtProvincia.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 263);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(677, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 125);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(677, 300);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(111, 125);
            this.Btn_Guardar.TabIndex = 13;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // CbbEstadoCivil
            // 
            this.CbbEstadoCivil.FormattingEnabled = true;
            this.CbbEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Divorciado/a"});
            this.CbbEstadoCivil.Location = new System.Drawing.Point(630, 251);
            this.CbbEstadoCivil.Name = "CbbEstadoCivil";
            this.CbbEstadoCivil.Size = new System.Drawing.Size(132, 21);
            this.CbbEstadoCivil.TabIndex = 14;
            // 
            // Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cedula.Properties.Resources.Cedula_Parte_Delantera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbbEstadoCivil);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtProvincia);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.TxtSexo);
            this.Controls.Add(this.TxtFechaExpiracion);
            this.Controls.Add(this.TxtOcupacion);
            this.Controls.Add(this.TxtTipoSangre);
            this.Controls.Add(this.TxtFechaNacimiento);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Name = "Cedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cédula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTipoSangre;
        private System.Windows.Forms.TextBox TxtOcupacion;
        private System.Windows.Forms.TextBox TxtFechaExpiracion;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtProvincia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ComboBox CbbEstadoCivil;
        private System.Windows.Forms.DateTimePicker TxtFechaNacimiento;
    }
}

