namespace UI
{
    partial class Orders_Form
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
            this.data_items = new System.Windows.Forms.DataGridView();
            this.btn_herlaad = new System.Windows.Forms.Button();
            this.btn_gereed = new System.Windows.Forms.Button();
            this.btn_historie = new System.Windows.Forms.Button();
            this.lbl_historie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).BeginInit();
            this.SuspendLayout();
            // 
            // data_items
            // 
            this.data_items.AllowUserToOrderColumns = true;
            this.data_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_items.Location = new System.Drawing.Point(29, 182);
            this.data_items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_items.Name = "data_items";
            this.data_items.RowHeadersVisible = false;
            this.data_items.RowTemplate.Height = 24;
            this.data_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_items.Size = new System.Drawing.Size(933, 798);
            this.data_items.TabIndex = 9;
            // 
            // btn_herlaad
            // 
            this.btn_herlaad.BackColor = System.Drawing.SystemColors.Control;
            this.btn_herlaad.Location = new System.Drawing.Point(29, 96);
            this.btn_herlaad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_herlaad.Name = "btn_herlaad";
            this.btn_herlaad.Size = new System.Drawing.Size(160, 62);
            this.btn_herlaad.TabIndex = 10;
            this.btn_herlaad.Text = "Herlaad";
            this.btn_herlaad.UseVisualStyleBackColor = false;
            this.btn_herlaad.Click += new System.EventHandler(this.btn_herlaad_Click);
            // 
            // btn_gereed
            // 
            this.btn_gereed.BackColor = System.Drawing.SystemColors.Control;
            this.btn_gereed.Location = new System.Drawing.Point(803, 96);
            this.btn_gereed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gereed.Name = "btn_gereed";
            this.btn_gereed.Size = new System.Drawing.Size(160, 62);
            this.btn_gereed.TabIndex = 11;
            this.btn_gereed.Text = "Gereed";
            this.btn_gereed.UseVisualStyleBackColor = false;
            this.btn_gereed.Click += new System.EventHandler(this.btn_gereed_Click);
            // 
            // btn_historie
            // 
            this.btn_historie.Location = new System.Drawing.Point(29, 998);
            this.btn_historie.Margin = new System.Windows.Forms.Padding(4);
            this.btn_historie.Name = "btn_historie";
            this.btn_historie.Size = new System.Drawing.Size(160, 62);
            this.btn_historie.TabIndex = 12;
            this.btn_historie.Text = "Historie orders";
            this.btn_historie.UseVisualStyleBackColor = true;
            this.btn_historie.Click += new System.EventHandler(this.btn_historie_Click);
            // 
            // lbl_historie
            // 
            this.lbl_historie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historie.Location = new System.Drawing.Point(303, 108);
            this.lbl_historie.Name = "lbl_historie";
            this.lbl_historie.Size = new System.Drawing.Size(400, 39);
            this.lbl_historie.TabIndex = 13;
            this.lbl_historie.Text = "Orders";
            this.lbl_historie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1007, 1101);
            this.Controls.Add(this.lbl_historie);
            this.Controls.Add(this.btn_historie);
            this.Controls.Add(this.btn_gereed);
            this.Controls.Add(this.btn_herlaad);
            this.Controls.Add(this.data_items);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Orders_Form";
            this.Text = "Orders";
            this.Controls.SetChildIndex(this.data_items, 0);
            this.Controls.SetChildIndex(this.btn_herlaad, 0);
            this.Controls.SetChildIndex(this.btn_gereed, 0);
            this.Controls.SetChildIndex(this.btn_historie, 0);
            this.Controls.SetChildIndex(this.lbl_historie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.data_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_items;
        private System.Windows.Forms.Button btn_herlaad;
        private System.Windows.Forms.Button btn_gereed;
        private System.Windows.Forms.Button btn_historie;
        private System.Windows.Forms.Label lbl_historie;
    }
}
