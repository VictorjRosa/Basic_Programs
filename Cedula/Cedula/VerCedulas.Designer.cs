namespace Cedula
{
    partial class VerCedulas
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
            this.components = new System.ComponentModel.Container();
            this.DgvCedulas = new System.Windows.Forms.DataGridView();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExpiracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCedulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCedulas
            // 
            this.DgvCedulas.AutoGenerateColumns = false;
            this.DgvCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCedulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.ocupacionDataGridViewTextBoxColumn,
            this.sangreDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.estadoCivilDataGridViewTextBoxColumn,
            this.fechaExpiracionDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn});
            this.DgvCedulas.DataSource = this.datosBindingSource;
            this.DgvCedulas.Location = new System.Drawing.Point(23, 44);
            this.DgvCedulas.Name = "DgvCedulas";
            this.DgvCedulas.Size = new System.Drawing.Size(746, 394);
            this.DgvCedulas.TabIndex = 0;
            // 
            // cedulasDataSet
            // 
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "Datos";
            // 
            // datosTableAdapter
            // 
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // ocupacionDataGridViewTextBoxColumn
            // 
            this.ocupacionDataGridViewTextBoxColumn.DataPropertyName = "Ocupacion";
            this.ocupacionDataGridViewTextBoxColumn.HeaderText = "Ocupación";
            this.ocupacionDataGridViewTextBoxColumn.Name = "ocupacionDataGridViewTextBoxColumn";
            // 
            // sangreDataGridViewTextBoxColumn
            // 
            this.sangreDataGridViewTextBoxColumn.DataPropertyName = "Sangre";
            this.sangreDataGridViewTextBoxColumn.HeaderText = "Sangre";
            this.sangreDataGridViewTextBoxColumn.Name = "sangreDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // estadoCivilDataGridViewTextBoxColumn
            // 
            this.estadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil";
            this.estadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estadoCivilDataGridViewTextBoxColumn.Name = "estadoCivilDataGridViewTextBoxColumn";
            // 
            // fechaExpiracionDataGridViewTextBoxColumn
            // 
            this.fechaExpiracionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Expiracion";
            this.fechaExpiracionDataGridViewTextBoxColumn.HeaderText = "Fecha Expiración";
            this.fechaExpiracionDataGridViewTextBoxColumn.Name = "fechaExpiracionDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(23, 15);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // VerCedulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.DgvCedulas);
            this.Name = "VerCedulas";
            this.Text = "VerCedulas";
            this.Load += new System.EventHandler(this.VerCedulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCedulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCedulas;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExpiracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnActualizar;
    }
}