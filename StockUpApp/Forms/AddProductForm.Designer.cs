namespace StockUp.Forms
{
    partial class addProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductForm));
            this.quantityEditSubButton = new MaterialSkin.Controls.MaterialButton();
            this.quantityEditPlusButton = new MaterialSkin.Controls.MaterialButton();
            this.descriptionTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.manufacturerTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.quantityAddTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.titleTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveProductButton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // quantityEditSubButton
            // 
            this.quantityEditSubButton.AutoSize = false;
            this.quantityEditSubButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quantityEditSubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.quantityEditSubButton.Depth = 0;
            this.quantityEditSubButton.DrawShadows = true;
            this.quantityEditSubButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityEditSubButton.HighEmphasis = true;
            this.quantityEditSubButton.Icon = null;
            this.quantityEditSubButton.Location = new System.Drawing.Point(45, 231);
            this.quantityEditSubButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quantityEditSubButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantityEditSubButton.Name = "quantityEditSubButton";
            this.quantityEditSubButton.Size = new System.Drawing.Size(45, 62);
            this.quantityEditSubButton.TabIndex = 6;
            this.quantityEditSubButton.Text = "-";
            this.quantityEditSubButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quantityEditSubButton.UseAccentColor = false;
            this.quantityEditSubButton.UseVisualStyleBackColor = false;
            this.quantityEditSubButton.Click += new System.EventHandler(this.quantityEditSubButton_Click);
            // 
            // quantityEditPlusButton
            // 
            this.quantityEditPlusButton.AutoSize = false;
            this.quantityEditPlusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quantityEditPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.quantityEditPlusButton.Depth = 0;
            this.quantityEditPlusButton.DrawShadows = true;
            this.quantityEditPlusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityEditPlusButton.HighEmphasis = true;
            this.quantityEditPlusButton.Icon = null;
            this.quantityEditPlusButton.Location = new System.Drawing.Point(458, 231);
            this.quantityEditPlusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quantityEditPlusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantityEditPlusButton.Name = "quantityEditPlusButton";
            this.quantityEditPlusButton.Size = new System.Drawing.Size(45, 62);
            this.quantityEditPlusButton.TabIndex = 5;
            this.quantityEditPlusButton.Text = "+";
            this.quantityEditPlusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quantityEditPlusButton.UseAccentColor = false;
            this.quantityEditPlusButton.UseVisualStyleBackColor = false;
            this.quantityEditPlusButton.Click += new System.EventHandler(this.quantityEditPlusButton_Click);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextbox.Depth = 0;
            this.descriptionTextbox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionTextbox.Hint = "Description...";
            this.descriptionTextbox.Location = new System.Drawing.Point(45, 338);
            this.descriptionTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(458, 119);
            this.descriptionTextbox.TabIndex = 4;
            this.descriptionTextbox.Text = "";
            // 
            // manufacturerTextbox
            // 
            this.manufacturerTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manufacturerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manufacturerTextbox.Depth = 0;
            this.manufacturerTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.manufacturerTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manufacturerTextbox.Hint = "Manufacturer...";
            this.manufacturerTextbox.Location = new System.Drawing.Point(45, 163);
            this.manufacturerTextbox.MaxLength = 50;
            this.manufacturerTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.manufacturerTextbox.Multiline = false;
            this.manufacturerTextbox.Name = "manufacturerTextbox";
            this.manufacturerTextbox.Size = new System.Drawing.Size(458, 50);
            this.manufacturerTextbox.TabIndex = 2;
            this.manufacturerTextbox.Text = "";
            // 
            // quantityAddTextbox
            // 
            this.quantityAddTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.quantityAddTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityAddTextbox.Depth = 0;
            this.quantityAddTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.quantityAddTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityAddTextbox.Hint = "Quantity...";
            this.quantityAddTextbox.Location = new System.Drawing.Point(110, 231);
            this.quantityAddTextbox.MaxLength = 50;
            this.quantityAddTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.quantityAddTextbox.Multiline = false;
            this.quantityAddTextbox.Name = "quantityAddTextbox";
            this.quantityAddTextbox.Size = new System.Drawing.Size(323, 50);
            this.quantityAddTextbox.TabIndex = 1;
            this.quantityAddTextbox.Text = "0";
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextbox.Depth = 0;
            this.titleTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.titleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleTextbox.Hint = "Product Name...";
            this.titleTextbox.Location = new System.Drawing.Point(45, 92);
            this.titleTextbox.MaxLength = 50;
            this.titleTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleTextbox.Multiline = false;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(458, 50);
            this.titleTextbox.TabIndex = 0;
            this.titleTextbox.Text = "";
            // 
            // saveProductButton
            // 
            this.saveProductButton.AutoSize = false;
            this.saveProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveProductButton.Depth = 0;
            this.saveProductButton.DrawShadows = true;
            this.saveProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveProductButton.HighEmphasis = true;
            this.saveProductButton.Icon = null;
            this.saveProductButton.Location = new System.Drawing.Point(278, 592);
            this.saveProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(225, 39);
            this.saveProductButton.TabIndex = 9;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveProductButton.UseAccentColor = false;
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelButton.Depth = 0;
            this.cancelButton.DrawShadows = true;
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(45, 592);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(225, 39);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryListBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 17;
            this.categoryListBox.Location = new System.Drawing.Point(45, 488);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(458, 72);
            this.categoryListBox.TabIndex = 7;
            // 
            // addProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 662);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.manufacturerTextbox);
            this.Controls.Add(this.quantityEditSubButton);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.quantityEditPlusButton);
            this.Controls.Add(this.quantityAddTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton quantityEditSubButton;
        private MaterialSkin.Controls.MaterialButton quantityEditPlusButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox descriptionTextbox;
        private MaterialSkin.Controls.MaterialTextBox manufacturerTextbox;
        private MaterialSkin.Controls.MaterialTextBox quantityAddTextbox;
        private MaterialSkin.Controls.MaterialTextBox titleTextbox;
        private MaterialSkin.Controls.MaterialButton saveProductButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private System.Windows.Forms.ListBox categoryListBox;
    }
}