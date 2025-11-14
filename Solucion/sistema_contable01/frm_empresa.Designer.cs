namespace sistema_contable01
{
    partial class frm_empresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.conbestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgbempresa = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarUs = new System.Windows.Forms.Button();
            this.txtBuscarUs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoUs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnModificarUs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarUs = new System.Windows.Forms.Button();
            this.txtid_empresa = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtpropietario = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgbempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 54);
            this.label1.TabIndex = 126;
            this.label1.Text = "Registro De Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // conbestado
            // 
            this.conbestado.Enabled = false;
            this.conbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conbestado.FormattingEnabled = true;
            this.conbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.conbestado.Location = new System.Drawing.Point(613, 190);
            this.conbestado.Name = "conbestado";
            this.conbestado.Size = new System.Drawing.Size(135, 28);
            this.conbestado.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(219, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 26);
            this.label9.TabIndex = 125;
            this.label9.Text = "Nit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(296, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 124;
            this.label6.Text = "Ciudad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgbempresa
            // 
            this.dgbempresa.AllowUserToDeleteRows = false;
            this.dgbempresa.AllowUserToResizeColumns = false;
            this.dgbempresa.AllowUserToResizeRows = false;
            this.dgbempresa.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgbempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbempresa.ColumnHeadersVisible = false;
            this.dgbempresa.Location = new System.Drawing.Point(15, 272);
            this.dgbempresa.Name = "dgbempresa";
            this.dgbempresa.ReadOnly = true;
            this.dgbempresa.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgbempresa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbempresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbempresa.Size = new System.Drawing.Size(789, 293);
            this.dgbempresa.TabIndex = 123;
            this.dgbempresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbempresa_CellContentClick);
            this.dgbempresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbempresa_CellDoubleClick);
            this.dgbempresa.DoubleClick += new System.EventHandler(this.dgvUsuario_DoubleClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(15, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 26);
            this.label12.TabIndex = 122;
            this.label12.Text = "Codigo";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarUs
            // 
            this.btnBuscarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUs.FlatAppearance.BorderSize = 0;
            this.btnBuscarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUs.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUs.Location = new System.Drawing.Point(620, 66);
            this.btnBuscarUs.Name = "btnBuscarUs";
            this.btnBuscarUs.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarUs.TabIndex = 121;
            this.btnBuscarUs.Text = "BUSCAR";
            this.btnBuscarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUs.UseVisualStyleBackColor = false;
            // 
            // txtBuscarUs
            // 
            this.txtBuscarUs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUs.Location = new System.Drawing.Point(26, 66);
            this.txtBuscarUs.Multiline = true;
            this.txtBuscarUs.Name = "txtBuscarUs";
            this.txtBuscarUs.Size = new System.Drawing.Size(584, 31);
            this.txtBuscarUs.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(280, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Nit";
            // 
            // txtnit
            // 
            this.txtnit.Enabled = false;
            this.txtnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.Location = new System.Drawing.Point(370, 145);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(135, 26);
            this.txtnit.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(520, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Estado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(109, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 26);
            this.txtNombre.TabIndex = 108;
            // 
            // btnNuevoUs
            // 
            this.btnNuevoUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevoUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUs.FlatAppearance.BorderSize = 0;
            this.btnNuevoUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevoUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUs.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUs.Location = new System.Drawing.Point(26, 571);
            this.btnNuevoUs.Name = "btnNuevoUs";
            this.btnNuevoUs.Size = new System.Drawing.Size(108, 46);
            this.btnNuevoUs.TabIndex = 113;
            this.btnNuevoUs.Text = "NUEVO";
            this.btnNuevoUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUs.UseVisualStyleBackColor = false;
            this.btnNuevoUs.Click += new System.EventHandler(this.btnNuevoUs_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(19, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 117;
            this.label7.Text = "Nombre";
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUs.Enabled = false;
            this.btnEliminarUs.FlatAppearance.BorderSize = 0;
            this.btnEliminarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUs.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUs.Location = new System.Drawing.Point(410, 571);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(108, 46);
            this.btnEliminarUs.TabIndex = 115;
            this.btnEliminarUs.Text = "ELIMINAR";
            this.btnEliminarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUs.UseVisualStyleBackColor = false;
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // btnModificarUs
            // 
            this.btnModificarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnModificarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUs.Enabled = false;
            this.btnModificarUs.FlatAppearance.BorderSize = 0;
            this.btnModificarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModificarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUs.ForeColor = System.Drawing.Color.White;
            this.btnModificarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUs.Location = new System.Drawing.Point(277, 571);
            this.btnModificarUs.Name = "btnModificarUs";
            this.btnModificarUs.Size = new System.Drawing.Size(110, 46);
            this.btnModificarUs.TabIndex = 114;
            this.btnModificarUs.Text = "MODIFICAR";
            this.btnModificarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUs.UseVisualStyleBackColor = false;
            this.btnModificarUs.Click += new System.EventHandler(this.btnModificarUs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Codigo";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGuardarUs
            // 
            this.btnGuardarUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardarUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUs.Enabled = false;
            this.btnGuardarUs.FlatAppearance.BorderSize = 0;
            this.btnGuardarUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUs.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUs.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUs.Location = new System.Drawing.Point(151, 571);
            this.btnGuardarUs.Name = "btnGuardarUs";
            this.btnGuardarUs.Size = new System.Drawing.Size(111, 46);
            this.btnGuardarUs.TabIndex = 111;
            this.btnGuardarUs.Text = "GUARDAR";
            this.btnGuardarUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUs.UseVisualStyleBackColor = false;
            this.btnGuardarUs.Click += new System.EventHandler(this.btnGuardarUs_Click);
            // 
            // txtid_empresa
            // 
            this.txtid_empresa.Enabled = false;
            this.txtid_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_empresa.Location = new System.Drawing.Point(109, 110);
            this.txtid_empresa.Name = "txtid_empresa";
            this.txtid_empresa.Size = new System.Drawing.Size(135, 26);
            this.txtid_empresa.TabIndex = 112;
            this.txtid_empresa.Visible = false;
            // 
            // txtciudad
            // 
            this.txtciudad.Enabled = false;
            this.txtciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciudad.Location = new System.Drawing.Point(613, 145);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(135, 26);
            this.txtciudad.TabIndex = 127;
            // 
            // txtpropietario
            // 
            this.txtpropietario.Enabled = false;
            this.txtpropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpropietario.Location = new System.Drawing.Point(109, 192);
            this.txtpropietario.Name = "txtpropietario";
            this.txtpropietario.Size = new System.Drawing.Size(135, 26);
            this.txtpropietario.TabIndex = 128;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(370, 192);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(135, 26);
            this.txttelefono.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(272, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(11, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 131;
            this.label8.Text = "Propietario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(520, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 132;
            this.label10.Text = "Ciudad";
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(539, 571);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(108, 46);
            this.btnimprimir.TabIndex = 133;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Visible = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(80, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 26);
            this.label11.TabIndex = 134;
            this.label11.Text = "Nombre";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(408, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 26);
            this.label13.TabIndex = 135;
            this.label13.Text = "Propietario";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(617, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 26);
            this.label14.TabIndex = 136;
            this.label14.Text = "Estado";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(516, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 26);
            this.label15.TabIndex = 137;
            this.label15.Text = "Telefono";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(719, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 26);
            this.label16.TabIndex = 138;
            this.label16.Text = "Comtador";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(771, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 139;
            this.button1.Text = "Gestion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1011, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 644);
            this.panel1.TabIndex = 140;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 10);
            this.panel2.TabIndex = 141;
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtpropietario);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conbestado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgbempresa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBuscarUs);
            this.Controls.Add(this.txtBuscarUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoUs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminarUs);
            this.Controls.Add(this.btnModificarUs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarUs);
            this.Controls.Add(this.txtid_empresa);
            this.Name = "frm_empresa";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbempresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox conbestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarUs;
        private System.Windows.Forms.TextBox txtBuscarUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoUs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Button btnModificarUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarUs;
        private System.Windows.Forms.TextBox txtid_empresa;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtpropietario;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgbempresa;
    }
}