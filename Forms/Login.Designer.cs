namespace StockUp.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(620, 120);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 130);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Username...";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(640, 279);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(160, 28);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click_1);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Depth = 0;
            this.passwordTextbox.Hint = "Password...";
            this.passwordTextbox.Location = new System.Drawing.Point(640, 331);
            this.passwordTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '\0';
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.Size = new System.Drawing.Size(160, 28);
            this.passwordTextbox.TabIndex = 6;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(682, 400);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1000);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.logoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextbox;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
    }
}