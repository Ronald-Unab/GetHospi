namespace GetHospi.Vista
{
    partial class FrmRegistroDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroDiagnostico));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGuardarD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnActualizarD = new System.Windows.Forms.Button();
            this.btnNuevoD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recetas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(244, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(31, 223);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(244, 223);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 27);
            this.textBox3.TabIndex = 6;
            // 
            // btnGuardarD
            // 
            this.btnGuardarD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarD.FlatAppearance.BorderSize = 2;
            this.btnGuardarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarD.Location = new System.Drawing.Point(137, 475);
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(93, 32);
            this.btnGuardarD.TabIndex = 14;
            this.btnGuardarD.Text = "Guardar";
            this.btnGuardarD.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 184);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarD.FlatAppearance.BorderSize = 2;
            this.btnEliminarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarD.Location = new System.Drawing.Point(341, 475);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(93, 32);
            this.btnEliminarD.TabIndex = 16;
            this.btnEliminarD.Text = "Eliminar";
            this.btnEliminarD.UseVisualStyleBackColor = false;
            // 
            // btnActualizarD
            // 
            this.btnActualizarD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnActualizarD.FlatAppearance.BorderSize = 2;
            this.btnActualizarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarD.Location = new System.Drawing.Point(240, 475);
            this.btnActualizarD.Name = "btnActualizarD";
            this.btnActualizarD.Size = new System.Drawing.Size(93, 32);
            this.btnActualizarD.TabIndex = 17;
            this.btnActualizarD.Text = "Actualizar";
            this.btnActualizarD.UseVisualStyleBackColor = false;
            // 
            // btnNuevoD
            // 
            this.btnNuevoD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoD.FlatAppearance.BorderSize = 2;
            this.btnNuevoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoD.Location = new System.Drawing.Point(31, 475);
            this.btnNuevoD.Name = "btnNuevoD";
            this.btnNuevoD.Size = new System.Drawing.Size(93, 32);
            this.btnNuevoD.TabIndex = 18;
            this.btnNuevoD.Text = "Nuevo";
            this.btnNuevoD.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "REGISTROS DE DIAGNOSTICO";
            // 
            // FrmRegistroDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevoD);
            this.Controls.Add(this.btnActualizarD);
            this.Controls.Add(this.btnEliminarD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardarD);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroDiagnostico";
            this.Text = "Registro Diagnostico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGuardarD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarD;
        private System.Windows.Forms.Button btnActualizarD;
        private System.Windows.Forms.Button btnNuevoD;
        private System.Windows.Forms.Label label5;
    }
}