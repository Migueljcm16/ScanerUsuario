namespace Scanner_jcm
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVaciarReg = new System.Windows.Forms.Button();
            this.btnExportarReg = new System.Windows.Forms.Button();
            this.btnImportarReg = new System.Windows.Forms.Button();
            this.btnImportarUsu = new System.Windows.Forms.Button();
            this.btnVaciarUsu = new System.Windows.Forms.Button();
            this.btnExportarUsu = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(547, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "TABLA USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-2, 135);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(547, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "TABLA REGISTRO ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVaciarReg
            // 
            this.btnVaciarReg.BackColor = System.Drawing.Color.Transparent;
            this.btnVaciarReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVaciarReg.BackgroundImage")));
            this.btnVaciarReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaciarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarReg.FlatAppearance.BorderSize = 0;
            this.btnVaciarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnVaciarReg.ForeColor = System.Drawing.Color.Black;
            this.btnVaciarReg.Image = global::Scanner_jcm.Properties.Resources.database;
            this.btnVaciarReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaciarReg.Location = new System.Drawing.Point(354, 207);
            this.btnVaciarReg.Name = "btnVaciarReg";
            this.btnVaciarReg.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnVaciarReg.Size = new System.Drawing.Size(155, 42);
            this.btnVaciarReg.TabIndex = 16;
            this.btnVaciarReg.Text = "VACIAR TABLA";
            this.btnVaciarReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaciarReg.UseVisualStyleBackColor = false;
            this.btnVaciarReg.Click += new System.EventHandler(this.btnVaciarReg_Click);
            // 
            // btnExportarReg
            // 
            this.btnExportarReg.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarReg.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGreenExcel;
            this.btnExportarReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarReg.FlatAppearance.BorderSize = 0;
            this.btnExportarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportarReg.ForeColor = System.Drawing.Color.Black;
            this.btnExportarReg.Image = global::Scanner_jcm.Properties.Resources.excel;
            this.btnExportarReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarReg.Location = new System.Drawing.Point(32, 207);
            this.btnExportarReg.Name = "btnExportarReg";
            this.btnExportarReg.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnExportarReg.Size = new System.Drawing.Size(132, 42);
            this.btnExportarReg.TabIndex = 15;
            this.btnExportarReg.Text = "EXPORTAR";
            this.btnExportarReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarReg.UseVisualStyleBackColor = false;
            this.btnExportarReg.Click += new System.EventHandler(this.btnExportarReg_Click);
            // 
            // btnImportarReg
            // 
            this.btnImportarReg.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarReg.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGreenExcel;
            this.btnImportarReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportarReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarReg.FlatAppearance.BorderSize = 0;
            this.btnImportarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnImportarReg.ForeColor = System.Drawing.Color.Black;
            this.btnImportarReg.Image = global::Scanner_jcm.Properties.Resources.excel;
            this.btnImportarReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarReg.Location = new System.Drawing.Point(193, 207);
            this.btnImportarReg.Name = "btnImportarReg";
            this.btnImportarReg.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnImportarReg.Size = new System.Drawing.Size(132, 42);
            this.btnImportarReg.TabIndex = 17;
            this.btnImportarReg.Text = "IMPORTAR";
            this.btnImportarReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarReg.UseVisualStyleBackColor = false;
            this.btnImportarReg.Click += new System.EventHandler(this.btnImportarReg_Click);
            // 
            // btnImportarUsu
            // 
            this.btnImportarUsu.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarUsu.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGreenExcel;
            this.btnImportarUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarUsu.FlatAppearance.BorderSize = 0;
            this.btnImportarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarUsu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnImportarUsu.ForeColor = System.Drawing.Color.Black;
            this.btnImportarUsu.Image = global::Scanner_jcm.Properties.Resources.excel;
            this.btnImportarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarUsu.Location = new System.Drawing.Point(193, 69);
            this.btnImportarUsu.Name = "btnImportarUsu";
            this.btnImportarUsu.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnImportarUsu.Size = new System.Drawing.Size(132, 42);
            this.btnImportarUsu.TabIndex = 20;
            this.btnImportarUsu.Text = "IMPORTAR";
            this.btnImportarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarUsu.UseVisualStyleBackColor = false;
            this.btnImportarUsu.Click += new System.EventHandler(this.btnImportarUsu_Click);
            // 
            // btnVaciarUsu
            // 
            this.btnVaciarUsu.BackColor = System.Drawing.Color.Transparent;
            this.btnVaciarUsu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVaciarUsu.BackgroundImage")));
            this.btnVaciarUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaciarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarUsu.FlatAppearance.BorderSize = 0;
            this.btnVaciarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarUsu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnVaciarUsu.ForeColor = System.Drawing.Color.Black;
            this.btnVaciarUsu.Image = global::Scanner_jcm.Properties.Resources.database;
            this.btnVaciarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaciarUsu.Location = new System.Drawing.Point(354, 69);
            this.btnVaciarUsu.Name = "btnVaciarUsu";
            this.btnVaciarUsu.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnVaciarUsu.Size = new System.Drawing.Size(155, 42);
            this.btnVaciarUsu.TabIndex = 19;
            this.btnVaciarUsu.Text = "VACIAR TABLA";
            this.btnVaciarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaciarUsu.UseVisualStyleBackColor = false;
            this.btnVaciarUsu.Click += new System.EventHandler(this.btnVaciarUsu_Click);
            // 
            // btnExportarUsu
            // 
            this.btnExportarUsu.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarUsu.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGreenExcel;
            this.btnExportarUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarUsu.FlatAppearance.BorderSize = 0;
            this.btnExportarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarUsu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportarUsu.ForeColor = System.Drawing.Color.Black;
            this.btnExportarUsu.Image = global::Scanner_jcm.Properties.Resources.excel;
            this.btnExportarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarUsu.Location = new System.Drawing.Point(32, 69);
            this.btnExportarUsu.Name = "btnExportarUsu";
            this.btnExportarUsu.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnExportarUsu.Size = new System.Drawing.Size(132, 42);
            this.btnExportarUsu.TabIndex = 18;
            this.btnExportarUsu.Text = "EXPORTAR";
            this.btnExportarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarUsu.UseVisualStyleBackColor = false;
            this.btnExportarUsu.Click += new System.EventHandler(this.btnExportarUsu_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Brown;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(481, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 46);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "X";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 275);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnImportarUsu);
            this.Controls.Add(this.btnVaciarUsu);
            this.Controls.Add(this.btnExportarUsu);
            this.Controls.Add(this.btnImportarReg);
            this.Controls.Add(this.btnVaciarReg);
            this.Controls.Add(this.btnExportarReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportarReg;
        private System.Windows.Forms.Button btnVaciarReg;
        private System.Windows.Forms.Button btnImportarReg;
        private System.Windows.Forms.Button btnImportarUsu;
        private System.Windows.Forms.Button btnVaciarUsu;
        private System.Windows.Forms.Button btnExportarUsu;
        private System.Windows.Forms.Button btnVolver;
    }
}