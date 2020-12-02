
namespace StockUp.Forms
{
    partial class CustomerDashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productBrowseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dashboardButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.filterButton = new MaterialSkin.Controls.MaterialButton();
            this.productSearchTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.productTab = new MaterialSkin.Controls.MaterialTabControl();
            this.detailsTab = new System.Windows.Forms.TabPage();
            this.lastNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.categoryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dobLabel = new MaterialSkin.Controls.MaterialLabel();
            this.descriptionTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.phoneLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.firstNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.editTab = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.deleteProductButton = new MaterialSkin.Controls.MaterialButton();
            this.categoryEditListBox = new System.Windows.Forms.ListBox();
            this.quantityEditSubButton = new MaterialSkin.Controls.MaterialButton();
            this.quantityEditPlusButton = new MaterialSkin.Controls.MaterialButton();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.manufacturerEditTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.quantityEditTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.titleEditTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.addCustomerButton = new MaterialSkin.Controls.MaterialButton();
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new StockUpApp.CustomerDataSet();
            this.customersTableAdapter = new StockUpApp.CustomerDataSetTableAdapters.CustomersTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.productTab.SuspendLayout();
            this.detailsTab.SuspendLayout();
            this.editTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.productBrowseLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dashboardButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialCard2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addCustomerButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customersDGV, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.306434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1416, 917);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // productBrowseLabel
            // 
            this.productBrowseLabel.AutoSize = true;
            this.productBrowseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productBrowseLabel.Depth = 0;
            this.productBrowseLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.productBrowseLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.productBrowseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productBrowseLabel.Location = new System.Drawing.Point(20, 10);
            this.productBrowseLabel.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.productBrowseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.productBrowseLabel.Name = "productBrowseLabel";
            this.productBrowseLabel.Size = new System.Drawing.Size(290, 41);
            this.productBrowseLabel.TabIndex = 0;
            this.productBrowseLabel.Text = "Browse Customers";
            // 
            // dashboardButton
            // 
            this.dashboardButton.AutoSize = false;
            this.dashboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dashboardButton.Depth = 0;
            this.dashboardButton.DrawShadows = true;
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dashboardButton.HighEmphasis = true;
            this.dashboardButton.Icon = null;
            this.dashboardButton.Location = new System.Drawing.Point(853, 6);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dashboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(559, 48);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dashboardButton.UseAccentColor = false;
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.Controls.Add(this.filterButton);
            this.materialCard1.Controls.Add(this.productSearchTextbox);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 79);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(821, 73);
            this.materialCard1.TabIndex = 2;
            // 
            // filterButton
            // 
            this.filterButton.AutoSize = false;
            this.filterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.filterButton.Depth = 0;
            this.filterButton.DrawShadows = true;
            this.filterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.filterButton.HighEmphasis = true;
            this.filterButton.Icon = null;
            this.filterButton.Location = new System.Drawing.Point(698, 7);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(113, 50);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Filter";
            this.filterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.filterButton.UseAccentColor = false;
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // productSearchTextbox
            // 
            this.productSearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productSearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSearchTextbox.Depth = 0;
            this.productSearchTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.productSearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productSearchTextbox.Hint = "Search...";
            this.productSearchTextbox.Location = new System.Drawing.Point(5, 8);
            this.productSearchTextbox.MaxLength = 50;
            this.productSearchTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.productSearchTextbox.Multiline = false;
            this.productSearchTextbox.Name = "productSearchTextbox";
            this.productSearchTextbox.Size = new System.Drawing.Size(681, 50);
            this.productSearchTextbox.TabIndex = 0;
            this.productSearchTextbox.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard2.Controls.Add(this.materialTabSelector1);
            this.materialCard2.Controls.Add(this.productTab);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Location = new System.Drawing.Point(863, 180);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(539, 701);
            this.materialCard2.TabIndex = 4;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialTabSelector1.BaseTabControl = this.productTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTabSelector1.Location = new System.Drawing.Point(17, 12);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(509, 49);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // productTab
            // 
            this.productTab.Controls.Add(this.detailsTab);
            this.productTab.Controls.Add(this.editTab);
            this.productTab.Depth = 0;
            this.productTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productTab.Location = new System.Drawing.Point(17, 73);
            this.productTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.productTab.Multiline = true;
            this.productTab.Name = "productTab";
            this.productTab.SelectedIndex = 0;
            this.productTab.Size = new System.Drawing.Size(505, 532);
            this.productTab.TabIndex = 0;
            // 
            // detailsTab
            // 
            this.detailsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.detailsTab.Controls.Add(this.lastNameLabel);
            this.detailsTab.Controls.Add(this.categoryLabel);
            this.detailsTab.Controls.Add(this.dobLabel);
            this.detailsTab.Controls.Add(this.descriptionTextbox);
            this.detailsTab.Controls.Add(this.phoneLabel);
            this.detailsTab.Controls.Add(this.emailLabel);
            this.detailsTab.Controls.Add(this.firstNameLabel);
            this.detailsTab.Location = new System.Drawing.Point(4, 26);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.detailsTab.Size = new System.Drawing.Size(497, 502);
            this.detailsTab.TabIndex = 0;
            this.detailsTab.Text = "Details";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastNameLabel.Depth = 0;
            this.lastNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(159, 22);
            this.lastNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(62, 29);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Apple";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryLabel.Depth = 0;
            this.categoryLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryLabel.Location = new System.Drawing.Point(116, 197);
            this.categoryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(1, 0);
            this.categoryLabel.TabIndex = 11;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dobLabel.Depth = 0;
            this.dobLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dobLabel.Location = new System.Drawing.Point(19, 150);
            this.dobLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(71, 19);
            this.dobLabel.TabIndex = 7;
            this.dobLabel.Text = "Birth Date";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextbox.Depth = 0;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.descriptionTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionTextbox.Hint = "";
            this.descriptionTextbox.Location = new System.Drawing.Point(21, 270);
            this.descriptionTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.Size = new System.Drawing.Size(456, 96);
            this.descriptionTextbox.TabIndex = 5;
            this.descriptionTextbox.Text = "Some guy who likes furniture";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.phoneLabel.Depth = 0;
            this.phoneLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneLabel.Location = new System.Drawing.Point(18, 63);
            this.phoneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 19);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(257, 61);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstNameLabel.Depth = 0;
            this.firstNameLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.firstNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(16, 22);
            this.firstNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(42, 29);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Tim";
            // 
            // editTab
            // 
            this.editTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.editTab.Controls.Add(this.materialButton1);
            this.editTab.Controls.Add(this.deleteProductButton);
            this.editTab.Controls.Add(this.categoryEditListBox);
            this.editTab.Controls.Add(this.quantityEditSubButton);
            this.editTab.Controls.Add(this.quantityEditPlusButton);
            this.editTab.Controls.Add(this.materialMultiLineTextBox1);
            this.editTab.Controls.Add(this.manufacturerEditTextbox);
            this.editTab.Controls.Add(this.quantityEditTextbox);
            this.editTab.Controls.Add(this.titleEditTextbox);
            this.editTab.Location = new System.Drawing.Point(4, 26);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(497, 502);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(251, 456);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(225, 39);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Save Product";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.AutoSize = false;
            this.deleteProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deleteProductButton.Depth = 0;
            this.deleteProductButton.DrawShadows = true;
            this.deleteProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteProductButton.HighEmphasis = true;
            this.deleteProductButton.Icon = null;
            this.deleteProductButton.Location = new System.Drawing.Point(18, 456);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(225, 39);
            this.deleteProductButton.TabIndex = 8;
            this.deleteProductButton.Text = "Delete Product";
            this.deleteProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteProductButton.UseAccentColor = false;
            this.deleteProductButton.UseVisualStyleBackColor = false;
            // 
            // categoryEditListBox
            // 
            this.categoryEditListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.categoryEditListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryEditListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryEditListBox.FormattingEnabled = true;
            this.categoryEditListBox.ItemHeight = 17;
            this.categoryEditListBox.Location = new System.Drawing.Point(18, 363);
            this.categoryEditListBox.Name = "categoryEditListBox";
            this.categoryEditListBox.Size = new System.Drawing.Size(458, 72);
            this.categoryEditListBox.TabIndex = 7;
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
            this.quantityEditSubButton.Location = new System.Drawing.Point(18, 141);
            this.quantityEditSubButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quantityEditSubButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantityEditSubButton.Name = "quantityEditSubButton";
            this.quantityEditSubButton.Size = new System.Drawing.Size(45, 62);
            this.quantityEditSubButton.TabIndex = 6;
            this.quantityEditSubButton.Text = "-";
            this.quantityEditSubButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quantityEditSubButton.UseAccentColor = false;
            this.quantityEditSubButton.UseVisualStyleBackColor = false;
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
            this.quantityEditPlusButton.Location = new System.Drawing.Point(431, 141);
            this.quantityEditPlusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quantityEditPlusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantityEditPlusButton.Name = "quantityEditPlusButton";
            this.quantityEditPlusButton.Size = new System.Drawing.Size(45, 62);
            this.quantityEditPlusButton.TabIndex = 5;
            this.quantityEditPlusButton.Text = "+";
            this.quantityEditPlusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quantityEditPlusButton.UseAccentColor = false;
            this.quantityEditPlusButton.UseVisualStyleBackColor = false;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.Hint = "";
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(18, 220);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(458, 119);
            this.materialMultiLineTextBox1.TabIndex = 4;
            this.materialMultiLineTextBox1.Text = "The De\'Longhi Dedica Deluxe Pump Espresso machine in matte stainless steel finish" +
    ", provides the high-quality brewing power you expect from De\'Longhi in an ultra " +
    "slip 6in design.";
            // 
            // manufacturerEditTextbox
            // 
            this.manufacturerEditTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manufacturerEditTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manufacturerEditTextbox.Depth = 0;
            this.manufacturerEditTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manufacturerEditTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manufacturerEditTextbox.Hint = "Manufacturer...";
            this.manufacturerEditTextbox.Location = new System.Drawing.Point(18, 79);
            this.manufacturerEditTextbox.MaxLength = 50;
            this.manufacturerEditTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.manufacturerEditTextbox.Multiline = false;
            this.manufacturerEditTextbox.Name = "manufacturerEditTextbox";
            this.manufacturerEditTextbox.Size = new System.Drawing.Size(458, 50);
            this.manufacturerEditTextbox.TabIndex = 2;
            this.manufacturerEditTextbox.Text = "Delonghi";
            // 
            // quantityEditTextbox
            // 
            this.quantityEditTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.quantityEditTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityEditTextbox.Depth = 0;
            this.quantityEditTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantityEditTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityEditTextbox.Hint = "Quantity...";
            this.quantityEditTextbox.Location = new System.Drawing.Point(85, 141);
            this.quantityEditTextbox.MaxLength = 50;
            this.quantityEditTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.quantityEditTextbox.Multiline = false;
            this.quantityEditTextbox.Name = "quantityEditTextbox";
            this.quantityEditTextbox.Size = new System.Drawing.Size(323, 50);
            this.quantityEditTextbox.TabIndex = 1;
            this.quantityEditTextbox.Text = "12";
            // 
            // titleEditTextbox
            // 
            this.titleEditTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titleEditTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleEditTextbox.Depth = 0;
            this.titleEditTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleEditTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titleEditTextbox.Hint = "Product Name...";
            this.titleEditTextbox.Location = new System.Drawing.Point(18, 19);
            this.titleEditTextbox.MaxLength = 50;
            this.titleEditTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleEditTextbox.Multiline = false;
            this.titleEditTextbox.Name = "titleEditTextbox";
            this.titleEditTextbox.Size = new System.Drawing.Size(458, 50);
            this.titleEditTextbox.TabIndex = 0;
            this.titleEditTextbox.Text = "Barista Espresso Machine";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.AutoSize = false;
            this.addCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addCustomerButton.Depth = 0;
            this.addCustomerButton.DrawShadows = true;
            this.addCustomerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCustomerButton.HighEmphasis = true;
            this.addCustomerButton.Icon = null;
            this.addCustomerButton.Location = new System.Drawing.Point(853, 85);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.addCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(559, 49);
            this.addCustomerButton.TabIndex = 5;
            this.addCustomerButton.Text = "New Customer";
            this.addCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addCustomerButton.UseAccentColor = false;
            this.addCustomerButton.UseVisualStyleBackColor = false;
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AutoGenerateColumns = false;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn});
            this.customersDGV.DataSource = this.customersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.customersDGV.Location = new System.Drawing.Point(3, 169);
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.RowTemplate.Height = 24;
            this.customersDGV.Size = new System.Drawing.Size(832, 723);
            this.customersDGV.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 130;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerDashboardForm";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.productTab.ResumeLayout(false);
            this.detailsTab.ResumeLayout(false);
            this.detailsTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel productBrowseLabel;
        private MaterialSkin.Controls.MaterialButton dashboardButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton filterButton;
        private MaterialSkin.Controls.MaterialTextBox productSearchTextbox;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl productTab;
        private System.Windows.Forms.TabPage detailsTab;
        private MaterialSkin.Controls.MaterialLabel categoryLabel;
        private MaterialSkin.Controls.MaterialLabel dobLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox descriptionTextbox;
        private MaterialSkin.Controls.MaterialLabel phoneLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel firstNameLabel;
        private System.Windows.Forms.TabPage editTab;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton deleteProductButton;
        private System.Windows.Forms.ListBox categoryEditListBox;
        private MaterialSkin.Controls.MaterialButton quantityEditSubButton;
        private MaterialSkin.Controls.MaterialButton quantityEditPlusButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialTextBox manufacturerEditTextbox;
        private MaterialSkin.Controls.MaterialTextBox quantityEditTextbox;
        private MaterialSkin.Controls.MaterialTextBox titleEditTextbox;
        private MaterialSkin.Controls.MaterialButton addCustomerButton;
        private System.Windows.Forms.DataGridView customersDGV;
        private StockUpApp.CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private StockUpApp.CustomerDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MaterialSkin.Controls.MaterialLabel lastNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
    }
}