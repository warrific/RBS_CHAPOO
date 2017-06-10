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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewOverzicht = new System.Windows.Forms.ListView();
            this.btnVoorraad = new System.Windows.Forms.Button();
            this.btnMedewerkers = new System.Windows.Forms.Button();
            this.btnMenuKaarten = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(302, 132);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(150, 25);
            this.lblTitel.TabIndex = 7;
            this.lblTitel.Text = "Overzicht";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.listViewOverzicht);
            this.panel2.Location = new System.Drawing.Point(22, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 569);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(513, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 107);
            this.button3.TabIndex = 13;
            this.button3.Text = "Verwijderen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(513, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 107);
            this.button2.TabIndex = 12;
            this.button2.Text = "Wijzigen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 107);
            this.button1.TabIndex = 11;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listViewOverzicht
            // 
            this.listViewOverzicht.Location = new System.Drawing.Point(3, 3);
            this.listViewOverzicht.Name = "listViewOverzicht";
            this.listViewOverzicht.Size = new System.Drawing.Size(505, 563);
            this.listViewOverzicht.TabIndex = 0;
            this.listViewOverzicht.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoorraad
            // 
            this.btnVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoorraad.Location = new System.Drawing.Point(25, 70);
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
            this.btnMedewerkers.Size = new System.Drawing.Size(178, 59);
            this.btnMedewerkers.TabIndex = 9;
            this.btnMedewerkers.Text = "Medewerkers";
            this.btnMedewerkers.UseVisualStyleBackColor = true;
            this.btnMedewerkers.Click += new System.EventHandler(this.btnMedewerkers_Click);
            // 
            // btnMenuKaarten
            // 
            this.btnMenuKaarten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuKaarten.Location = new System.Drawing.Point(535, 70);
            this.btnMenuKaarten.Name = "btnMenuKaarten";
            this.btnMenuKaarten.Size = new System.Drawing.Size(178, 68);
            this.btnMenuKaarten.TabIndex = 10;
            this.btnMenuKaarten.Text = "Menukaarten";
            this.btnMenuKaarten.UseVisualStyleBackColor = true;
            this.btnMenuKaarten.Click += new System.EventHandler(this.btnMenuKaarten_Click);
            // 
            // Eigenaar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 741);
            this.Controls.Add(this.btnMenuKaarten);
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
            this.Controls.SetChildIndex(this.btnMenuKaarten, 0);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoorraad;
        private System.Windows.Forms.Button btnMedewerkers;
        private System.Windows.Forms.Button btnMenuKaarten;
        private System.Windows.Forms.ListView listViewOverzicht;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
