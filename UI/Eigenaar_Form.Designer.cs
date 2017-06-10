namespace UI
{
    partial class Eigenaar_Form
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoorraad = new System.Windows.Forms.Button();
            this.btnMedewerkers = new System.Windows.Forms.Button();
            this.btnMenuItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(300, 122);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(150, 25);
            this.lblTitel.TabIndex = 7;
            this.lblTitel.Text = "Voorraad";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(22, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 569);
            this.panel2.TabIndex = 6;
            // 
            // btnVoorraad
            // 
            this.btnVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoorraad.Location = new System.Drawing.Point(22, 70);
            this.btnVoorraad.Name = "btnVoorraad";
            this.btnVoorraad.Size = new System.Drawing.Size(174, 68);
            this.btnVoorraad.TabIndex = 8;
            this.btnVoorraad.Text = "Voorraad";
            this.btnVoorraad.UseVisualStyleBackColor = true;
            this.btnVoorraad.Click += new System.EventHandler(this.btnVoorraad_Click);
            // 
            // btnMedewerkers
            // 
            this.btnMedewerkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedewerkers.Location = new System.Drawing.Point(287, 70);
            this.btnMedewerkers.Name = "btnMedewerkers";
            this.btnMedewerkers.Size = new System.Drawing.Size(178, 38);
            this.btnMedewerkers.TabIndex = 9;
            this.btnMedewerkers.Text = "Medewerkers";
            this.btnMedewerkers.UseVisualStyleBackColor = true;
            this.btnMedewerkers.Click += new System.EventHandler(this.btnMedewerkers_Click);
            // 
            // btnMenuItems
            // 
            this.btnMenuItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItems.Location = new System.Drawing.Point(538, 70);
            this.btnMenuItems.Name = "btnMenuItems";
            this.btnMenuItems.Size = new System.Drawing.Size(178, 68);
            this.btnMenuItems.TabIndex = 10;
            this.btnMenuItems.Text = "Menukaarten";
            this.btnMenuItems.UseVisualStyleBackColor = true;
            this.btnMenuItems.Click += new System.EventHandler(this.btnMenuItems_Click);
            // 
            // Eigenaar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 741);
            this.Controls.Add(this.btnMenuItems);
            this.Controls.Add(this.btnMedewerkers);
            this.Controls.Add(this.btnVoorraad);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.panel2);
            this.Name = "Eigenaar_Form";
            this.Text = "Eigenaar_Form";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblTitel, 0);
            this.Controls.SetChildIndex(this.btnVoorraad, 0);
            this.Controls.SetChildIndex(this.btnMedewerkers, 0);
            this.Controls.SetChildIndex(this.btnMenuItems, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoorraad;
        private System.Windows.Forms.Button btnMedewerkers;
        private System.Windows.Forms.Button btnMenuItems;
    }
}
