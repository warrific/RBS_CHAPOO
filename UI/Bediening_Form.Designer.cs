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
            this.pnl_optiesbestelling = new System.Windows.Forms.Panel();
            this.flowLP_MenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.listView_Bestelling = new System.Windows.Forms.ListView();
            this.columnHeader_Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Bedrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Verstuur = new System.Windows.Forms.Button();
            this.columnHeader_opmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.lbl_VoorraadOp = new System.Windows.Forms.Label();
            this.btn_verwijderHuidigeBestelling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dranken
            // 
            this.btn_dranken.Location = new System.Drawing.Point(281, 71);
            this.btn_dranken.Name = "btn_dranken";
            this.btn_dranken.Size = new System.Drawing.Size(125, 50);
            this.btn_dranken.TabIndex = 6;
            this.btn_dranken.Tag = "dranken";
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
            this.btn_lunch.Tag = "lunch";
            this.btn_lunch.Text = "Lunch";
            this.btn_lunch.UseVisualStyleBackColor = true;
            this.btn_lunch.Click += new System.EventHandler(this.btn_lunch_Click);
            // 
            // btn_bestellingen
            // 
            this.btn_bestellingen.Location = new System.Drawing.Point(615, 71);
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
            this.btn_diner.Tag = "diner";
            this.btn_diner.Text = "Diner";
            this.btn_diner.UseVisualStyleBackColor = true;
            this.btn_diner.Click += new System.EventHandler(this.btn_diner_Click);
            // 
            // pnl_optiesbestelling
            // 
            this.pnl_optiesbestelling.Location = new System.Drawing.Point(0, 127);
            this.pnl_optiesbestelling.Name = "pnl_optiesbestelling";
            this.pnl_optiesbestelling.Size = new System.Drawing.Size(751, 62);
            this.pnl_optiesbestelling.TabIndex = 11;
            // 
            // flowLP_MenuItems
            // 
            this.flowLP_MenuItems.Location = new System.Drawing.Point(0, 195);
            this.flowLP_MenuItems.Name = "flowLP_MenuItems";
            this.flowLP_MenuItems.Size = new System.Drawing.Size(751, 191);
            this.flowLP_MenuItems.TabIndex = 12;
            // 
            // listView_Bestelling
            // 
            this.listView_Bestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Naam,
            this.columnHeader_Aantal,
            this.columnHeader_Bedrag,
            this.columnHeader_opmerking});
            this.listView_Bestelling.FullRowSelect = true;
            this.listView_Bestelling.GridLines = true;
            this.listView_Bestelling.Location = new System.Drawing.Point(0, 386);
            this.listView_Bestelling.Name = "listView_Bestelling";
            this.listView_Bestelling.Size = new System.Drawing.Size(524, 602);
            this.listView_Bestelling.TabIndex = 13;
            this.listView_Bestelling.UseCompatibleStateImageBehavior = false;
            this.listView_Bestelling.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Naam
            // 
            this.columnHeader_Naam.Text = "Naam";
            this.columnHeader_Naam.Width = 200;
            // 
            // columnHeader_Aantal
            // 
            this.columnHeader_Aantal.Text = "Aantal";
            // 
            // columnHeader_Bedrag
            // 
            this.columnHeader_Bedrag.Text = "Bedrag";
            // 
            // btn_Verstuur
            // 
            this.btn_Verstuur.Location = new System.Drawing.Point(608, 853);
            this.btn_Verstuur.Name = "btn_Verstuur";
            this.btn_Verstuur.Size = new System.Drawing.Size(132, 57);
            this.btn_Verstuur.TabIndex = 14;
            this.btn_Verstuur.Text = "Verstuur";
            this.btn_Verstuur.UseVisualStyleBackColor = true;
            this.btn_Verstuur.Click += new System.EventHandler(this.btn_Verstuur_Click);
            // 
            // columnHeader_opmerking
            // 
            this.columnHeader_opmerking.Text = "Opmerking";
            this.columnHeader_opmerking.Width = 200;
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(608, 916);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(132, 57);
            this.btn_afrekenen.TabIndex = 15;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            this.btn_afrekenen.Click += new System.EventHandler(this.btn_afrekenen_Click);
            // 
            // lbl_VoorraadOp
            // 
            this.lbl_VoorraadOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VoorraadOp.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_VoorraadOp.Location = new System.Drawing.Point(531, 393);
            this.lbl_VoorraadOp.Name = "lbl_VoorraadOp";
            this.lbl_VoorraadOp.Size = new System.Drawing.Size(200, 200);
            this.lbl_VoorraadOp.TabIndex = 16;
            this.lbl_VoorraadOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_verwijderHuidigeBestelling
            // 
            this.btn_verwijderHuidigeBestelling.Location = new System.Drawing.Point(608, 786);
            this.btn_verwijderHuidigeBestelling.Name = "btn_verwijderHuidigeBestelling";
            this.btn_verwijderHuidigeBestelling.Size = new System.Drawing.Size(132, 61);
            this.btn_verwijderHuidigeBestelling.TabIndex = 17;
            this.btn_verwijderHuidigeBestelling.Text = "Verwijder huidige bestelling";
            this.btn_verwijderHuidigeBestelling.UseVisualStyleBackColor = true;
            this.btn_verwijderHuidigeBestelling.Click += new System.EventHandler(this.btn_verwijderHuidigeBestelling_Click);
            // 
            // Bediening_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.btn_verwijderHuidigeBestelling);
            this.Controls.Add(this.lbl_VoorraadOp);
            this.Controls.Add(this.btn_afrekenen);
            this.Controls.Add(this.btn_Verstuur);
            this.Controls.Add(this.listView_Bestelling);
            this.Controls.Add(this.flowLP_MenuItems);
            this.Controls.Add(this.pnl_optiesbestelling);
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
            this.Controls.SetChildIndex(this.pnl_optiesbestelling, 0);
            this.Controls.SetChildIndex(this.flowLP_MenuItems, 0);
            this.Controls.SetChildIndex(this.listView_Bestelling, 0);
            this.Controls.SetChildIndex(this.btn_Verstuur, 0);
            this.Controls.SetChildIndex(this.btn_afrekenen, 0);
            this.Controls.SetChildIndex(this.lbl_VoorraadOp, 0);
            this.Controls.SetChildIndex(this.btn_verwijderHuidigeBestelling, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dranken;
        private System.Windows.Forms.Button btn_lunch;
        private System.Windows.Forms.Button btn_bestellingen;
        private System.Windows.Forms.Button btn_diner;
        private System.Windows.Forms.Panel pnl_optiesbestelling;
        private System.Windows.Forms.FlowLayoutPanel flowLP_MenuItems;
        private System.Windows.Forms.ListView listView_Bestelling;
        private System.Windows.Forms.ColumnHeader columnHeader_Naam;
        private System.Windows.Forms.ColumnHeader columnHeader_Aantal;
        private System.Windows.Forms.ColumnHeader columnHeader_Bedrag;
        private System.Windows.Forms.Button btn_Verstuur;
        private System.Windows.Forms.ColumnHeader columnHeader_opmerking;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.Label lbl_VoorraadOp;
        private System.Windows.Forms.Button btn_verwijderHuidigeBestelling;
    }
}
