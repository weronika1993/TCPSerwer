﻿namespace TCPKlient
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.button_polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(12, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(338, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(361, 14);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(439, 20);
            this.my_port.TabIndex = 1;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.ItemHeight = 24;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(12, 47);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(787, 412);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // button_polacz
            // 
            this.button_polacz.Location = new System.Drawing.Point(306, 479);
            this.button_polacz.Name = "button_polacz";
            this.button_polacz.Size = new System.Drawing.Size(218, 63);
            this.button_polacz.TabIndex = 3;
            this.button_polacz.Text = "Połącz";
            this.button_polacz.UseVisualStyleBackColor = true;
            this.button_polacz.Click += new System.EventHandler(this.button_polacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 567);
            this.Controls.Add(this.button_polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button button_polacz;
    }
}

