﻿namespace OOP_IEnumerable_IEnumerator
{
    partial class Form1
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
            this.btn_TakimOyuncularınıGetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_TakimOyuncularınıGetir
            // 
            this.btn_TakimOyuncularınıGetir.Location = new System.Drawing.Point(12, 12);
            this.btn_TakimOyuncularınıGetir.Name = "btn_TakimOyuncularınıGetir";
            this.btn_TakimOyuncularınıGetir.Size = new System.Drawing.Size(118, 30);
            this.btn_TakimOyuncularınıGetir.TabIndex = 0;
            this.btn_TakimOyuncularınıGetir.Text = "Oyuncugetir";
            this.btn_TakimOyuncularınıGetir.UseVisualStyleBackColor = true;
            this.btn_TakimOyuncularınıGetir.Click += new System.EventHandler(this.btn_TakimOyuncularınıGetir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(788, 381);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_TakimOyuncularınıGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TakimOyuncularınıGetir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

