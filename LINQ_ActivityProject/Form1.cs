using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_ActivityProject
{
    public partial class Form1 : Form
    {
        DataTable customerList = new DataTable();
        DataTable productList = new DataTable();
        DataTable salesTransaction = new DataTable();
        int SalesID = 0;
        string message;

        /// <summary>
        /// //This is a change to the file
        /// im cute
        /// </summary>

        //int CustomerAge;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, System.EventArgs e)
        {
            //DataTAble for Customer List
            //HEaders
            customerList.Columns.Add("CustomerID", typeof(int));
            customerList.Columns.Add("CustomerName", typeof(string));
            customerList.Columns.Add("ContactNo", typeof(string));
            // Rows 
            customerList.Rows.Add(1, "Evelyn Turner", "0988-888-8888");
            customerList.Rows.Add(2, "Leo Bennett", "0977-777-7777");
            customerList.Rows.Add(3, "Sophia Foster", "0966-666-6666");
            customerList.Rows.Add(4, "Nathan Hayes", "0955-55-5555");
            customerList.Rows.Add(5, "Isabella Murphy", "0944-444-4444");
            customerList.Rows.Add(6, "Oliver Collins", "0933-333-333");
            customerList.Rows.Add(7, "Lily Parker", "0922-222-222");
            customerList.Rows.Add(8, "Ava Reed", "0911-111-1111");

            CustomerComBo.DataSource = customerList;
            CustomerComBo.DisplayMember = "CustomerName";






            //DataTable for Products

            productList.Columns.Add("ProductID", typeof(int));
            productList.Columns.Add("ProductName", typeof(string));
            productList.Columns.Add("ProductCategory", typeof(string));
            productList.Columns.Add("Price", typeof(double));



            productList.Rows.Add(101, "Manila Mango Delight", "Food", 150.00);
            productList.Rows.Add(102, "Barako Brew Coffee", "Beverages", 170.00);
            productList.Rows.Add(103, "Tropical Breeze Soap", "Personal Care", 100.00);
            productList.Rows.Add(104, "Palawan Pearl Earrings", "Accessories", 300.00);
            productList.Rows.Add(105, "Sampaguita Scented Candle ", "Home & Living", 250.00);
            productList.Rows.Add(106, "Cebu Seashell Necklace", "Accessories", 550.00);
            productList.Rows.Add(107, "Ilocos Salted Crisps", "Food", 70.00);
            productList.Rows.Add(108, "Pineapple Paradise Lip Balm", "Beauty", 185.00);
            productList.Rows.Add(109, "Buko Pandan Ice Cream", "Food", 225.00);
            productList.Rows.Add(110, "Taho Soap", "Personal Care", 190.00);


            ProductCombo.DataSource = productList;
            ProductCombo.DisplayMember = "ProductName";





            salesTransaction.Columns.Add("SalesID", typeof(int));
            salesTransaction.Columns.Add("CustomerID", typeof(int));
            salesTransaction.Columns.Add("CustomerName", typeof(string));
            salesTransaction.Columns.Add("ContactNo", typeof(string));

            salesTransaction.Columns.Add("ProductID", typeof(int));
            salesTransaction.Columns.Add("ProductName", typeof(string));
            salesTransaction.Columns.Add("ProductCategory", typeof(string));
            salesTransaction.Columns.Add("Price", typeof(double));
            salesTransaction.Columns.Add("QtySold", typeof(int));
            salesTransaction.Columns.Add("TotalAmount", typeof(double));
            salesTransaction.Columns.Add("TransactionDate", typeof(DateTime));




            SalesDataGridView.DataSource = salesTransaction;

        }

        private void CustomerComBo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCustomer = from customer in customerList.AsEnumerable()
                                   where customer.Field<string>("CustomerName") == CustomerComBo.Text
                                   select new
                                   {
                                       Custid = customer.Field<int>("CustomerID"),
                                       Custcontact = customer.Field<string>("ContactNo")
                                   };

            foreach (var id in selectedCustomer)
            {
                CustomerNumTB.Text = id.Custcontact;
                CustomerIDTB.Text = id.Custid.ToString();

            }


        }

        private void ProductCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedProduct = from product in productList.AsEnumerable()
                                  where product.Field<string>("ProductName") == ProductCombo.Text
                                  select new
                                  {
                                      Proid = product.Field<int>("ProductID"),
                                      ProCat = product.Field<string>("ProductCategory"),
                                      ProPrice = product.Field<double>("Price")
                                  };

            foreach (var id in selectedProduct)
            {

                ProductIDTB.Text = id.Proid.ToString();
                ProdCatTB.Text = id.ProCat;
                PriceTB.Text = id.ProPrice.ToString();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ProductQtyTB_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void button7_Click(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void DailySalesRep_Click(object sender, System.EventArgs e)
        {
            DailySalesForm dailysales = new DailySalesForm(salesTransaction);
            dailysales.ShowDialog();
        }

        private void SalesByProCat_Click(object sender, System.EventArgs e)
        {
            message = null;

            var SalesByProductCategory = salesTransaction.AsEnumerable()
                                     .GroupBy(sales => sales.Field<string>("ProductCategory"))
                                      .Select(group => new
                                      {
                                          ProductCategory = group.Key,
                                          ProductName = string.Join(", ", group.Select(x => x.Field<string>("ProductName")).Distinct()),
                                          TotalQuantitySold = group.Sum(row => row.Field<int>("QtySold"))
                                      });


        }

        private void SalesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



