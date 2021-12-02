
using System;

namespace AppCalculator
{
    partial class Calculator
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
            this.btnproses = new System.Windows.Forms.Button();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.operasi = new System.Windows.Forms.Label();
            this.nilaix = new System.Windows.Forms.Label();
            this.nilaiy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnproses
            // 
            this.btnproses.Location = new System.Drawing.Point(274, 234);
            this.btnproses.Name = "btnproses";
            this.btnproses.Size = new System.Drawing.Size(75, 23);
            this.btnproses.TabIndex = 0;
            this.btnproses.Text = "Proses";
            this.btnproses.UseVisualStyleBackColor = true;
            this.btnproses.Click += new System.EventHandler(this.btnproses_Click);
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(104, 23);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(173, 24);
            this.cmbOperasi.TabIndex = 1;
            
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(104, 64);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(173, 22);
            this.txbX.TabIndex = 2;
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(104, 108);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(173, 22);
            this.txbY.TabIndex = 3;
            // 
            // operasi
            // 
            this.operasi.AutoSize = true;
            this.operasi.Location = new System.Drawing.Point(12, 26);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(58, 17);
            this.operasi.TabIndex = 4;
            this.operasi.Text = "Operasi";
            this.operasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // nilaix
            // 
            this.nilaix.AutoSize = true;
            this.nilaix.Location = new System.Drawing.Point(12, 67);
            this.nilaix.Name = "nilaix";
            this.nilaix.Size = new System.Drawing.Size(48, 17);
            this.nilaix.TabIndex = 5;
            this.nilaix.Text = "Nilai X";
            // 
            // nilaiy
            // 
            this.nilaiy.AutoSize = true;
            this.nilaiy.Location = new System.Drawing.Point(12, 111);
            this.nilaiy.Name = "nilaiy";
            this.nilaiy.Size = new System.Drawing.Size(48, 17);
            this.nilaiy.TabIndex = 6;
            this.nilaiy.Text = "Nilai Y";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 269);
            this.Controls.Add(this.nilaiy);
            this.Controls.Add(this.nilaix);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.btnproses);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button btnproses;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label operasi;
        private System.Windows.Forms.Label nilaix;
        private System.Windows.Forms.Label nilaiy;
    }
}