namespace InlämningDatabas1.Forms
{
    partial class FormAdvert
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
            lblAdvertName = new Label();
            txtDescription = new TextBox();
            txtAdvertName = new TextBox();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            txtPrice = new TextBox();
            lblCategory = new Label();
            lblPrice = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblAdvertName
            // 
            lblAdvertName.AutoSize = true;
            lblAdvertName.Location = new Point(40, 28);
            lblAdvertName.Name = "lblAdvertName";
            lblAdvertName.Size = new Size(42, 20);
            lblAdvertName.TabIndex = 0;
            lblAdvertName.Text = "label";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(40, 116);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(427, 267);
            txtDescription.TabIndex = 1;
            // 
            // txtAdvertName
            // 
            txtAdvertName.Location = new Point(40, 66);
            txtAdvertName.Name = "txtAdvertName";
            txtAdvertName.Size = new Size(427, 27);
            txtAdvertName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(503, 66);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(259, 28);
            cmbCategory.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(580, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 38);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Changes and Close";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(503, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(259, 27);
            txtPrice.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(503, 43);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(503, 137);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Set price";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(580, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete advert";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormAdvert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(txtPrice);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(txtAdvertName);
            Controls.Add(txtDescription);
            Controls.Add(lblAdvertName);
            Name = "FormAdvert";
            Text = "Advert";
            Load += FormAdvert_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdvertName;
        private TextBox txtDescription;
        private TextBox txtAdvertName;
        private ComboBox cmbCategory;
        private Button btnSave;
        private TextBox txtPrice;
        private Label lblCategory;
        private Label lblPrice;
        private Button btnDelete;
    }
}