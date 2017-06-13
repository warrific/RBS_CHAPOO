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
            this.btn_gereed = new System.Windows.Forms.Button();
            this.data_dranken = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gereed
            // 
            this.btn_gereed.Location = new System.Drawing.Point(823, 95);
            this.btn_gereed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gereed.Name = "btn_gereed";
            this.btn_gereed.Size = new System.Drawing.Size(160, 62);
            this.btn_gereed.TabIndex = 7;
            this.btn_gereed.Text = "Gereed";
            this.btn_gereed.UseVisualStyleBackColor = true;
            this.btn_gereed.Click += new System.EventHandler(this.btn_gereed_Click);
            // 
            // data_dranken
            // 
            this.data_dranken.AllowUserToOrderColumns = true;
            this.data_dranken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dranken.Location = new System.Drawing.Point(29, 177);
            this.data_dranken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_dranken.Name = "data_dranken";
            this.data_dranken.RowTemplate.Height = 24;
            this.data_dranken.Size = new System.Drawing.Size(933, 862);
            this.data_dranken.TabIndex = 9;
            // 
            // Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1003, 1074);
            this.Controls.Add(this.data_dranken);
            this.Controls.Add(this.btn_gereed);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Bar_Form";
            this.Text = "Bar";
            this.Controls.SetChildIndex(this.btn_gereed, 0);
            this.Controls.SetChildIndex(this.data_dranken, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_gereed;
        private System.Windows.Forms.DataGridView data_dranken;
    }
}
