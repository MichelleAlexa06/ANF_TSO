namespace sistema_contable01
{
    partial class Frm_report_asiento_fecha
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_report_asiento_fecha));
            this.Imprimir_asiento_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.repot_asiento_fecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Imprimir_asiento_fechaTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.Imprimir_asiento_fechaTableAdapter();
            this.Imprimir_asientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Imprimir_asientoTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.Imprimir_asientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asiento_fechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimir_asiento_fechaBindingSource
            // 
            this.Imprimir_asiento_fechaBindingSource.DataMember = "Imprimir_asiento_fecha";
            this.Imprimir_asiento_fechaBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repot_asiento_fecha
            // 
            this.repot_asiento_fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Imprimir_asiento_fechaBindingSource;
            this.repot_asiento_fecha.LocalReport.DataSources.Add(reportDataSource1);
            this.repot_asiento_fecha.LocalReport.ReportEmbeddedResource = "sistema_contable01.Report_asiento_fecha.rdlc";
            this.repot_asiento_fecha.Location = new System.Drawing.Point(0, 0);
            this.repot_asiento_fecha.Name = "repot_asiento_fecha";
            this.repot_asiento_fecha.Size = new System.Drawing.Size(838, 416);
            this.repot_asiento_fecha.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_fecha2);
            this.panel1.Controls.Add(this.dtp_fecha1);
            this.panel1.Controls.Add(this.btn_mostrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 63);
            this.panel1.TabIndex = 2;
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha2.Location = new System.Drawing.Point(376, 24);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(121, 23);
            this.dtp_fecha2.TabIndex = 6;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha1.Location = new System.Drawing.Point(179, 24);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(121, 23);
            this.dtp_fecha1.TabIndex = 5;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.Location = new System.Drawing.Point(545, 12);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(111, 33);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HASTA";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.repot_asiento_fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 416);
            this.panel2.TabIndex = 3;
            // 
            // Imprimir_asiento_fechaTableAdapter
            // 
            this.Imprimir_asiento_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // Imprimir_asientoBindingSource
            // 
            this.Imprimir_asientoBindingSource.DataMember = "Imprimir_asiento";
            this.Imprimir_asientoBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Imprimir_asientoTableAdapter
            // 
            this.Imprimir_asientoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_report_asiento_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_report_asiento_fecha";
            this.Text = "LIBRO DIARIO";
            this.Load += new System.EventHandler(this.Frm_report_asiento_fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asiento_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repot_asiento_fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.BindingSource Imprimir_asiento_fechaBindingSource;
        private Datos_Reportes Datos_Reportes;
        private Datos_ReportesTableAdapters.Imprimir_asiento_fechaTableAdapter Imprimir_asiento_fechaTableAdapter;
        private System.Windows.Forms.BindingSource Imprimir_asientoBindingSource;
        private Datos_ReportesTableAdapters.Imprimir_asientoTableAdapter Imprimir_asientoTableAdapter;
    }
}