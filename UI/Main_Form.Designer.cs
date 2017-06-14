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
            this.lbl_tafel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LogUit
            // 
            this.btn_LogUit.BackColor = System.Drawing.Color.Silver;
            this.btn_LogUit.Location = new System.Drawing.Point(849, 9);
            this.btn_LogUit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LogUit.Name = "btn_LogUit";
            this.btn_LogUit.Size = new System.Drawing.Size(137, 62);
            this.btn_LogUit.TabIndex = 0;
            this.btn_LogUit.Text = "Log uit";
            this.btn_LogUit.UseVisualStyleBackColor = false;
            this.btn_LogUit.Click += new System.EventHandler(this.btn_LogUit_Click);
            // 
            // btn_Tafel
            // 
            this.btn_Tafel.BackColor = System.Drawing.Color.Silver;
            this.btn_Tafel.Location = new System.Drawing.Point(461, 2);
            this.btn_Tafel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Tafel.Name = "btn_Tafel";
            this.btn_Tafel.Size = new System.Drawing.Size(80, 74);
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
            this.lbl_naam.Location = new System.Drawing.Point(16, 17);
            this.lbl_naam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_naam.MinimumSize = new System.Drawing.Size(199, 18);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(199, 19);
            this.lbl_naam.TabIndex = 2;
            this.lbl_naam.Text = "NAAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(199, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCTIE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tafel
            // 
            this.lbl_tafel.AutoSize = true;
            this.lbl_tafel.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_tafel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_tafel.Location = new System.Drawing.Point(345, 32);
            this.lbl_tafel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tafel.Name = "lbl_tafel";
            this.lbl_tafel.Size = new System.Drawing.Size(107, 19);
            this.lbl_tafel.TabIndex = 4;
            this.lbl_tafel.Text = "Tafel Nummer: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.lbl_naam);
            this.panel1.Controls.Add(this.btn_LogUit);
            this.panel1.Controls.Add(this.btn_Tafel);
            this.panel1.Controls.Add(this.lbl_tafel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 79);
            this.panel1.TabIndex = 5;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 1074);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogUit;
        protected System.Windows.Forms.Button btn_Tafel;
        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lbl_tafel;
        private System.Windows.Forms.Panel panel1;
    }
}