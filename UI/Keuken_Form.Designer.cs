﻿namespace UI
{
    partial class Keuken_Form
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
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.data_dranken = new System.Windows.Forms.DataGridView();
            this.btn_herlaad = new System.Windows.Forms.Button();
            this.btn_gereed = new System.Windows.Forms.Button();
            this.btn_historie = new System.Windows.Forms.Button();
            this.lbl_historie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(602, 78);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(120, 50);
            this.btn_afrekenen.TabIndex = 7;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            this.btn_afrekenen.Click += new System.EventHandler(this.btn_gereed_Click);
            // 
            // data_dranken
            // 
            this.data_dranken.AllowUserToOrderColumns = true;
            this.data_dranken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dranken.Location = new System.Drawing.Point(22, 144);
            this.data_dranken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_dranken.Name = "data_dranken";
            this.data_dranken.RowTemplate.Height = 24;
            this.data_dranken.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dranken.Size = new System.Drawing.Size(700, 637);
            this.data_dranken.TabIndex = 9;
            // 
            // btn_herlaad
            // 
            this.btn_herlaad.Location = new System.Drawing.Point(22, 78);
            this.btn_herlaad.Name = "btn_herlaad";
            this.btn_herlaad.Size = new System.Drawing.Size(120, 50);
            this.btn_herlaad.TabIndex = 10;
            this.btn_herlaad.Text = "Herlaad";
            this.btn_herlaad.UseVisualStyleBackColor = true;
            this.btn_herlaad.Click += new System.EventHandler(this.btn_herlaad_Click);
            // 
            // btn_gereed
            // 
            this.btn_gereed.Location = new System.Drawing.Point(602, 801);
            this.btn_gereed.Name = "btn_gereed";
            this.btn_gereed.Size = new System.Drawing.Size(120, 50);
            this.btn_gereed.TabIndex = 11;
            this.btn_gereed.Text = "Gereed";
            this.btn_gereed.UseVisualStyleBackColor = true;
            this.btn_gereed.Click += new System.EventHandler(this.btn_gereed_Click);
            // 
            // btn_historie
            // 
            this.btn_historie.Location = new System.Drawing.Point(22, 801);
            this.btn_historie.Name = "btn_historie";
            this.btn_historie.Size = new System.Drawing.Size(120, 50);
            this.btn_historie.TabIndex = 12;
            this.btn_historie.Text = "Historie orders";
            this.btn_historie.UseVisualStyleBackColor = true;
            this.btn_historie.Click += new System.EventHandler(this.btn_historie_Click);
            // 
            // lbl_historie
            // 
            this.lbl_historie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historie.Location = new System.Drawing.Point(227, 88);
            this.lbl_historie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_historie.Name = "lbl_historie";
            this.lbl_historie.Size = new System.Drawing.Size(300, 32);
            this.lbl_historie.TabIndex = 13;
            this.lbl_historie.Text = "Orders";
            this.lbl_historie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Keuken_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 873);
            this.Controls.Add(this.lbl_historie);
            this.Controls.Add(this.btn_historie);
            this.Controls.Add(this.btn_gereed);
            this.Controls.Add(this.btn_herlaad);
            this.Controls.Add(this.data_dranken);
            this.Controls.Add(this.btn_afrekenen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Keuken_Form";
            this.Text = "Keuken";
            this.Controls.SetChildIndex(this.btn_afrekenen, 0);
            this.Controls.SetChildIndex(this.data_dranken, 0);
            this.Controls.SetChildIndex(this.btn_herlaad, 0);
            this.Controls.SetChildIndex(this.btn_gereed, 0);
            this.Controls.SetChildIndex(this.btn_historie, 0);
            this.Controls.SetChildIndex(this.lbl_historie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.DataGridView data_dranken;
        private System.Windows.Forms.Button btn_herlaad;
        private System.Windows.Forms.Button btn_gereed;
        private System.Windows.Forms.Button btn_historie;
        private System.Windows.Forms.Label lbl_historie;
    }
}
