﻿namespace UI
{
    partial class Bar_Form
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
            this.btn_bestellingen = new System.Windows.Forms.Button();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.list_drankorders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_bestellingen
            // 
            this.btn_bestellingen.Location = new System.Drawing.Point(11, 70);
            this.btn_bestellingen.Name = "btn_bestellingen";
            this.btn_bestellingen.Size = new System.Drawing.Size(120, 50);
            this.btn_bestellingen.TabIndex = 6;
            this.btn_bestellingen.Text = "Bestellingen";
            this.btn_bestellingen.UseVisualStyleBackColor = true;
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(617, 70);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(120, 50);
            this.btn_afrekenen.TabIndex = 7;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            // 
            // list_drankorders
            // 
            this.list_drankorders.Location = new System.Drawing.Point(12, 136);
            this.list_drankorders.Name = "list_drankorders";
            this.list_drankorders.Size = new System.Drawing.Size(725, 725);
            this.list_drankorders.TabIndex = 8;
            this.list_drankorders.UseCompatibleStateImageBehavior = false;
            // 
            // Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 873);
            this.Controls.Add(this.list_drankorders);
            this.Controls.Add(this.btn_afrekenen);
            this.Controls.Add(this.btn_bestellingen);
            this.Name = "Bar_Form";
            this.Text = "Bar";
            this.Controls.SetChildIndex(this.btn_bestellingen, 0);
            this.Controls.SetChildIndex(this.btn_afrekenen, 0);
            this.Controls.SetChildIndex(this.list_drankorders, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bestellingen;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.ListView list_drankorders;
    }
}