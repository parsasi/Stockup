namespace StockUp.Forms
{
    partial class InvoiceDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDashboardForm));
            this.InvoicesMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.InvoiceTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.detailsTabPage = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lastNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.firstNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.editTabPage = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MaterialEditLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.DeleteInvoiceButton = new MaterialSkin.Controls.MaterialButton();
            this.SaveInvoiceButton = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BrowseInvoicesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.invoicesDashboardTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.searchInvoiceTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.searchInvoiceButton = new MaterialSkin.Controls.MaterialButton();
            this.dashboardInvoiceButton = new MaterialSkin.Controls.MaterialButton();
            this.InvoicesMaterialCard.SuspendLayout();
            this.InvoiceTabControl.SuspendLayout();
            this.detailsTabPage.SuspendLayout();
            this.editTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.invoicesDashboardTableLayout.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvoicesMaterialCard
            // 
            this.InvoicesMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.InvoicesMaterialCard.Controls.Add(this.materialTabSelector1);
            this.InvoicesMaterialCard.Controls.Add(this.InvoiceTabControl);
            this.InvoicesMaterialCard.Depth = 0;
            this.InvoicesMaterialCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoicesMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoicesMaterialCard.Location = new System.Drawing.Point(878, 180);
            this.InvoicesMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.InvoicesMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.InvoicesMaterialCard.Name = "InvoicesMaterialCard";
            this.InvoicesMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.InvoicesMaterialCard.Size = new System.Drawing.Size(548, 731);
            this.InvoicesMaterialCard.TabIndex = 2;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialTabSelector1.BaseTabControl = this.InvoiceTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTabSelector1.Location = new System.Drawing.Point(11, 8);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(520, 32);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // InvoiceTabControl
            // 
            this.InvoiceTabControl.Controls.Add(this.detailsTabPage);
            this.InvoiceTabControl.Controls.Add(this.editTabPage);
            this.InvoiceTabControl.Depth = 0;
            this.InvoiceTabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InvoiceTabControl.Location = new System.Drawing.Point(11, 46);
            this.InvoiceTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.InvoiceTabControl.Multiline = true;
            this.InvoiceTabControl.Name = "InvoiceTabControl";
            this.InvoiceTabControl.SelectedIndex = 0;
            this.InvoiceTabControl.Size = new System.Drawing.Size(520, 608);
            this.InvoiceTabControl.TabIndex = 2;
            // 
            // detailsTabPage
            // 
            this.detailsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.detailsTabPage.Controls.Add(this.materialLabel4);
            this.detailsTabPage.Controls.Add(this.materialListView2);
            this.detailsTabPage.Controls.Add(this.materialLabel3);
            this.detailsTabPage.Controls.Add(this.materialLabel2);
            this.detailsTabPage.Controls.Add(this.lastNameLabel);
            this.detailsTabPage.Controls.Add(this.firstNameLabel);
            this.detailsTabPage.Location = new System.Drawing.Point(4, 26);
            this.detailsTabPage.Name = "detailsTabPage";
            this.detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailsTabPage.Size = new System.Drawing.Size(512, 578);
            this.detailsTabPage.TabIndex = 0;
            this.detailsTabPage.Text = "Invoice Details";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 199);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Products:";
            // 
            // materialListView2
            // 
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Depth = 0;
            this.materialListView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(18, 230);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(466, 277);
            this.materialListView2.TabIndex = 4;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.CausesValidation = false;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(15, 141);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(296, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "182ad85e-86e1-456e-b2de-bf7cf9dd06c1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.CausesValidation = false;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 99);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(276, 29);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = " November 6, 2020";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastNameLabel.CausesValidation = false;
            this.lastNameLabel.Depth = 0;
            this.lastNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(13, 55);
            this.lastNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(116, 29);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Westbrook";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstNameLabel.Depth = 0;
            this.firstNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.firstNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(13, 14);
            this.firstNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Russle";
            // 
            // editTabPage
            // 
            this.editTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editTabPage.Controls.Add(this.materialLabel1);
            this.editTabPage.Controls.Add(this.dateTimePicker1);
            this.editTabPage.Controls.Add(this.MaterialEditLabel);
            this.editTabPage.Controls.Add(this.materialListView1);
            this.editTabPage.Controls.Add(this.DeleteInvoiceButton);
            this.editTabPage.Controls.Add(this.SaveInvoiceButton);
            this.editTabPage.Location = new System.Drawing.Point(4, 26);
            this.editTabPage.Name = "editTabPage";
            this.editTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editTabPage.Size = new System.Drawing.Size(512, 578);
            this.editTabPage.TabIndex = 1;
            this.editTabPage.Text = "Edit ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(465, 24);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // MaterialEditLabel
            // 
            this.MaterialEditLabel.AutoSize = true;
            this.MaterialEditLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaterialEditLabel.Depth = 0;
            this.MaterialEditLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialEditLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialEditLabel.Location = new System.Drawing.Point(13, 113);
            this.MaterialEditLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialEditLabel.Name = "MaterialEditLabel";
            this.MaterialEditLabel.Size = new System.Drawing.Size(73, 19);
            this.MaterialEditLabel.TabIndex = 3;
            this.MaterialEditLabel.Text = "Customer:";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(14, 147);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(465, 321);
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // DeleteInvoiceButton
            // 
            this.DeleteInvoiceButton.AutoSize = false;
            this.DeleteInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DeleteInvoiceButton.Depth = 0;
            this.DeleteInvoiceButton.DrawShadows = true;
            this.DeleteInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeleteInvoiceButton.HighEmphasis = true;
            this.DeleteInvoiceButton.Icon = null;
            this.DeleteInvoiceButton.Location = new System.Drawing.Point(14, 488);
            this.DeleteInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteInvoiceButton.Name = "DeleteInvoiceButton";
            this.DeleteInvoiceButton.Size = new System.Drawing.Size(225, 39);
            this.DeleteInvoiceButton.TabIndex = 1;
            this.DeleteInvoiceButton.Text = "Delete Invoice";
            this.DeleteInvoiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteInvoiceButton.UseAccentColor = false;
            this.DeleteInvoiceButton.UseVisualStyleBackColor = false;
            this.DeleteInvoiceButton.Click += new System.EventHandler(this.DeleteInvoiceButton_Click);
            // 
            // SaveInvoiceButton
            // 
            this.SaveInvoiceButton.AutoSize = false;
            this.SaveInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveInvoiceButton.Depth = 0;
            this.SaveInvoiceButton.DrawShadows = true;
            this.SaveInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveInvoiceButton.HighEmphasis = true;
            this.SaveInvoiceButton.Icon = null;
            this.SaveInvoiceButton.Location = new System.Drawing.Point(254, 488);
            this.SaveInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveInvoiceButton.Name = "SaveInvoiceButton";
            this.SaveInvoiceButton.Size = new System.Drawing.Size(225, 39);
            this.SaveInvoiceButton.TabIndex = 0;
            this.SaveInvoiceButton.Text = "Save Invoice";
            this.SaveInvoiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveInvoiceButton.UseAccentColor = false;
            this.SaveInvoiceButton.UseVisualStyleBackColor = false;
            this.SaveInvoiceButton.Click += new System.EventHandler(this.SaveInvoiceButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.Location = new System.Drawing.Point(3, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 753);
            this.dataGridView1.TabIndex = 1;
            // 
            // BrowseInvoicesLabel
            // 
            this.BrowseInvoicesLabel.AutoSize = true;
            this.BrowseInvoicesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BrowseInvoicesLabel.Depth = 0;
            this.BrowseInvoicesLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BrowseInvoicesLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.BrowseInvoicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BrowseInvoicesLabel.Location = new System.Drawing.Point(20, 0);
            this.BrowseInvoicesLabel.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.BrowseInvoicesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseInvoicesLabel.Name = "BrowseInvoicesLabel";
            this.BrowseInvoicesLabel.Size = new System.Drawing.Size(248, 41);
            this.BrowseInvoicesLabel.TabIndex = 0;
            this.BrowseInvoicesLabel.Text = "Browse Invoices";
            // 
            // invoicesDashboardTableLayout
            // 
            this.invoicesDashboardTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.invoicesDashboardTableLayout.ColumnCount = 2;
            this.invoicesDashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.invoicesDashboardTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.invoicesDashboardTableLayout.Controls.Add(this.dataGridView1, 0, 2);
            this.invoicesDashboardTableLayout.Controls.Add(this.InvoicesMaterialCard, 1, 2);
            this.invoicesDashboardTableLayout.Controls.Add(this.materialCard1, 0, 1);
            this.invoicesDashboardTableLayout.Controls.Add(this.BrowseInvoicesLabel, 0, 0);
            this.invoicesDashboardTableLayout.Controls.Add(this.dashboardInvoiceButton, 1, 0);
            this.invoicesDashboardTableLayout.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.invoicesDashboardTableLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.invoicesDashboardTableLayout.Location = new System.Drawing.Point(0, 75);
            this.invoicesDashboardTableLayout.Name = "invoicesDashboardTableLayout";
            this.invoicesDashboardTableLayout.RowCount = 3;
            this.invoicesDashboardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.278922F));
            this.invoicesDashboardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081F));
            this.invoicesDashboardTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.94595F));
            this.invoicesDashboardTableLayout.Size = new System.Drawing.Size(1440, 925);
            this.invoicesDashboardTableLayout.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.Controls.Add(this.searchInvoiceTextbox);
            this.materialCard1.Controls.Add(this.searchInvoiceButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(836, 71);
            this.materialCard1.TabIndex = 3;
            // 
            // searchInvoiceTextbox
            // 
            this.searchInvoiceTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchInvoiceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInvoiceTextbox.Depth = 0;
            this.searchInvoiceTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.searchInvoiceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchInvoiceTextbox.Hint = "Search...";
            this.searchInvoiceTextbox.Location = new System.Drawing.Point(17, 11);
            this.searchInvoiceTextbox.MaxLength = 50;
            this.searchInvoiceTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchInvoiceTextbox.Multiline = false;
            this.searchInvoiceTextbox.Name = "searchInvoiceTextbox";
            this.searchInvoiceTextbox.Size = new System.Drawing.Size(686, 50);
            this.searchInvoiceTextbox.TabIndex = 2;
            this.searchInvoiceTextbox.Text = "";
            // 
            // searchInvoiceButton
            // 
            this.searchInvoiceButton.AutoSize = false;
            this.searchInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchInvoiceButton.Depth = 0;
            this.searchInvoiceButton.DrawShadows = true;
            this.searchInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchInvoiceButton.HighEmphasis = true;
            this.searchInvoiceButton.Icon = null;
            this.searchInvoiceButton.Location = new System.Drawing.Point(721, 11);
            this.searchInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchInvoiceButton.Name = "searchInvoiceButton";
            this.searchInvoiceButton.Size = new System.Drawing.Size(97, 50);
            this.searchInvoiceButton.TabIndex = 1;
            this.searchInvoiceButton.Text = "Filter";
            this.searchInvoiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchInvoiceButton.UseAccentColor = false;
            this.searchInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // dashboardInvoiceButton
            // 
            this.dashboardInvoiceButton.AutoSize = false;
            this.dashboardInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashboardInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dashboardInvoiceButton.Depth = 0;
            this.dashboardInvoiceButton.DrawShadows = true;
            this.dashboardInvoiceButton.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dashboardInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dashboardInvoiceButton.HighEmphasis = true;
            this.dashboardInvoiceButton.Icon = null;
            this.dashboardInvoiceButton.Location = new System.Drawing.Point(868, 6);
            this.dashboardInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dashboardInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dashboardInvoiceButton.Name = "dashboardInvoiceButton";
            this.dashboardInvoiceButton.Size = new System.Drawing.Size(559, 55);
            this.dashboardInvoiceButton.TabIndex = 4;
            this.dashboardInvoiceButton.Text = "Dashboard";
            this.dashboardInvoiceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dashboardInvoiceButton.UseAccentColor = false;
            this.dashboardInvoiceButton.UseVisualStyleBackColor = false;
            this.dashboardInvoiceButton.Click += new System.EventHandler(this.dashboardInvoiceButton_Click);
            // 
            // InvoiceDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1000);
            this.Controls.Add(this.invoicesDashboardTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices Dashboard";
            this.InvoicesMaterialCard.ResumeLayout(false);
            this.InvoiceTabControl.ResumeLayout(false);
            this.detailsTabPage.ResumeLayout(false);
            this.detailsTabPage.PerformLayout();
            this.editTabPage.ResumeLayout(false);
            this.editTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.invoicesDashboardTableLayout.ResumeLayout(false);
            this.invoicesDashboardTableLayout.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard InvoicesMaterialCard;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl InvoiceTabControl;
        private System.Windows.Forms.TabPage detailsTabPage;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lastNameLabel;
        private MaterialSkin.Controls.MaterialLabel firstNameLabel;
        private System.Windows.Forms.TabPage editTabPage;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel MaterialEditLabel;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton DeleteInvoiceButton;
        private MaterialSkin.Controls.MaterialButton SaveInvoiceButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel BrowseInvoicesLabel;
        private System.Windows.Forms.TableLayoutPanel invoicesDashboardTableLayout;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton searchInvoiceButton;
        private MaterialSkin.Controls.MaterialTextBox searchInvoiceTextbox;
        private MaterialSkin.Controls.MaterialButton dashboardInvoiceButton;
    }
}