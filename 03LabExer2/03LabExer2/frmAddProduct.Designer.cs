namespace _03LabExer2
{
    partial class frmAddProduct
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelMfg;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelSell;
        private System.Windows.Forms.Label labelDesc;

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellPrice;

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gridViewProductList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelProduct = new Label();
            labelCategory = new Label();
            labelMfg = new Label();
            labelExp = new Label();
            labelQty = new Label();
            labelSell = new Label();
            labelDesc = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(126, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Add Product";
            // 
            // labelProduct
            // 
            labelProduct.Location = new Point(30, 60);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(64, 23);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Product";
            // 
            // labelCategory
            // 
            labelCategory.Location = new Point(30, 90);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(64, 23);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category";
            // 
            // labelMfg
            // 
            labelMfg.Location = new Point(30, 120);
            labelMfg.Name = "labelMfg";
            labelMfg.Size = new Size(64, 23);
            labelMfg.TabIndex = 3;
            labelMfg.Text = "Mfg. Date";
            // 
            // labelExp
            // 
            labelExp.Location = new Point(30, 150);
            labelExp.Name = "labelExp";
            labelExp.Size = new Size(64, 23);
            labelExp.TabIndex = 4;
            labelExp.Text = "Exp. Date";
            // 
            // labelQty
            // 
            labelQty.Location = new Point(30, 180);
            labelQty.Name = "labelQty";
            labelQty.Size = new Size(64, 23);
            labelQty.TabIndex = 5;
            labelQty.Text = "Qty.";
            // 
            // labelSell
            // 
            labelSell.Location = new Point(30, 210);
            labelSell.Name = "labelSell";
            labelSell.Size = new Size(64, 23);
            labelSell.TabIndex = 6;
            labelSell.Text = "Sell Price";
            // 
            // labelDesc
            // 
            labelDesc.Location = new Point(350, 60);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(74, 23);
            labelDesc.TabIndex = 7;
            labelDesc.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(100, 58);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(100, 178);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 12;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(100, 208);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(200, 23);
            txtSellPrice.TabIndex = 13;
            // 
            // cbCategory
            // 
            cbCategory.Location = new Point(100, 88);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 23);
            cbCategory.TabIndex = 9;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(100, 118);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(200, 23);
            dtPickerMfgDate.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(100, 148);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(200, 23);
            dtPickerExpDate.TabIndex = 11;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(430, 58);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(280, 150);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(640, 210);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.Location = new Point(20, 250);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(720, 220);
            gridViewProductList.TabIndex = 16;
            // 
            // Form1
            // 
            ClientSize = new Size(760, 500);
            Controls.Add(labelTitle);
            Controls.Add(labelProduct);
            Controls.Add(labelCategory);
            Controls.Add(labelMfg);
            Controls.Add(labelExp);
            Controls.Add(labelQty);
            Controls.Add(labelSell);
            Controls.Add(labelDesc);
            Controls.Add(txtProductName);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(dtPickerExpDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtSellPrice);
            Controls.Add(richTxtDescription);
            Controls.Add(btnAddProduct);
            Controls.Add(gridViewProductList);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
