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
            this.lbl_tafel = new System.Windows.Forms.Label();
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
            this.btn_Tafel.Location = new System.Drawing.Point(99, 2);
            this.btn_Tafel.Name = "btn_Tafel";
            this.btn_Tafel.Size = new System.Drawing.Size(60, 60);
            this.btn_Tafel.TabIndex = 1;
            this.btn_Tafel.Text = "*TAFEL*";
            this.btn_Tafel.UseVisualStyleBackColor = false;
            this.btn_Tafel.Click += new System.EventHandler(this.btn_Tafel_Click);
            // 
            // lbl_tafel
            // 
            this.lbl_tafel.AutoSize = true;
            this.lbl_tafel.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_tafel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_tafel.Location = new System.Drawing.Point(12, 26);
            this.lbl_tafel.Name = "lbl_tafel";
            this.lbl_tafel.Size = new System.Drawing.Size(81, 15);
            this.lbl_tafel.TabIndex = 4;
            this.lbl_tafel.Text = "Tafel Nummer: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.btn_LogUit);
            this.panel1.Controls.Add(this.btn_Tafel);
            this.panel1.Controls.Add(this.lbl_tafel);
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
            this.ClientSize = new System.Drawing.Size(752, 865);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogUit;
        protected System.Windows.Forms.Button btn_Tafel;
        protected System.Windows.Forms.Label lbl_tafel;
        private System.Windows.Forms.Panel panel1;
        
    }
}