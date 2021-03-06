﻿namespace UI
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.btn_LogUit = new System.Windows.Forms.Button();
            this.btn_Tafel = new System.Windows.Forms.Button();
            this.lbl_naam = new System.Windows.Forms.Label();
            this.lbl_functie = new System.Windows.Forms.Label();
            this.lbl_tafel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LogUit
            // 
            this.btn_LogUit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LogUit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogUit.Image = global::UI.Properties.Resources.logout;
            this.btn_LogUit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LogUit.Location = new System.Drawing.Point(849, 9);
            this.btn_LogUit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogUit.Name = "btn_LogUit";
            this.btn_LogUit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_LogUit.Size = new System.Drawing.Size(137, 62);
            this.btn_LogUit.TabIndex = 0;
            this.btn_LogUit.Text = "LOGOUT";
            this.btn_LogUit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogUit.UseVisualStyleBackColor = false;
            this.btn_LogUit.Click += new System.EventHandler(this.btn_LogUit_Click);
            // 
            // btn_Tafel
            // 
            this.btn_Tafel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Tafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tafel.Location = new System.Drawing.Point(87, 9);
            this.btn_Tafel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tafel.Name = "btn_Tafel";
            this.btn_Tafel.Size = new System.Drawing.Size(67, 62);
            this.btn_Tafel.TabIndex = 1;
            this.btn_Tafel.Text = "...";
            this.btn_Tafel.UseVisualStyleBackColor = false;
            this.btn_Tafel.Click += new System.EventHandler(this.btn_Tafel_Click);
            // 
            // lbl_naam
            // 
            this.lbl_naam.AutoSize = true;
            this.lbl_naam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naam.Location = new System.Drawing.Point(641, 11);
            this.lbl_naam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_naam.MaximumSize = new System.Drawing.Size(200, 31);
            this.lbl_naam.MinimumSize = new System.Drawing.Size(200, 31);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_naam.Size = new System.Drawing.Size(200, 31);
            this.lbl_naam.TabIndex = 2;
            this.lbl_naam.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_functie
            // 
            this.lbl_functie.AutoSize = true;
            this.lbl_functie.BackColor = System.Drawing.Color.Transparent;
            this.lbl_functie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_functie.Location = new System.Drawing.Point(641, 46);
            this.lbl_functie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_functie.MaximumSize = new System.Drawing.Size(200, 25);
            this.lbl_functie.MinimumSize = new System.Drawing.Size(200, 25);
            this.lbl_functie.Name = "lbl_functie";
            this.lbl_functie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_functie.Size = new System.Drawing.Size(200, 25);
            this.lbl_functie.TabIndex = 3;
            this.lbl_functie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_tafel
            // 
            this.lbl_tafel.AutoSize = true;
            this.lbl_tafel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tafel.Location = new System.Drawing.Point(16, 9);
            this.lbl_tafel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tafel.Name = "lbl_tafel";
            this.lbl_tafel.Size = new System.Drawing.Size(74, 25);
            this.lbl_tafel.TabIndex = 4;
            this.lbl_tafel.Text = "Tafel: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_naam);
            this.panel1.Controls.Add(this.btn_LogUit);
            this.panel1.Controls.Add(this.btn_Tafel);
            this.panel1.Controls.Add(this.lbl_tafel);
            this.panel1.Controls.Add(this.lbl_functie);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 79);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 1065);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "Main menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogUit;
        protected System.Windows.Forms.Button btn_Tafel;
        protected System.Windows.Forms.Label lbl_tafel;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lbl_functie;
        protected System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}