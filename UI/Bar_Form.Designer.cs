namespace UI
{
    partial class Bar_Form
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
            this.btn_bestellingen = new System.Windows.Forms.Button();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.data_dranken = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bestellingen
            // 
            this.btn_bestellingen.Location = new System.Drawing.Point(11, 70);
            this.btn_bestellingen.Name = "btn_bestellingen";
            this.btn_bestellingen.Size = new System.Drawing.Size(120, 50);
            this.btn_bestellingen.TabIndex = 6;
            this.btn_bestellingen.Text = "Bestellingen";
            this.btn_bestellingen.UseVisualStyleBackColor = true;
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(617, 70);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(120, 50);
            this.btn_afrekenen.TabIndex = 7;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            // 
            // data_dranken
            // 
            this.data_dranken.AllowUserToOrderColumns = true;
            this.data_dranken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dranken.Location = new System.Drawing.Point(22, 144);
            this.data_dranken.Margin = new System.Windows.Forms.Padding(2);
            this.data_dranken.Name = "data_dranken";
            this.data_dranken.RowTemplate.Height = 24;
            this.data_dranken.Size = new System.Drawing.Size(700, 610);
            this.data_dranken.TabIndex = 9;
            // 
            // Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 873);
            this.Controls.Add(this.data_dranken);
            this.Controls.Add(this.btn_afrekenen);
            this.Controls.Add(this.btn_bestellingen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bar_Form";
            this.Text = "Bar";
            this.Controls.SetChildIndex(this.btn_bestellingen, 0);
            this.Controls.SetChildIndex(this.btn_afrekenen, 0);
            this.Controls.SetChildIndex(this.data_dranken, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bestellingen;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.DataGridView data_dranken;
    }
}
