namespace UI
{
    partial class Bediening_Form
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
            this.btn_dranken = new System.Windows.Forms.Button();
            this.btn_lunch = new System.Windows.Forms.Button();
            this.btn_bestellingen = new System.Windows.Forms.Button();
            this.btn_diner = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_optiesbestelling = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_dranken
            // 
            this.btn_dranken.Location = new System.Drawing.Point(484, 71);
            this.btn_dranken.Name = "btn_dranken";
            this.btn_dranken.Size = new System.Drawing.Size(125, 50);
            this.btn_dranken.TabIndex = 6;
            this.btn_dranken.Text = "Dranken";
            this.btn_dranken.UseVisualStyleBackColor = true;
            this.btn_dranken.Click += new System.EventHandler(this.btn_dranken_Click);
            // 
            // btn_lunch
            // 
            this.btn_lunch.Location = new System.Drawing.Point(12, 70);
            this.btn_lunch.Name = "btn_lunch";
            this.btn_lunch.Size = new System.Drawing.Size(125, 50);
            this.btn_lunch.TabIndex = 7;
            this.btn_lunch.Text = "Lunch";
            this.btn_lunch.UseVisualStyleBackColor = true;
            this.btn_lunch.Click += new System.EventHandler(this.btn_lunch_Click);
            // 
            // btn_bestellingen
            // 
            this.btn_bestellingen.Location = new System.Drawing.Point(615, 70);
            this.btn_bestellingen.Name = "btn_bestellingen";
            this.btn_bestellingen.Size = new System.Drawing.Size(125, 50);
            this.btn_bestellingen.TabIndex = 8;
            this.btn_bestellingen.Text = "Bestellingen";
            this.btn_bestellingen.UseVisualStyleBackColor = true;
            // 
            // btn_diner
            // 
            this.btn_diner.Location = new System.Drawing.Point(143, 71);
            this.btn_diner.Name = "btn_diner";
            this.btn_diner.Size = new System.Drawing.Size(125, 50);
            this.btn_diner.TabIndex = 9;
            this.btn_diner.Text = "Diner";
            this.btn_diner.UseVisualStyleBackColor = true;
            this.btn_diner.Click += new System.EventHandler(this.btn_diner_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(0, 392);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(751, 592);
            this.pnl_main.TabIndex = 10;
            // 
            // pnl_optiesbestelling
            // 
            this.pnl_optiesbestelling.Location = new System.Drawing.Point(0, 127);
            this.pnl_optiesbestelling.Name = "pnl_optiesbestelling";
            this.pnl_optiesbestelling.Size = new System.Drawing.Size(751, 75);
            this.pnl_optiesbestelling.TabIndex = 11;
            // 
            // Bediening_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.pnl_optiesbestelling);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.btn_diner);
            this.Controls.Add(this.btn_bestellingen);
            this.Controls.Add(this.btn_lunch);
            this.Controls.Add(this.btn_dranken);
            this.Name = "Bediening_Form";
            this.Text = "Bediening";
            this.Controls.SetChildIndex(this.btn_dranken, 0);
            this.Controls.SetChildIndex(this.btn_lunch, 0);
            this.Controls.SetChildIndex(this.btn_bestellingen, 0);
            this.Controls.SetChildIndex(this.btn_diner, 0);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.Controls.SetChildIndex(this.pnl_optiesbestelling, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dranken;
        private System.Windows.Forms.Button btn_lunch;
        private System.Windows.Forms.Button btn_bestellingen;
        private System.Windows.Forms.Button btn_diner;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_optiesbestelling;
    }
}
