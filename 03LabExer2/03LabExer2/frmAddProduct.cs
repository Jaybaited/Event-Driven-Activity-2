using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace _03LabExer2
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;


        BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = {
                "Beverages","Bread/Bakery","Canned/Jarred Goods","Dairy",
                "Frozen Goods","Meat","Personal Care","Other"
            };
            foreach (string cat in ListOfProductCategory)
            {
                cbCategory.Items.Add(cat);
            }
        }

        class NumberFormatException : Exception
        {
            public NumberFormatException(string msg) : base(msg) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string msg) : base(msg) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string msg) : base(msg) { }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                throw new StringFormatException("Product Name must contain letters only.");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
                throw new NumberFormatException("Quantity must be numeric.");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Selling Price must be a valid number.");
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(
                    _ProductName, _Category, _MfgDate, _ExpDate,
                    _SellPrice, _Quantity, _Description));

                gridViewProductList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex) { MessageBox.Show(ex.Message); }
            catch (NumberFormatException ex) { MessageBox.Show(ex.Message); }
            catch (CurrencyFormatException ex) { MessageBox.Show(ex.Message); }
            finally
            {
            }
        }
    }

    public class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;

        public ProductClass(string ProductName, string Category,
            string MfgDate, string ExpDate,
            double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }

        public string productName { get => _ProductName; set => _ProductName = value; }
        public string category { get => _Category; set => _Category = value; }
        public string manufacturingDate { get => _ManufacturingDate; set => _ManufacturingDate = value; }
        public string expirationDate { get => _ExpirationDate; set => _ExpirationDate = value; }
        public string description { get => _Description; set => _Description = value; }
        public int quantity { get => _Quantity; set => _Quantity = value; }
        public double sellingPrice { get => _SellingPrice; set => _SellingPrice = value; }
    }
}
