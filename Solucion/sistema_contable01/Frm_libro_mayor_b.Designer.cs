namespace sistema_contable01
{
    partial class Frm_libro_mayor_b
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.libro_mayor_bBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.rport_libro_may_b = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.btn_buscar_lb_mayor = new System.Windows.Forms.Button();
            this.btn_buscar_plan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscar_plan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.Panel_centro = new System.Windows.Forms.Panel();
            this.libro_mayor_bTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.libro_mayor_bTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_bBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            this.Panel_centro.SuspendLayout();
            this.SuspendLayout();
            // 
            // libro_mayor_bBindingSource
            // 
            this.libro_mayor_bBindingSource.DataMember = "libro_mayor_b";
            this.libro_mayor_bBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rport_libro_may_b
            // 
            this.rport_libro_may_b.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.libro_mayor_bBindingSource;
            this.rport_libro_may_b.LocalReport.DataSources.Add(reportDataSource3);
            this.rport_libro_may_b.LocalReport.ReportEmbeddedResource = "sistema_contable01.RP_Libro_mayor_b.rdlc";
            this.rport_libro_may_b.Location = new System.Drawing.Point(0, 0);
            this.rport_libro_may_b.Name = "rport_libro_may_b";
            this.rport_libro_may_b.ServerReport.BearerToken = null;
            this.rport_libro_may_b.Size = new System.Drawing.Size(696, 384);
            this.rport_libro_may_b.TabIndex = 0;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_arriba.Controls.Add(this.btn_buscar_lb_mayor);
            this.Panel_arriba.Controls.Add(this.btn_buscar_plan);
            this.Panel_arriba.Controls.Add(this.label3);
            this.Panel_arriba.Controls.Add(this.txt_buscar_plan);
            this.Panel_arriba.Controls.Add(this.label2);
            this.Panel_arriba.Controls.Add(this.label1);
            this.Panel_arriba.Controls.Add(this.dtp_fecha2);
            this.Panel_arriba.Controls.Add(this.dtp_fecha1);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(696, 75);
            this.Panel_arriba.TabIndex = 1;
            // 
            // btn_buscar_lb_mayor
            // 
            this.btn_buscar_lb_mayor.BackColor = System.Drawing.Color.Silver;
            this.btn_buscar_lb_mayor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar_lb_mayor.Location = new System.Drawing.Point(553, 18);
            this.btn_buscar_lb_mayor.Name = "btn_buscar_lb_mayor";
            this.btn_buscar_lb_mayor.Size = new System.Drawing.Size(131, 37);
            this.btn_buscar_lb_mayor.TabIndex = 7;
            this.btn_buscar_lb_mayor.Text = "Buscar";
            this.btn_buscar_lb_mayor.UseVisualStyleBackColor = false;
            this.btn_buscar_lb_mayor.Click += new System.EventHandler(this.btn_buscar_lb_mayor_Click);
            // 
            // btn_buscar_plan
            // 
            this.btn_buscar_plan.BackColor = System.Drawing.Color.Silver;
            this.btn_buscar_plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_plan.Location = new System.Drawing.Point(262, 24);
            this.btn_buscar_plan.Name = "btn_buscar_plan";
            this.btn_buscar_plan.Size = new System.Drawing.Size(46, 23);
            this.btn_buscar_plan.TabIndex = 6;
            this.btn_buscar_plan.Text = "---";
            this.btn_buscar_plan.UseVisualStyleBackColor = false;
            this.btn_buscar_plan.Click += new System.EventHandler(this.btn_buscar_plan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PLAN DE CUENTA";
            // 
            // txt_buscar_plan
            // 
            this.txt_buscar_plan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_plan.Location = new System.Drawing.Point(12, 24);
            this.txt_buscar_plan.Name = "txt_buscar_plan";
            this.txt_buscar_plan.Size = new System.Drawing.Size(244, 23);
            this.txt_buscar_plan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESDE:";
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha2.Location = new System.Drawing.Point(446, 24);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(91, 20);
            this.dtp_fecha2.TabIndex = 1;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha1.Location = new System.Drawing.Point(331, 25);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(91, 20);
            this.dtp_fecha1.TabIndex = 0;
            // 
            // Panel_centro
            // 
            this.Panel_centro.BackColor = System.Drawing.Color.Silver;
            this.Panel_centro.Controls.Add(this.rport_libro_may_b);
            this.Panel_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_centro.Location = new System.Drawing.Point(0, 75);
            this.Panel_centro.Name = "Panel_centro";
            this.Panel_centro.Size = new System.Drawing.Size(696, 384);
            this.Panel_centro.TabIndex = 2;
            // 
            // libro_mayor_bTableAdapter
            // 
            this.libro_mayor_bTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_libro_mayor_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 459);
            this.Controls.Add(this.Panel_centro);
            this.Controls.Add(this.Panel_arriba);
            this.Name = "Frm_libro_mayor_b";
            this.Text = "LIBRO MAYRO B";
            this.Load += new System.EventHandler(this.Frm_libro_mayor_b_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_bBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            this.Panel_arriba.PerformLayout();
            this.Panel_centro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rport_libro_may_b;
        private System.Windows.Forms.BindingSource libro_mayor_bBindingSource;
        private Datos_Reportes Datos_Reportes;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Panel Panel_centro;
        private Datos_ReportesTableAdapters.libro_mayor_bTableAdapter libro_mayor_bTableAdapter;
        private System.Windows.Forms.Button btn_buscar_plan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar_plan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.Button btn_buscar_lb_mayor;
    }
}