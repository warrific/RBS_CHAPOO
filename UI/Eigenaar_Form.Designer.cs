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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVoorraad = new System.Windows.Forms.TabPage();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listViewVoorraad = new System.Windows.Forms.ListView();
            this.tabPageMedewerkers = new System.Windows.Forms.TabPage();
            this.btnVerwMedw = new System.Windows.Forms.Button();
            this.btnWijzMedw = new System.Windows.Forms.Button();
            this.btnToevMedw = new System.Windows.Forms.Button();
            this.listViewMedewerkers = new System.Windows.Forms.ListView();
            this.tabPageMenukaarten = new System.Windows.Forms.TabPage();
            this.btnVerwMenukaart = new System.Windows.Forms.Button();
            this.btnWijzMenukaart = new System.Windows.Forms.Button();
            this.btnToevMenukaart = new System.Windows.Forms.Button();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPageVoorraad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageMedewerkers.SuspendLayout();
            this.tabPageMenukaarten.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVoorraad);
            this.tabControl1.Controls.Add(this.tabPageMedewerkers);
            this.tabControl1.Controls.Add(this.tabPageMenukaarten);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 678);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageVoorraad
            // 
            this.tabPageVoorraad.Controls.Add(this.btnVerlaag);
            this.tabPageVoorraad.Controls.Add(this.btnVerhoog);
            this.tabPageVoorraad.Controls.Add(this.numericUpDown1);
            this.tabPageVoorraad.Controls.Add(this.listViewVoorraad);
            this.tabPageVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageVoorraad.Location = new System.Drawing.Point(4, 54);
            this.tabPageVoorraad.Name = "tabPageVoorraad";
            this.tabPageVoorraad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoorraad.Size = new System.Drawing.Size(746, 620);
            this.tabPageVoorraad.TabIndex = 0;
            this.tabPageVoorraad.Text = "Voorraad";
            this.tabPageVoorraad.UseVisualStyleBackColor = true;
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerlaag.Location = new System.Drawing.Point(558, 155);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(178, 107);
            this.btnVerlaag.TabIndex = 16;
            this.btnVerlaag.Text = "Verlaag met aangegeven waarde";
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.btnVerlaag_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerhoog.Location = new System.Drawing.Point(558, 42);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(178, 107);
            this.btnVerhoog.TabIndex = 14;
            this.btnVerhoog.Text = "Verhoog met aangegeven waarde";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(558, 6);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(178, 30);
            this.numericUpDown1.TabIndex = 2;
            // 
            // listViewVoorraad
            // 
            this.listViewVoorraad.CheckBoxes = true;
            this.listViewVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewVoorraad.Location = new System.Drawing.Point(0, 0);
            this.listViewVoorraad.Name = "listViewVoorraad";
            this.listViewVoorraad.Size = new System.Drawing.Size(552, 527);
            this.listViewVoorraad.TabIndex = 1;
            this.listViewVoorraad.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageMedewerkers
            // 
            this.tabPageMedewerkers.Controls.Add(this.btnVerwMedw);
            this.tabPageMedewerkers.Controls.Add(this.btnWijzMedw);
            this.tabPageMedewerkers.Controls.Add(this.btnToevMedw);
            this.tabPageMedewerkers.Controls.Add(this.listViewMedewerkers);
            this.tabPageMedewerkers.Location = new System.Drawing.Point(4, 54);
            this.tabPageMedewerkers.Name = "tabPageMedewerkers";
            this.tabPageMedewerkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedewerkers.Size = new System.Drawing.Size(746, 620);
            this.tabPageMedewerkers.TabIndex = 1;
            this.tabPageMedewerkers.Text = "Medewerkers";
            this.tabPageMedewerkers.UseVisualStyleBackColor = true;
            // 
            // btnVerwMedw
            // 
            this.btnVerwMedw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwMedw.Location = new System.Drawing.Point(558, 232);
            this.btnVerwMedw.Name = "btnVerwMedw";
            this.btnVerwMedw.Size = new System.Drawing.Size(178, 107);
            this.btnVerwMedw.TabIndex = 15;
            this.btnVerwMedw.Text = "Verwijderen";
            this.btnVerwMedw.UseVisualStyleBackColor = true;
            this.btnVerwMedw.Click += new System.EventHandler(this.btnVerwMedw_Click);
            // 
            // btnWijzMedw
            // 
            this.btnWijzMedw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzMedw.Location = new System.Drawing.Point(558, 119);
            this.btnWijzMedw.Name = "btnWijzMedw";
            this.btnWijzMedw.Size = new System.Drawing.Size(178, 107);
            this.btnWijzMedw.TabIndex = 14;
            this.btnWijzMedw.Text = "Wijzigen";
            this.btnWijzMedw.UseVisualStyleBackColor = true;
            this.btnWijzMedw.Click += new System.EventHandler(this.btnWijzMedw_Click);
            // 
            // btnToevMedw
            // 
            this.btnToevMedw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevMedw.Location = new System.Drawing.Point(558, 6);
            this.btnToevMedw.Name = "btnToevMedw";
            this.btnToevMedw.Size = new System.Drawing.Size(178, 107);
            this.btnToevMedw.TabIndex = 13;
            this.btnToevMedw.Text = "Toevoegen";
            this.btnToevMedw.UseVisualStyleBackColor = true;
            this.btnToevMedw.Click += new System.EventHandler(this.btnToevMedw_Click);
            // 
            // listViewMedewerkers
            // 
            this.listViewMedewerkers.CheckBoxes = true;
            this.listViewMedewerkers.Location = new System.Drawing.Point(0, 0);
            this.listViewMedewerkers.Name = "listViewMedewerkers";
            this.listViewMedewerkers.Size = new System.Drawing.Size(552, 506);
            this.listViewMedewerkers.TabIndex = 2;
            this.listViewMedewerkers.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageMenukaarten
            // 
            this.tabPageMenukaarten.Controls.Add(this.btnVerwMenukaart);
            this.tabPageMenukaarten.Controls.Add(this.btnWijzMenukaart);
            this.tabPageMenukaarten.Controls.Add(this.btnToevMenukaart);
            this.tabPageMenukaarten.Controls.Add(this.treeViewMenu);
            this.tabPageMenukaarten.Location = new System.Drawing.Point(4, 54);
            this.tabPageMenukaarten.Name = "tabPageMenukaarten";
            this.tabPageMenukaarten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenukaarten.Size = new System.Drawing.Size(746, 620);
            this.tabPageMenukaarten.TabIndex = 2;
            this.tabPageMenukaarten.Text = "Menukaarten";
            this.tabPageMenukaarten.UseVisualStyleBackColor = true;
            // 
            // btnVerwMenukaart
            // 
            this.btnVerwMenukaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwMenukaart.Location = new System.Drawing.Point(558, 232);
            this.btnVerwMenukaart.Name = "btnVerwMenukaart";
            this.btnVerwMenukaart.Size = new System.Drawing.Size(178, 107);
            this.btnVerwMenukaart.TabIndex = 14;
            this.btnVerwMenukaart.Text = "Verwijderen";
            this.btnVerwMenukaart.UseVisualStyleBackColor = true;
            this.btnVerwMenukaart.Click += new System.EventHandler(this.btnVerwMenukaart_Click);
            // 
            // btnWijzMenukaart
            // 
            this.btnWijzMenukaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzMenukaart.Location = new System.Drawing.Point(558, 119);
            this.btnWijzMenukaart.Name = "btnWijzMenukaart";
            this.btnWijzMenukaart.Size = new System.Drawing.Size(178, 107);
            this.btnWijzMenukaart.TabIndex = 13;
            this.btnWijzMenukaart.Text = "Wijzigen";
            this.btnWijzMenukaart.UseVisualStyleBackColor = true;
            this.btnWijzMenukaart.Click += new System.EventHandler(this.btnWijzMenukaart_Click);
            // 
            // btnToevMenukaart
            // 
            this.btnToevMenukaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevMenukaart.Location = new System.Drawing.Point(558, 6);
            this.btnToevMenukaart.Name = "btnToevMenukaart";
            this.btnToevMenukaart.Size = new System.Drawing.Size(178, 107);
            this.btnToevMenukaart.TabIndex = 12;
            this.btnToevMenukaart.Text = "Toevoegen";
            this.btnToevMenukaart.UseVisualStyleBackColor = true;
            this.btnToevMenukaart.Click += new System.EventHandler(this.btnToevMenukaart_Click);
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.CheckBoxes = true;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.Size = new System.Drawing.Size(552, 494);
            this.treeViewMenu.TabIndex = 0;
            // 
            // Eigenaar_Form_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "Eigenaar_Form_v2";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPageVoorraad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageMedewerkers.ResumeLayout(false);
            this.tabPageMenukaarten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVoorraad;
        private System.Windows.Forms.TabPage tabPageMedewerkers;
        private System.Windows.Forms.TabPage tabPageMenukaarten;
        private System.Windows.Forms.ListView listViewVoorraad;
        private System.Windows.Forms.ListView listViewMedewerkers;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.Button btnToevMenukaart;
        private System.Windows.Forms.Button btnWijzMenukaart;
        private System.Windows.Forms.Button btnVerwMenukaart;
        private System.Windows.Forms.Button btnVerwMedw;
        private System.Windows.Forms.Button btnWijzMedw;
        private System.Windows.Forms.Button btnToevMedw;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnVerhoog;
    }
}
