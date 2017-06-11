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
            this.components = new System.ComponentModel.Container();
            this.btn_bestellingen = new System.Windows.Forms.Button();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.list_drankorders = new System.Windows.Forms.ListView();
            this.data_dranken = new System.Windows.Forms.DataGridView();
            this.bestellingenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellingenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bestellingen
            // 
            this.btn_bestellingen.Location = new System.Drawing.Point(15, 86);
            this.btn_bestellingen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bestellingen.Name = "btn_bestellingen";
            this.btn_bestellingen.Size = new System.Drawing.Size(160, 62);
            this.btn_bestellingen.TabIndex = 6;
            this.btn_bestellingen.Text = "Bestellingen";
            this.btn_bestellingen.UseVisualStyleBackColor = true;
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Location = new System.Drawing.Point(823, 86);
            this.btn_afrekenen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(160, 62);
            this.btn_afrekenen.TabIndex = 7;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            // 
            // list_drankorders
            // 
            this.list_drankorders.Location = new System.Drawing.Point(16, 167);
            this.list_drankorders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_drankorders.Name = "list_drankorders";
            this.list_drankorders.Size = new System.Drawing.Size(965, 891);
            this.list_drankorders.TabIndex = 8;
            this.list_drankorders.UseCompatibleStateImageBehavior = false;
            // 
            // data_dranken
            // 
            this.data_dranken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dranken.Location = new System.Drawing.Point(29, 177);
            this.data_dranken.Name = "data_dranken";
            this.data_dranken.RowTemplate.Height = 24;
            this.data_dranken.Size = new System.Drawing.Size(934, 751);
            this.data_dranken.TabIndex = 9;
            // 
            // bestellingenBindingSource
            // 
            this.bestellingenBindingSource.DataSource = typeof(Logica.Bestellingen);
            // 
            // Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1003, 1074);
            this.Controls.Add(this.data_dranken);
            this.Controls.Add(this.list_drankorders);
            this.Controls.Add(this.btn_afrekenen);
            this.Controls.Add(this.btn_bestellingen);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Bar_Form";
            this.Text = "Bar";
            this.Controls.SetChildIndex(this.btn_bestellingen, 0);
            this.Controls.SetChildIndex(this.btn_afrekenen, 0);
            this.Controls.SetChildIndex(this.list_drankorders, 0);
            this.Controls.SetChildIndex(this.data_dranken, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellingenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bestellingen;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.ListView list_drankorders;
        private System.Windows.Forms.DataGridView data_dranken;
        private System.Windows.Forms.BindingSource bestellingenBindingSource;
    }
}
