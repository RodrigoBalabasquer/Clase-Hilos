﻿namespace Pelotitas
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.btnDestruir = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(242, 467);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(117, 23);
            this.btnReanudar.TabIndex = 11;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(406, 467);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(117, 23);
            this.btnDestruir.TabIndex = 10;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(566, 467);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(117, 23);
            this.btnPausar.TabIndex = 9;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(85, 467);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(117, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear Pelotita";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 436);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReanudar;
        private System.Windows.Forms.Button btnDestruir;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}