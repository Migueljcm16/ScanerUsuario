namespace Scanner_jcm
{
    partial class CrudUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGVusuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.chkAcceso = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrearusuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVusuarios
            // 
            this.dataGVusuarios.AllowUserToAddRows = false;
            this.dataGVusuarios.AllowUserToDeleteRows = false;
            this.dataGVusuarios.AllowUserToResizeColumns = false;
            this.dataGVusuarios.AllowUserToResizeRows = false;
            this.dataGVusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVusuarios.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGVusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGVusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVusuarios.Location = new System.Drawing.Point(300, 66);
            this.dataGVusuarios.Name = "dataGVusuarios";
            this.dataGVusuarios.ReadOnly = true;
            this.dataGVusuarios.Size = new System.Drawing.Size(680, 447);
            this.dataGVusuarios.TabIndex = 2;
            this.dataGVusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVusuarios_CellContentClick);
            this.dataGVusuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGVusuarios_CellPainting);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUEVO USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(36, 194);
            this.txtNombres.MaxLength = 100;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(227, 27);
            this.txtNombres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "APELLIDOS";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(36, 257);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(227, 27);
            this.txtApellidos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELEFONO";
            // 
            // txtTelf
            // 
            this.txtTelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelf.Location = new System.Drawing.Point(36, 320);
            this.txtTelf.MaxLength = 9;
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(227, 27);
            this.txtTelf.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(32, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(36, 382);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(227, 27);
            this.txtDni.TabIndex = 10;
            // 
            // chkAcceso
            // 
            this.chkAcceso.AutoSize = true;
            this.chkAcceso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.chkAcceso.Location = new System.Drawing.Point(36, 425);
            this.chkAcceso.Name = "chkAcceso";
            this.chkAcceso.Size = new System.Drawing.Size(81, 23);
            this.chkAcceso.TabIndex = 12;
            this.chkAcceso.Text = "ACCESO";
            this.chkAcceso.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGray;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::Scanner_jcm.Properties.Resources.limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(215, 488);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 54);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrearusuario
            // 
            this.btnCrearusuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearusuario.BackgroundImage = global::Scanner_jcm.Properties.Resources.backButton;
            this.btnCrearusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearusuario.FlatAppearance.BorderSize = 0;
            this.btnCrearusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearusuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearusuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearusuario.Location = new System.Drawing.Point(36, 471);
            this.btnCrearusuario.Name = "btnCrearusuario";
            this.btnCrearusuario.Size = new System.Drawing.Size(152, 42);
            this.btnCrearusuario.TabIndex = 13;
            this.btnCrearusuario.Text = "INGRESAR";
            this.btnCrearusuario.UseVisualStyleBackColor = false;
            this.btnCrearusuario.Click += new System.EventHandler(this.btnCrearusuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::Scanner_jcm.Properties.Resources.backReturn;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(-2, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(155, 46);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "REGRESAR";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Todos",
            "True",
            "False"});
            this.cboFiltro.Location = new System.Drawing.Point(830, 22);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(150, 27);
            this.cboFiltro.TabIndex = 15;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(762, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "ACCESO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 539);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrearusuario);
            this.Controls.Add(this.chkAcceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.dataGVusuarios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGVusuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.CheckBox chkAcceso;
        private System.Windows.Forms.Button btnCrearusuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label6;
    }
}