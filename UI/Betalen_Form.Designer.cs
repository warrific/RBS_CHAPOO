namespace UI
{
    partial class Betalen_Form
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
            this.Tafel_lbl = new System.Windows.Forms.Label();
            this.Medewerker_lbl = new System.Windows.Forms.Label();
            this.Datum_lbl = new System.Windows.Forms.Label();
            this.Datagrid_items_bestelling = new System.Windows.Forms.DataGridView();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fooi_lbl = new System.Windows.Forms.Label();
            this.Betaalwijze_lbl = new System.Windows.Forms.Label();
            this.Btw_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Betaalwijze_pin_btn = new System.Windows.Forms.Button();
            this.Betaalwijze_contant_btn = new System.Windows.Forms.Button();
            this.Betaalwijze_credit_btn = new System.Windows.Forms.Button();
            this.Betaalwijze_header_lbl = new System.Windows.Forms.Label();
            this.Opmerking_header_lbl = new System.Windows.Forms.Label();
            this.Opmerking_txtbox = new System.Windows.Forms.RichTextBox();
            this.Fooi_header_lbl = new System.Windows.Forms.Label();
            this.Fooi_textbox = new System.Windows.Forms.RichTextBox();
            this.Fooi_btn_2 = new System.Windows.Forms.Button();
            this.Fooi_btn_3 = new System.Windows.Forms.Button();
            this.Fooi_btn_4 = new System.Windows.Forms.Button();
            this.Fooi_btn_5 = new System.Windows.Forms.Button();
            this.Fooi_btn_6 = new System.Windows.Forms.Button();
            this.Fooi_btn_7 = new System.Windows.Forms.Button();
            this.Fooi_btn_8 = new System.Windows.Forms.Button();
            this.Fooi_btn_9 = new System.Windows.Forms.Button();
            this.Fooi_btn_backspace = new System.Windows.Forms.Button();
            this.Fooi_btn_0 = new System.Windows.Forms.Button();
            this.Fooi_btn_enter = new System.Windows.Forms.Button();
            this.Opmerking_add_btn = new System.Windows.Forms.Button();
            this.Fooi_btn_komma = new System.Windows.Forms.Button();
            this.Tafel_out_lbl = new System.Windows.Forms.Label();
            this.medewerker_out_lbl = new System.Windows.Forms.Label();
            this.Datum_out_lbl = new System.Windows.Forms.Label();
            this.Fooi_out_lbl = new System.Windows.Forms.Label();
            this.Betaalwijze_out_lbl = new System.Windows.Forms.Label();
            this.Btw_out_lbl = new System.Windows.Forms.Label();
            this.Totaal_out_lbl = new System.Windows.Forms.Label();
            this.Fooi_btn_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_items_bestelling)).BeginInit();
            this.SuspendLayout();
            // 
            // Tafel_lbl
            // 
            this.Tafel_lbl.AutoSize = true;
            this.Tafel_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tafel_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Tafel_lbl.Location = new System.Drawing.Point(66, 84);
            this.Tafel_lbl.Name = "Tafel_lbl";
            this.Tafel_lbl.Size = new System.Drawing.Size(48, 20);
            this.Tafel_lbl.TabIndex = 6;
            this.Tafel_lbl.Text = "Tafel:";
            // 
            // Medewerker_lbl
            // 
            this.Medewerker_lbl.AutoSize = true;
            this.Medewerker_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Medewerker_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Medewerker_lbl.Location = new System.Drawing.Point(13, 110);
            this.Medewerker_lbl.Name = "Medewerker_lbl";
            this.Medewerker_lbl.Size = new System.Drawing.Size(100, 20);
            this.Medewerker_lbl.TabIndex = 7;
            this.Medewerker_lbl.Text = "Medewerker:";
            // 
            // Datum_lbl
            // 
            this.Datum_lbl.AutoSize = true;
            this.Datum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Datum_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Datum_lbl.Location = new System.Drawing.Point(49, 139);
            this.Datum_lbl.Name = "Datum_lbl";
            this.Datum_lbl.Size = new System.Drawing.Size(61, 20);
            this.Datum_lbl.TabIndex = 8;
            this.Datum_lbl.Text = "Datum:";
            // 
            // Datagrid_items_bestelling
            // 
            this.Datagrid_items_bestelling.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Datagrid_items_bestelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_items_bestelling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Datagrid_items_bestelling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_items_bestelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_items_bestelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aantal,
            this.Naam,
            this.Prijs});
            this.Datagrid_items_bestelling.GridColor = System.Drawing.Color.DarkSlateGray;
            this.Datagrid_items_bestelling.Location = new System.Drawing.Point(0, 174);
            this.Datagrid_items_bestelling.Name = "Datagrid_items_bestelling";
            this.Datagrid_items_bestelling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_items_bestelling.RowHeadersVisible = false;
            this.Datagrid_items_bestelling.Size = new System.Drawing.Size(383, 669);
            this.Datagrid_items_bestelling.TabIndex = 9;
            // 
            // Aantal
            // 
            this.Aantal.FillWeight = 70F;
            this.Aantal.HeaderText = "aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            this.Aantal.Width = 40;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "naam";
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Width = 300;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "prijs";
            this.Prijs.Name = "Prijs";
            this.Prijs.Width = 40;
            // 
            // Fooi_lbl
            // 
            this.Fooi_lbl.AutoSize = true;
            this.Fooi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fooi_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Fooi_lbl.Location = new System.Drawing.Point(66, 864);
            this.Fooi_lbl.Name = "Fooi_lbl";
            this.Fooi_lbl.Size = new System.Drawing.Size(44, 20);
            this.Fooi_lbl.TabIndex = 10;
            this.Fooi_lbl.Text = "Fooi:";
            // 
            // Betaalwijze_lbl
            // 
            this.Betaalwijze_lbl.AutoSize = true;
            this.Betaalwijze_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Betaalwijze_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Betaalwijze_lbl.Location = new System.Drawing.Point(17, 890);
            this.Betaalwijze_lbl.Name = "Betaalwijze_lbl";
            this.Betaalwijze_lbl.Size = new System.Drawing.Size(93, 20);
            this.Betaalwijze_lbl.TabIndex = 11;
            this.Betaalwijze_lbl.Text = "Betaalwijze:";
            // 
            // Btw_lbl
            // 
            this.Btw_lbl.AutoSize = true;
            this.Btw_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btw_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Btw_lbl.Location = new System.Drawing.Point(70, 918);
            this.Btw_lbl.Name = "Btw_lbl";
            this.Btw_lbl.Size = new System.Drawing.Size(40, 20);
            this.Btw_lbl.TabIndex = 12;
            this.Btw_lbl.Text = "Btw:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1, 941);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Totaalprijs:";
            // 
            // Betaalwijze_pin_btn
            // 
            this.Betaalwijze_pin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betaalwijze_pin_btn.Location = new System.Drawing.Point(422, 118);
            this.Betaalwijze_pin_btn.Name = "Betaalwijze_pin_btn";
            this.Betaalwijze_pin_btn.Size = new System.Drawing.Size(75, 75);
            this.Betaalwijze_pin_btn.TabIndex = 14;
            this.Betaalwijze_pin_btn.Text = "PIN";
            this.Betaalwijze_pin_btn.UseVisualStyleBackColor = true;
            this.Betaalwijze_pin_btn.Click += new System.EventHandler(this.Betaalwijze_pin_btn_Click);
            // 
            // Betaalwijze_contant_btn
            // 
            this.Betaalwijze_contant_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betaalwijze_contant_btn.Location = new System.Drawing.Point(503, 118);
            this.Betaalwijze_contant_btn.Name = "Betaalwijze_contant_btn";
            this.Betaalwijze_contant_btn.Size = new System.Drawing.Size(75, 75);
            this.Betaalwijze_contant_btn.TabIndex = 15;
            this.Betaalwijze_contant_btn.Text = "CONTANT";
            this.Betaalwijze_contant_btn.UseVisualStyleBackColor = true;
            this.Betaalwijze_contant_btn.Click += new System.EventHandler(this.Betaalwijze_contant_btn_Click);
            // 
            // Betaalwijze_credit_btn
            // 
            this.Betaalwijze_credit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betaalwijze_credit_btn.Location = new System.Drawing.Point(584, 118);
            this.Betaalwijze_credit_btn.Name = "Betaalwijze_credit_btn";
            this.Betaalwijze_credit_btn.Size = new System.Drawing.Size(75, 75);
            this.Betaalwijze_credit_btn.TabIndex = 16;
            this.Betaalwijze_credit_btn.Text = "CREDIT CARD";
            this.Betaalwijze_credit_btn.UseVisualStyleBackColor = true;
            this.Betaalwijze_credit_btn.Click += new System.EventHandler(this.Betaalwijze_credit_btn_Click);
            // 
            // Betaalwijze_header_lbl
            // 
            this.Betaalwijze_header_lbl.AutoSize = true;
            this.Betaalwijze_header_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Betaalwijze_header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betaalwijze_header_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Betaalwijze_header_lbl.Location = new System.Drawing.Point(418, 73);
            this.Betaalwijze_header_lbl.Name = "Betaalwijze_header_lbl";
            this.Betaalwijze_header_lbl.Size = new System.Drawing.Size(120, 24);
            this.Betaalwijze_header_lbl.TabIndex = 17;
            this.Betaalwijze_header_lbl.Text = "Betaalwijze:";
            // 
            // Opmerking_header_lbl
            // 
            this.Opmerking_header_lbl.AutoSize = true;
            this.Opmerking_header_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Opmerking_header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opmerking_header_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Opmerking_header_lbl.Location = new System.Drawing.Point(417, 647);
            this.Opmerking_header_lbl.Name = "Opmerking_header_lbl";
            this.Opmerking_header_lbl.Size = new System.Drawing.Size(119, 24);
            this.Opmerking_header_lbl.TabIndex = 18;
            this.Opmerking_header_lbl.Text = "Opmerking:";
            // 
            // Opmerking_txtbox
            // 
            this.Opmerking_txtbox.Location = new System.Drawing.Point(421, 684);
            this.Opmerking_txtbox.Name = "Opmerking_txtbox";
            this.Opmerking_txtbox.Size = new System.Drawing.Size(318, 140);
            this.Opmerking_txtbox.TabIndex = 19;
            this.Opmerking_txtbox.Text = "";
            // 
            // Fooi_header_lbl
            // 
            this.Fooi_header_lbl.AutoSize = true;
            this.Fooi_header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_header_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Fooi_header_lbl.Location = new System.Drawing.Point(418, 231);
            this.Fooi_header_lbl.Name = "Fooi_header_lbl";
            this.Fooi_header_lbl.Size = new System.Drawing.Size(58, 24);
            this.Fooi_header_lbl.TabIndex = 20;
            this.Fooi_header_lbl.Text = "Fooi:";
            // 
            // Fooi_textbox
            // 
            this.Fooi_textbox.Location = new System.Drawing.Point(422, 258);
            this.Fooi_textbox.Name = "Fooi_textbox";
            this.Fooi_textbox.Size = new System.Drawing.Size(317, 45);
            this.Fooi_textbox.TabIndex = 21;
            this.Fooi_textbox.Text = "";
            // 
            // Fooi_btn_2
            // 
            this.Fooi_btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Fooi_btn_2.Location = new System.Drawing.Point(502, 309);
            this.Fooi_btn_2.Name = "Fooi_btn_2";
            this.Fooi_btn_2.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_2.TabIndex = 23;
            this.Fooi_btn_2.Text = "2";
            this.Fooi_btn_2.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_3
            // 
            this.Fooi_btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_3.Location = new System.Drawing.Point(583, 309);
            this.Fooi_btn_3.Name = "Fooi_btn_3";
            this.Fooi_btn_3.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_3.TabIndex = 24;
            this.Fooi_btn_3.Text = "3";
            this.Fooi_btn_3.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_4
            // 
            this.Fooi_btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Fooi_btn_4.Location = new System.Drawing.Point(422, 390);
            this.Fooi_btn_4.Name = "Fooi_btn_4";
            this.Fooi_btn_4.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_4.TabIndex = 25;
            this.Fooi_btn_4.Text = "4";
            this.Fooi_btn_4.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_5
            // 
            this.Fooi_btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_5.Location = new System.Drawing.Point(503, 390);
            this.Fooi_btn_5.Name = "Fooi_btn_5";
            this.Fooi_btn_5.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_5.TabIndex = 26;
            this.Fooi_btn_5.Text = "5";
            this.Fooi_btn_5.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_6
            // 
            this.Fooi_btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Fooi_btn_6.Location = new System.Drawing.Point(584, 390);
            this.Fooi_btn_6.Name = "Fooi_btn_6";
            this.Fooi_btn_6.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_6.TabIndex = 27;
            this.Fooi_btn_6.Text = "6";
            this.Fooi_btn_6.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_7
            // 
            this.Fooi_btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Fooi_btn_7.Location = new System.Drawing.Point(421, 471);
            this.Fooi_btn_7.Name = "Fooi_btn_7";
            this.Fooi_btn_7.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_7.TabIndex = 28;
            this.Fooi_btn_7.Text = "7";
            this.Fooi_btn_7.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_8
            // 
            this.Fooi_btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_8.Location = new System.Drawing.Point(502, 471);
            this.Fooi_btn_8.Name = "Fooi_btn_8";
            this.Fooi_btn_8.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_8.TabIndex = 29;
            this.Fooi_btn_8.Text = "8";
            this.Fooi_btn_8.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_9
            // 
            this.Fooi_btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_9.Location = new System.Drawing.Point(583, 471);
            this.Fooi_btn_9.Name = "Fooi_btn_9";
            this.Fooi_btn_9.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_9.TabIndex = 30;
            this.Fooi_btn_9.Text = "9";
            this.Fooi_btn_9.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_backspace
            // 
            this.Fooi_btn_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_backspace.Location = new System.Drawing.Point(421, 552);
            this.Fooi_btn_backspace.Name = "Fooi_btn_backspace";
            this.Fooi_btn_backspace.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_backspace.TabIndex = 31;
            this.Fooi_btn_backspace.Text = "BACK";
            this.Fooi_btn_backspace.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_0
            // 
            this.Fooi_btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_0.Location = new System.Drawing.Point(502, 552);
            this.Fooi_btn_0.Name = "Fooi_btn_0";
            this.Fooi_btn_0.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_0.TabIndex = 32;
            this.Fooi_btn_0.Text = "0";
            this.Fooi_btn_0.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_enter
            // 
            this.Fooi_btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_enter.Location = new System.Drawing.Point(583, 552);
            this.Fooi_btn_enter.Name = "Fooi_btn_enter";
            this.Fooi_btn_enter.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_enter.TabIndex = 33;
            this.Fooi_btn_enter.Text = "ENT";
            this.Fooi_btn_enter.UseVisualStyleBackColor = true;
            // 
            // Opmerking_add_btn
            // 
            this.Opmerking_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opmerking_add_btn.Location = new System.Drawing.Point(636, 830);
            this.Opmerking_add_btn.Name = "Opmerking_add_btn";
            this.Opmerking_add_btn.Size = new System.Drawing.Size(103, 48);
            this.Opmerking_add_btn.TabIndex = 34;
            this.Opmerking_add_btn.Text = "Toevoegen";
            this.Opmerking_add_btn.UseVisualStyleBackColor = true;
            // 
            // Fooi_btn_komma
            // 
            this.Fooi_btn_komma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_btn_komma.Location = new System.Drawing.Point(664, 309);
            this.Fooi_btn_komma.Name = "Fooi_btn_komma";
            this.Fooi_btn_komma.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_komma.TabIndex = 35;
            this.Fooi_btn_komma.Text = ",";
            this.Fooi_btn_komma.UseVisualStyleBackColor = true;
            // 
            // Tafel_out_lbl
            // 
            this.Tafel_out_lbl.AutoSize = true;
            this.Tafel_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tafel_out_lbl.Location = new System.Drawing.Point(121, 90);
            this.Tafel_out_lbl.Name = "Tafel_out_lbl";
            this.Tafel_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.Tafel_out_lbl.TabIndex = 36;
            // 
            // medewerker_out_lbl
            // 
            this.medewerker_out_lbl.AutoSize = true;
            this.medewerker_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medewerker_out_lbl.Location = new System.Drawing.Point(119, 104);
            this.medewerker_out_lbl.Name = "medewerker_out_lbl";
            this.medewerker_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.medewerker_out_lbl.TabIndex = 37;
            // 
            // Datum_out_lbl
            // 
            this.Datum_out_lbl.AutoSize = true;
            this.Datum_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datum_out_lbl.Location = new System.Drawing.Point(120, 130);
            this.Datum_out_lbl.Name = "Datum_out_lbl";
            this.Datum_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.Datum_out_lbl.TabIndex = 38;
            // 
            // Fooi_out_lbl
            // 
            this.Fooi_out_lbl.AutoSize = true;
            this.Fooi_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fooi_out_lbl.Location = new System.Drawing.Point(123, 870);
            this.Fooi_out_lbl.Name = "Fooi_out_lbl";
            this.Fooi_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.Fooi_out_lbl.TabIndex = 39;
            // 
            // Betaalwijze_out_lbl
            // 
            this.Betaalwijze_out_lbl.AutoSize = true;
            this.Betaalwijze_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betaalwijze_out_lbl.Location = new System.Drawing.Point(117, 894);
            this.Betaalwijze_out_lbl.Name = "Betaalwijze_out_lbl";
            this.Betaalwijze_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.Betaalwijze_out_lbl.TabIndex = 40;
            // 
            // Btw_out_lbl
            // 
            this.Btw_out_lbl.AutoSize = true;
            this.Btw_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btw_out_lbl.Location = new System.Drawing.Point(117, 924);
            this.Btw_out_lbl.Name = "Btw_out_lbl";
            this.Btw_out_lbl.Size = new System.Drawing.Size(0, 20);
            this.Btw_out_lbl.TabIndex = 41;
            // 
            // Totaal_out_lbl
            // 
            this.Totaal_out_lbl.AutoSize = true;
            this.Totaal_out_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaal_out_lbl.Location = new System.Drawing.Point(127, 951);
            this.Totaal_out_lbl.Name = "Totaal_out_lbl";
            this.Totaal_out_lbl.Size = new System.Drawing.Size(0, 24);
            this.Totaal_out_lbl.TabIndex = 42;
            // 
            // Fooi_btn_1
            // 
            this.Fooi_btn_1.BackColor = System.Drawing.Color.Transparent;
            this.Fooi_btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fooi_btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Fooi_btn_1.ForeColor = System.Drawing.Color.Black;
            this.Fooi_btn_1.Location = new System.Drawing.Point(421, 309);
            this.Fooi_btn_1.Name = "Fooi_btn_1";
            this.Fooi_btn_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fooi_btn_1.Size = new System.Drawing.Size(75, 75);
            this.Fooi_btn_1.TabIndex = 22;
            this.Fooi_btn_1.Text = "1";
            this.Fooi_btn_1.UseVisualStyleBackColor = false;
            // 
            // Betalen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.Totaal_out_lbl);
            this.Controls.Add(this.Btw_out_lbl);
            this.Controls.Add(this.Betaalwijze_out_lbl);
            this.Controls.Add(this.Fooi_out_lbl);
            this.Controls.Add(this.Datum_out_lbl);
            this.Controls.Add(this.medewerker_out_lbl);
            this.Controls.Add(this.Tafel_out_lbl);
            this.Controls.Add(this.Fooi_btn_komma);
            this.Controls.Add(this.Opmerking_add_btn);
            this.Controls.Add(this.Fooi_btn_enter);
            this.Controls.Add(this.Fooi_btn_0);
            this.Controls.Add(this.Fooi_btn_backspace);
            this.Controls.Add(this.Fooi_btn_9);
            this.Controls.Add(this.Fooi_btn_8);
            this.Controls.Add(this.Fooi_btn_7);
            this.Controls.Add(this.Fooi_btn_6);
            this.Controls.Add(this.Fooi_btn_5);
            this.Controls.Add(this.Fooi_btn_4);
            this.Controls.Add(this.Fooi_btn_3);
            this.Controls.Add(this.Fooi_btn_2);
            this.Controls.Add(this.Fooi_btn_1);
            this.Controls.Add(this.Fooi_textbox);
            this.Controls.Add(this.Fooi_header_lbl);
            this.Controls.Add(this.Opmerking_txtbox);
            this.Controls.Add(this.Opmerking_header_lbl);
            this.Controls.Add(this.Betaalwijze_header_lbl);
            this.Controls.Add(this.Betaalwijze_credit_btn);
            this.Controls.Add(this.Betaalwijze_contant_btn);
            this.Controls.Add(this.Betaalwijze_pin_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btw_lbl);
            this.Controls.Add(this.Betaalwijze_lbl);
            this.Controls.Add(this.Fooi_lbl);
            this.Controls.Add(this.Datagrid_items_bestelling);
            this.Controls.Add(this.Datum_lbl);
            this.Controls.Add(this.Medewerker_lbl);
            this.Controls.Add(this.Tafel_lbl);
            this.Name = "Betalen_Form";
            this.Controls.SetChildIndex(this.Tafel_lbl, 0);
            this.Controls.SetChildIndex(this.Medewerker_lbl, 0);
            this.Controls.SetChildIndex(this.Datum_lbl, 0);
            this.Controls.SetChildIndex(this.Datagrid_items_bestelling, 0);
            this.Controls.SetChildIndex(this.Fooi_lbl, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_lbl, 0);
            this.Controls.SetChildIndex(this.Btw_lbl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_pin_btn, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_contant_btn, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_credit_btn, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_header_lbl, 0);
            this.Controls.SetChildIndex(this.Opmerking_header_lbl, 0);
            this.Controls.SetChildIndex(this.Opmerking_txtbox, 0);
            this.Controls.SetChildIndex(this.Fooi_header_lbl, 0);
            this.Controls.SetChildIndex(this.Fooi_textbox, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_1, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_2, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_3, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_4, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_5, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_6, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_7, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_8, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_9, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_backspace, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_0, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_enter, 0);
            this.Controls.SetChildIndex(this.Opmerking_add_btn, 0);
            this.Controls.SetChildIndex(this.Fooi_btn_komma, 0);
            this.Controls.SetChildIndex(this.Tafel_out_lbl, 0);
            this.Controls.SetChildIndex(this.medewerker_out_lbl, 0);
            this.Controls.SetChildIndex(this.Datum_out_lbl, 0);
            this.Controls.SetChildIndex(this.Fooi_out_lbl, 0);
            this.Controls.SetChildIndex(this.Betaalwijze_out_lbl, 0);
            this.Controls.SetChildIndex(this.Btw_out_lbl, 0);
            this.Controls.SetChildIndex(this.Totaal_out_lbl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_items_bestelling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tafel_lbl;
        private System.Windows.Forms.Label Medewerker_lbl;
        private System.Windows.Forms.Label Datum_lbl;
        private System.Windows.Forms.DataGridView Datagrid_items_bestelling;
        private System.Windows.Forms.Label Fooi_lbl;
        private System.Windows.Forms.Label Betaalwijze_lbl;
        private System.Windows.Forms.Label Btw_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Betaalwijze_pin_btn;
        private System.Windows.Forms.Button Betaalwijze_contant_btn;
        private System.Windows.Forms.Button Betaalwijze_credit_btn;
        private System.Windows.Forms.Label Betaalwijze_header_lbl;
        private System.Windows.Forms.Label Opmerking_header_lbl;
        private System.Windows.Forms.RichTextBox Opmerking_txtbox;
        private System.Windows.Forms.Label Fooi_header_lbl;
        private System.Windows.Forms.RichTextBox Fooi_textbox;
        private System.Windows.Forms.Button Fooi_btn_1;
        private System.Windows.Forms.Button Fooi_btn_2;
        private System.Windows.Forms.Button Fooi_btn_3;
        private System.Windows.Forms.Button Fooi_btn_4;
        private System.Windows.Forms.Button Fooi_btn_5;
        private System.Windows.Forms.Button Fooi_btn_6;
        private System.Windows.Forms.Button Fooi_btn_7;
        private System.Windows.Forms.Button Fooi_btn_8;
        private System.Windows.Forms.Button Fooi_btn_9;
        private System.Windows.Forms.Button Fooi_btn_backspace;
        private System.Windows.Forms.Button Fooi_btn_0;
        private System.Windows.Forms.Button Fooi_btn_enter;
        private System.Windows.Forms.Button Opmerking_add_btn;
        private System.Windows.Forms.Button Fooi_btn_komma;
        private System.Windows.Forms.Label Tafel_out_lbl;
        private System.Windows.Forms.Label medewerker_out_lbl;
        private System.Windows.Forms.Label Datum_out_lbl;
        private System.Windows.Forms.Label Fooi_out_lbl;
        private System.Windows.Forms.Label Betaalwijze_out_lbl;
        private System.Windows.Forms.Label Btw_out_lbl;
        private System.Windows.Forms.Label Totaal_out_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
    }
}
