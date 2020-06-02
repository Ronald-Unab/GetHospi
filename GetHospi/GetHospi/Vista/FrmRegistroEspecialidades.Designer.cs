namespace GetHospi.Vista
{
    partial class FrmRegistroEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEspecialidades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.btnGuardarM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(212, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(212, 152);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "REGISTROS DE ESPECIALIDADES\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 206);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnNuevoM
            // 
            this.btnNuevoM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoM.FlatAppearance.BorderSize = 2;
            this.btnNuevoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoM.Location = new System.Drawing.Point(38, 422);
            this.btnNuevoM.Name = "btnNuevoM";
            this.btnNuevoM.Size = new System.Drawing.Size(70, 34);
            this.btnNuevoM.TabIndex = 25;
            this.btnNuevoM.Text = "Nuevo";
            this.btnNuevoM.UseVisualStyleBackColor = false;
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarM.FlatAppearance.BorderSize = 2;
            this.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(309, 422);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(80, 34);
            this.btnEliminarM.TabIndex = 24;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = false;
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizarM.FlatAppearance.BorderSize = 2;
            this.btnActualizarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarM.Location = new System.Drawing.Point(212, 422);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(89, 34);
            this.btnActualizarM.TabIndex = 23;
            this.btnActualizarM.Text = "Actualizar";
            this.btnActualizarM.UseVisualStyleBackColor = false;
            // 
            // btnGuardarM
            // 
            this.btnGuardarM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarM.FlatAppearance.BorderSize = 2;
            this.btnGuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarM.Location = new System.Drawing.Point(123, 422);
            this.btnGuardarM.Name = "btnGuardarM";
            this.btnGuardarM.Size = new System.Drawing.Size(76, 34);
            this.btnGuardarM.TabIndex = 22;
            this.btnGuardarM.Text = "Guardar";
            this.btnGuardarM.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 509);
            this.Controls.Add(this.btnNuevoM);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.btnGuardarM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroEspecialidades";
            this.Text = "Registro Especialidades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.Button btnGuardarM;
    }
}