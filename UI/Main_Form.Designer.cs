namespace UI
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
            this.btn_LogUit = new System.Windows.Forms.Button();
            this.btn_Tafel = new System.Windows.Forms.Button();
            this.lbl_naam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LogUit
            // 
            this.btn_LogUit.BackColor = System.Drawing.Color.Silver;
            this.btn_LogUit.Location = new System.Drawing.Point(637, 7);
            this.btn_LogUit.Name = "btn_LogUit";
            this.btn_LogUit.Size = new System.Drawing.Size(103, 50);
            this.btn_LogUit.TabIndex = 0;
            this.btn_LogUit.Text = "Log uit";
            this.btn_LogUit.UseVisualStyleBackColor = false;
            this.btn_LogUit.Click += new System.EventHandler(this.btn_LogUit_Click);
            // 
            // btn_Tafel
            // 
            this.btn_Tafel.BackColor = System.Drawing.Color.Silver;
            this.btn_Tafel.Location = new System.Drawing.Point(346, 2);
            this.btn_Tafel.Name = "btn_Tafel";
            this.btn_Tafel.Size = new System.Drawing.Size(60, 60);
            this.btn_Tafel.TabIndex = 1;
            this.btn_Tafel.Text = "*TAFEL*";
            this.btn_Tafel.UseVisualStyleBackColor = false;
            this.btn_Tafel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_naam
            // 
            this.lbl_naam.AutoSize = true;
            this.lbl_naam.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_naam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_naam.Location = new System.Drawing.Point(12, 14);
            this.lbl_naam.MinimumSize = new System.Drawing.Size(150, 15);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(150, 15);
            this.lbl_naam.TabIndex = 2;
            this.lbl_naam.Text = "NAAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.MinimumSize = new System.Drawing.Size(150, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCTIE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tafel Nummer: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.lbl_naam);
            this.panel1.Controls.Add(this.btn_LogUit);
            this.panel1.Controls.Add(this.btn_Tafel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 64);
            this.panel1.TabIndex = 5;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 873);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogUit;
        private System.Windows.Forms.Button btn_Tafel;
        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}