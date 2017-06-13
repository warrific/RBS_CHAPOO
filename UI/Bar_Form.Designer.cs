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
            this.lbl_test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gereed
            // 
            this.btn_gereed.Location = new System.Drawing.Point(617, 77);
            this.btn_gereed.Name = "btn_gereed";
            this.btn_gereed.Size = new System.Drawing.Size(120, 50);
            this.btn_gereed.TabIndex = 7;
            this.btn_gereed.Text = "Gereed";
            this.btn_gereed.UseVisualStyleBackColor = true;
            this.btn_gereed.Click += new System.EventHandler(this.btn_gereed_Click);
            // 
            // data_dranken
            // 
            this.data_dranken.AllowUserToOrderColumns = true;
            this.data_dranken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dranken.Location = new System.Drawing.Point(22, 144);
            this.data_dranken.Margin = new System.Windows.Forms.Padding(2);
            this.data_dranken.Name = "data_dranken";
            this.data_dranken.RowTemplate.Height = 24;
            this.data_dranken.Size = new System.Drawing.Size(700, 700);
            this.data_dranken.TabIndex = 9;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(323, 96);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(35, 13);
            this.lbl_test.TabIndex = 10;
            this.lbl_test.Text = "label1";
            // 
            // Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(752, 873);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.data_dranken);
            this.Controls.Add(this.btn_gereed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bar_Form";
            this.Text = "Bar";
            this.Controls.SetChildIndex(this.btn_gereed, 0);
            this.Controls.SetChildIndex(this.data_dranken, 0);
            this.Controls.SetChildIndex(this.lbl_test, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_dranken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gereed;
        private System.Windows.Forms.DataGridView data_dranken;
        private System.Windows.Forms.Label lbl_test;
    }
}
