namespace StockUp.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerDashboardButton = new MaterialSkin.Controls.MaterialButton();
            this.categoryDashboardButton = new MaterialSkin.Controls.MaterialButton();
            this.productDashboardButton = new MaterialSkin.Controls.MaterialButton();
            this.openInvoicesDashboardButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.customerDashboardButton);
            this.panel1.Controls.Add(this.categoryDashboardButton);
            this.panel1.Controls.Add(this.productDashboardButton);
            this.panel1.Controls.Add(this.openInvoicesDashboardButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 841);
            this.panel1.TabIndex = 1;
            // 
            // customerDashboardButton
            // 
            this.customerDashboardButton.AutoSize = false;
            this.customerDashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customerDashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.customerDashboardButton.Depth = 0;
            this.customerDashboardButton.DrawShadows = true;
            this.customerDashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerDashboardButton.HighEmphasis = true;
            this.customerDashboardButton.Icon = null;
            this.customerDashboardButton.Location = new System.Drawing.Point(14, 476);
            this.customerDashboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customerDashboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerDashboardButton.Name = "customerDashboardButton";
            this.customerDashboardButton.Size = new System.Drawing.Size(282, 59);
            this.customerDashboardButton.TabIndex = 4;
            this.customerDashboardButton.Text = "Customer Dashboard";
            this.customerDashboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.customerDashboardButton.UseAccentColor = false;
            this.customerDashboardButton.UseVisualStyleBackColor = false;
            this.customerDashboardButton.Click += new System.EventHandler(this.customerDashboardButton_Click);
            // 
            // categoryDashboardButton
            // 
            this.categoryDashboardButton.AutoSize = false;
            this.categoryDashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.categoryDashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryDashboardButton.Depth = 0;
            this.categoryDashboardButton.DrawShadows = true;
            this.categoryDashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryDashboardButton.HighEmphasis = true;
            this.categoryDashboardButton.Icon = null;
            this.categoryDashboardButton.Location = new System.Drawing.Point(14, 391);
            this.categoryDashboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.categoryDashboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryDashboardButton.Name = "categoryDashboardButton";
            this.categoryDashboardButton.Size = new System.Drawing.Size(282, 59);
            this.categoryDashboardButton.TabIndex = 3;
            this.categoryDashboardButton.Text = "Category Dashboard";
            this.categoryDashboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.categoryDashboardButton.UseAccentColor = false;
            this.categoryDashboardButton.UseVisualStyleBackColor = false;
            this.categoryDashboardButton.Click += new System.EventHandler(this.categoryDashboardButton_Click);
            // 
            // productDashboardButton
            // 
            this.productDashboardButton.AutoSize = false;
            this.productDashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productDashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productDashboardButton.Depth = 0;
            this.productDashboardButton.DrawShadows = true;
            this.productDashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productDashboardButton.HighEmphasis = true;
            this.productDashboardButton.Icon = null;
            this.productDashboardButton.Location = new System.Drawing.Point(14, 306);
            this.productDashboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productDashboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.productDashboardButton.Name = "productDashboardButton";
            this.productDashboardButton.Size = new System.Drawing.Size(282, 59);
            this.productDashboardButton.TabIndex = 2;
            this.productDashboardButton.Text = "Product Dashboard";
            this.productDashboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productDashboardButton.UseAccentColor = false;
            this.productDashboardButton.UseVisualStyleBackColor = false;
            this.productDashboardButton.Click += new System.EventHandler(this.productDashboardButton_Click);
            // 
            // openInvoicesDashboardButton
            // 
            this.openInvoicesDashboardButton.AutoSize = false;
            this.openInvoicesDashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openInvoicesDashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openInvoicesDashboardButton.Depth = 0;
            this.openInvoicesDashboardButton.DrawShadows = true;
            this.openInvoicesDashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openInvoicesDashboardButton.HighEmphasis = true;
            this.openInvoicesDashboardButton.Icon = null;
            this.openInvoicesDashboardButton.Location = new System.Drawing.Point(14, 224);
            this.openInvoicesDashboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openInvoicesDashboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openInvoicesDashboardButton.Name = "openInvoicesDashboardButton";
            this.openInvoicesDashboardButton.Size = new System.Drawing.Size(282, 59);
            this.openInvoicesDashboardButton.TabIndex = 1;
            this.openInvoicesDashboardButton.Text = "Invoice Dashboard";
            this.openInvoicesDashboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openInvoicesDashboardButton.UseAccentColor = false;
            this.openInvoicesDashboardButton.UseVisualStyleBackColor = false;
            this.openInvoicesDashboardButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1000);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton openInvoicesDashboardButton;
        private MaterialSkin.Controls.MaterialButton productDashboardButton;
        private MaterialSkin.Controls.MaterialButton customerDashboardButton;
        private MaterialSkin.Controls.MaterialButton categoryDashboardButton;
    }
}