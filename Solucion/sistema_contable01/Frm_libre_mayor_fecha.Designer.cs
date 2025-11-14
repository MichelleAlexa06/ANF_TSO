namespace sistema_contable01
{
    partial class Frm_libro_mayor_fecha
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.btn_buscar_lb_mayor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.Panel_centro = new System.Windows.Forms.Panel();
            this.Rport_libro_may_fecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.libro_mayor_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libro_mayor_fechaTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.libro_mayor_fechaTableAdapter();
            this.Panel_arriba.SuspendLayout();
            this.Panel_centro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_fechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel_arriba.Controls.Add(this.btn_buscar_lb_mayor);
            this.Panel_arriba.Controls.Add(this.label2);
            this.Panel_arriba.Controls.Add(this.label1);
            this.Panel_arriba.Controls.Add(this.dtp_fecha2);
            this.Panel_arriba.Controls.Add(this.dtp_fecha1);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(863, 75);
            this.Panel_arriba.TabIndex = 2;
            // 
            // btn_buscar_lb_mayor
            // 
            this.btn_buscar_lb_mayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscar_lb_mayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_lb_mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lb_mayor.Location = new System.Drawing.Point(553, 18);
            this.btn_buscar_lb_mayor.Name = "btn_buscar_lb_mayor";
            this.btn_buscar_lb_mayor.Size = new System.Drawing.Size(131, 37);
            this.btn_buscar_lb_mayor.TabIndex = 7;
            this.btn_buscar_lb_mayor.Text = "MOSTRAR";
            this.btn_buscar_lb_mayor.UseVisualStyleBackColor = false;
            this.btn_buscar_lb_mayor.Click += new System.EventHandler(this.btn_buscar_lb_mayor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESDE:";
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha2.Location = new System.Drawing.Point(389, 24);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(114, 20);
            this.dtp_fecha2.TabIndex = 1;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha1.Location = new System.Drawing.Point(199, 24);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(112, 20);
            this.dtp_fecha1.TabIndex = 0;
            // 
            // Panel_centro
            // 
            this.Panel_centro.Controls.Add(this.Rport_libro_may_fecha);
            this.Panel_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_centro.Location = new System.Drawing.Point(0, 75);
            this.Panel_centro.Name = "Panel_centro";
            this.Panel_centro.Size = new System.Drawing.Size(863, 417);
            this.Panel_centro.TabIndex = 3;
            // 
            // Rport_libro_may_fecha
            // 
            this.Rport_libro_may_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.libro_mayor_fechaBindingSource;
            this.Rport_libro_may_fecha.LocalReport.DataSources.Add(reportDataSource2);
            this.Rport_libro_may_fecha.LocalReport.ReportEmbeddedResource = "sistema_contable01.RP_lib_mayor_fecha.rdlc";
            this.Rport_libro_may_fecha.Location = new System.Drawing.Point(0, 0);
            this.Rport_libro_may_fecha.Name = "Rport_libro_may_fecha";
            this.Rport_libro_may_fecha.Size = new System.Drawing.Size(863, 417);
            this.Rport_libro_may_fecha.TabIndex = 0;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libro_mayor_fechaBindingSource
            // 
            this.libro_mayor_fechaBindingSource.DataMember = "libro_mayor_fecha";
            this.libro_mayor_fechaBindingSource.DataSource = this.Datos_Reportes;
            // 
            // libro_mayor_fechaTableAdapter
            // 
            this.libro_mayor_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_libro_mayor_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 492);
            this.Controls.Add(this.Panel_centro);
            this.Controls.Add(this.Panel_arriba);
            this.Name = "Frm_libro_mayor_fecha";
            this.Text = "LIBRO MAYOR";
            this.Load += new System.EventHandler(this.Frm_libro_mayor_fecha_Load);
            this.Panel_arriba.ResumeLayout(false);
            this.Panel_arriba.PerformLayout();
            this.Panel_centro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_fechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Button btn_buscar_lb_mayor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.Panel Panel_centro;
        private Microsoft.Reporting.WinForms.ReportViewer Rport_libro_may_fecha;
        private System.Windows.Forms.BindingSource libro_mayor_fechaBindingSource;
        private Datos_Reportes Datos_Reportes;
        private Datos_ReportesTableAdapters.libro_mayor_fechaTableAdapter libro_mayor_fechaTableAdapter;
    }
}