namespace GetHospi.Vista
{
    partial class FrmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroUsuario));
            this.dgvUsuariosU = new System.Windows.Forms.DataGridView();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.btnGuardarM = new System.Windows.Forms.Button();
            this.btnNuevoU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuiU = new System.Windows.Forms.TextBox();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNitU = new System.Windows.Forms.TextBox();
            this.txtDireccionU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassU = new System.Windows.Forms.TextBox();
            this.dtFechaU = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosU)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuariosU
            // 
            this.dgvUsuariosU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosU.Location = new System.Drawing.Point(12, 408);
            this.dgvUsuariosU.Name = "dgvUsuariosU";
            this.dgvUsuariosU.Size = new System.Drawing.Size(655, 243);
            this.dgvUsuariosU.TabIndex = 21;
            this.dgvUsuariosU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosU_CellClick);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarM.FlatAppearance.BorderSize = 2;
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(490, 657);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(177, 32);
            this.btnEliminarM.TabIndex = 24;
            this.btnEliminarM.Text = "Eliminar Seleccionado";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizarM.FlatAppearance.BorderSize = 2;
            this.btnActualizarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarM.Location = new System.Drawing.Point(300, 657);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(184, 32);
            this.btnActualizarM.TabIndex = 23;
            this.btnActualizarM.Text = "Actualizar Seleccionado";
            this.btnActualizarM.UseVisualStyleBackColor = false;
            this.btnActualizarM.Click += new System.EventHandler(this.btnActualizarM_Click);
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarM.FlatAppearance.BorderSize = 2;
            this.btnGuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarM.Location = new System.Drawing.Point(156, 657);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(138, 32);
            this.btnGuardarM.TabIndex = 22;
            this.btnGuardarM.Text = "Guardar Nuevo";
            this.btnGuardarM.UseVisualStyleBackColor = false;
            this.btnGuardarM.Click += new System.EventHandler(this.btnGuardarM_Click);
            // 
            // btnNuevoU
            // 
            this.btnNuevoU.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoU.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoU.FlatAppearance.BorderSize = 2;
            this.btnNuevoU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoU.Location = new System.Drawing.Point(12, 657);
            this.btnNuevoU.Name = "btnNuevoU";
            this.btnNuevoU.Size = new System.Drawing.Size(138, 32);
            this.btnNuevoU.TabIndex = 31;
            this.btnNuevoU.Text = "Nuevo";
            this.btnNuevoU.UseVisualStyleBackColor = false;
            this.btnNuevoU.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDuiU);
            this.groupBox1.Controls.Add(this.txtNombreU);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNitU);
            this.groupBox1.Controls.Add(this.txtDireccionU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUserU);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassU);
            this.groupBox1.Controls.Add(this.dtFechaU);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 376);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fecha";
            // 
            // txtDuiU
            // 
            this.txtDuiU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuiU.Location = new System.Drawing.Point(121, 206);
            this.txtDuiU.Multiline = true;
            this.txtDuiU.Name = "txtDuiU";
            this.txtDuiU.Size = new System.Drawing.Size(171, 23);
            this.txtDuiU.TabIndex = 48;
            // 
            // txtNombreU
            // 
            this.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreU.Location = new System.Drawing.Point(335, 70);
            this.txtNombreU.Multiline = true;
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(171, 23);
            this.txtNombreU.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Clave";
            // 
            // txtNitU
            // 
            this.txtNitU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNitU.Location = new System.Drawing.Point(335, 206);
            this.txtNitU.Multiline = true;
            this.txtNitU.Name = "txtNitU";
            this.txtNitU.Size = new System.Drawing.Size(171, 23);
            this.txtNitU.TabIndex = 47;
            // 
            // txtDireccionU
            // 
            this.txtDireccionU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionU.Location = new System.Drawing.Point(335, 132);
            this.txtDireccionU.Multiline = true;
            this.txtDireccionU.Name = "txtDireccionU";
            this.txtDireccionU.Size = new System.Drawing.Size(171, 23);
            this.txtDireccionU.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Usuario";
            // 
            // txtUserU
            // 
            this.txtUserU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserU.Location = new System.Drawing.Point(121, 270);
            this.txtUserU.Multiline = true;
            this.txtUserU.Name = "txtUserU";
            this.txtUserU.Size = new System.Drawing.Size(171, 23);
            this.txtUserU.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "REGISTROS DE USUARIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "NIT";
            // 
            // txtPassU
            // 
            this.txtPassU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassU.Location = new System.Drawing.Point(335, 269);
            this.txtPassU.Multiline = true;
            this.txtPassU.Name = "txtPassU";
            this.txtPassU.PasswordChar = '*';
            this.txtPassU.Size = new System.Drawing.Size(171, 23);
            this.txtPassU.TabIndex = 45;
            // 
            // dtFechaU
            // 
            this.dtFechaU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaU.Location = new System.Drawing.Point(210, 338);
            this.dtFechaU.Name = "dtFechaU";
            this.dtFechaU.Size = new System.Drawing.Size(200, 20);
            this.dtFechaU.TabIndex = 43;
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 699);
            this.Controls.Add(this.btnNuevoU);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.btnGuardarM);
            this.Controls.Add(this.dgvUsuariosU);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuariosU;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.Button btnGuardarM;
        private System.Windows.Forms.Button btnNuevoU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDuiU;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNitU;
        private System.Windows.Forms.TextBox txtDireccionU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassU;
        private System.Windows.Forms.DateTimePicker dtFechaU;
    }
}