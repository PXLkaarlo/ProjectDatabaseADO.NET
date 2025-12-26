namespace InlämningDatabas1
{
    partial class FormBlocket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxResult = new ListBox();
            txtSearch = new TextBox();
            btnCreate = new Button();
            btnLogin = new Button();
            cmbFilter = new ComboBox();
            btnSearch = new Button();
            rdbOldFirst = new RadioButton();
            rdbNewFirst = new RadioButton();
            nudMaxPrice = new NumericUpDown();
            rdbLowestPrice = new RadioButton();
            nudMinPrice = new NumericUpDown();
            lblSearch = new Label();
            lblCategory = new Label();
            lblMaxPrice = new Label();
            lblMinPrice = new Label();
            rdbHighestPrice = new RadioButton();
            lblDeclarePrice = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).BeginInit();
            SuspendLayout();
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(30, 103);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(367, 304);
            listBoxResult.TabIndex = 0;
            listBoxResult.MouseDoubleClick += listBoxResult_MouseDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(30, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(617, 292);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(124, 43);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create product";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(617, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(446, 38);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(295, 28);
            cmbFilter.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(617, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 43);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // rdbOldFirst
            // 
            rdbOldFirst.AutoSize = true;
            rdbOldFirst.Location = new Point(446, 235);
            rdbOldFirst.Name = "rdbOldFirst";
            rdbOldFirst.Size = new Size(102, 24);
            rdbOldFirst.TabIndex = 7;
            rdbOldFirst.TabStop = true;
            rdbOldFirst.Text = "Oldest first";
            rdbOldFirst.UseVisualStyleBackColor = true;
            // 
            // rdbNewFirst
            // 
            rdbNewFirst.AutoSize = true;
            rdbNewFirst.Location = new Point(446, 265);
            rdbNewFirst.Name = "rdbNewFirst";
            rdbNewFirst.Size = new Size(110, 24);
            rdbNewFirst.TabIndex = 8;
            rdbNewFirst.TabStop = true;
            rdbNewFirst.Text = "Newest First";
            rdbNewFirst.UseVisualStyleBackColor = true;
            // 
            // nudMaxPrice
            // 
            nudMaxPrice.Location = new Point(446, 103);
            nudMaxPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMaxPrice.Name = "nudMaxPrice";
            nudMaxPrice.Size = new Size(295, 27);
            nudMaxPrice.TabIndex = 9;
            // 
            // rdbLowestPrice
            // 
            rdbLowestPrice.AutoSize = true;
            rdbLowestPrice.Location = new Point(446, 295);
            rdbLowestPrice.Name = "rdbLowestPrice";
            rdbLowestPrice.Size = new Size(142, 24);
            rdbLowestPrice.TabIndex = 10;
            rdbLowestPrice.TabStop = true;
            rdbLowestPrice.Text = "Lowest price first";
            rdbLowestPrice.UseVisualStyleBackColor = true;
            // 
            // nudMinPrice
            // 
            nudMinPrice.Location = new Point(446, 164);
            nudMinPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMinPrice.Name = "nudMinPrice";
            nudMinPrice.Size = new Size(295, 27);
            nudMinPrice.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(30, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(82, 20);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search box";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(446, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(106, 20);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category Filter";
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Location = new Point(446, 80);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(112, 20);
            lblMaxPrice.TabIndex = 14;
            lblMaxPrice.Text = "Maximum price";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(446, 141);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(109, 20);
            lblMinPrice.TabIndex = 15;
            lblMinPrice.Text = "Minimum price";
            // 
            // rdbHighestPrice
            // 
            rdbHighestPrice.AutoSize = true;
            rdbHighestPrice.Location = new Point(446, 325);
            rdbHighestPrice.Name = "rdbHighestPrice";
            rdbHighestPrice.Size = new Size(147, 24);
            rdbHighestPrice.TabIndex = 16;
            rdbHighestPrice.TabStop = true;
            rdbHighestPrice.Text = "Highest price first";
            rdbHighestPrice.UseVisualStyleBackColor = true;
            // 
            // lblDeclarePrice
            // 
            lblDeclarePrice.AutoSize = true;
            lblDeclarePrice.Location = new Point(30, 410);
            lblDeclarePrice.Name = "lblDeclarePrice";
            lblDeclarePrice.Size = new Size(0, 20);
            lblDeclarePrice.TabIndex = 17;
            // 
            // FormBlocket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDeclarePrice);
            Controls.Add(rdbHighestPrice);
            Controls.Add(lblMinPrice);
            Controls.Add(lblMaxPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblSearch);
            Controls.Add(nudMinPrice);
            Controls.Add(rdbLowestPrice);
            Controls.Add(nudMaxPrice);
            Controls.Add(rdbNewFirst);
            Controls.Add(rdbOldFirst);
            Controls.Add(btnSearch);
            Controls.Add(cmbFilter);
            Controls.Add(btnLogin);
            Controls.Add(btnCreate);
            Controls.Add(txtSearch);
            Controls.Add(listBoxResult);
            Name = "FormBlocket";
            Text = "BlocketADO.NET";
            Load += FormBlocket_Load;
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResult;
        private TextBox txtSearch;
        private Button btnCreate;
        private Button btnLogin;
        private ComboBox cmbFilter;
        private Button btnSearch;
        private RadioButton rdbOldFirst;
        private RadioButton rdbNewFirst;
        private NumericUpDown nudMaxPrice;
        private RadioButton rdbLowestPrice;
        private NumericUpDown nudMinPrice;
        private Label lblSearch;
        private Label lblCategory;
        private Label lblMaxPrice;
        private Label lblMinPrice;
        private RadioButton rdbHighestPrice;
        private Label lblDeclarePrice;
    }
}
