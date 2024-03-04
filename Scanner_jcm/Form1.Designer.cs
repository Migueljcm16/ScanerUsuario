namespace Scanner_jcm
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
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnCrudAcceso = new System.Windows.Forms.Button();
            this.btnCrudUsuario = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBuscar
            // 
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscar.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(34, 148);
            this.txbBuscar.MaxLength = 8;
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(377, 46);
            this.txbBuscar.TabIndex = 2;
            this.txbBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 79);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCANNER DE ACCESO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackgroundImage = global::Scanner_jcm.Properties.Resources.backBlack;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Image = global::Scanner_jcm.Properties.Resources.setting;
            this.btnConfiguracion.Location = new System.Drawing.Point(59, 340);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(52, 55);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnCrudAcceso
            // 
            this.btnCrudAcceso.BackColor = System.Drawing.Color.Transparent;
            this.btnCrudAcceso.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGreen;
            this.btnCrudAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrudAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrudAcceso.FlatAppearance.BorderSize = 0;
            this.btnCrudAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrudAcceso.Image = global::Scanner_jcm.Properties.Resources.calendario;
            this.btnCrudAcceso.Location = new System.Drawing.Point(153, 340);
            this.btnCrudAcceso.Name = "btnCrudAcceso";
            this.btnCrudAcceso.Size = new System.Drawing.Size(52, 55);
            this.btnCrudAcceso.TabIndex = 6;
            this.btnCrudAcceso.UseVisualStyleBackColor = false;
            this.btnCrudAcceso.Click += new System.EventHandler(this.btnCrudAcceso_Click);
            // 
            // btnCrudUsuario
            // 
            this.btnCrudUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCrudUsuario.BackgroundImage = global::Scanner_jcm.Properties.Resources.backGray;
            this.btnCrudUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrudUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrudUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrudUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrudUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrudUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrudUsuario.Image = global::Scanner_jcm.Properties.Resources.user;
            this.btnCrudUsuario.Location = new System.Drawing.Point(247, 340);
            this.btnCrudUsuario.Name = "btnCrudUsuario";
            this.btnCrudUsuario.Size = new System.Drawing.Size(52, 55);
            this.btnCrudUsuario.TabIndex = 4;
            this.btnCrudUsuario.UseVisualStyleBackColor = false;
            this.btnCrudUsuario.Click += new System.EventHandler(this.btnCrudUsuario_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Scanner_jcm.Properties.Resources.backButton;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(153, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::Scanner_jcm.Properties.Resources.backRed;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Scanner_jcm.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(343, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 55);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 393);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnCrudAcceso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrudUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrudUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrudAcceso;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}

