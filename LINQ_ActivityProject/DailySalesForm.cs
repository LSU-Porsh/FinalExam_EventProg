using System;
using System.Data;
using System.Windows.Forms;

namespace LINQ_ActivityProject
{ 
    public partial class DailySalesForm : Form

 
    {

        DataTable salesData = new DataTable();
        DataTable DailySalesData = new DataTable();

        public DailySalesForm(DataTable sales)
        {
            InitializeComponent();

            salesData = sales;

            DailySalesData.Columns.Add("TransactionDate", typeof(DateTime));
            DailySalesData.Columns.Add("SalesID", typeof(int));
            DailySalesData.Columns.Add("CustomerName", typeof(string));
            DailySalesData.Columns.Add("ProductID", typeof(int));
            DailySalesData.Columns.Add("ProductName", typeof(string));
            DailySalesData.Columns.Add("ProductCategory", typeof(string));
            DailySalesData.Columns.Add("QtySold", typeof(int));
            DailySalesData.Columns.Add("TotalAmount", typeof(double));



        }

        private void GenerateDailySales_Click(object sender, EventArgs e)
        {


            DailySalesData.Clear();

            var dailysales = salesData.AsEnumerable()
                             .Where(s => s.Field<DateTime>("TransactionDate") == DateTime.Parse(SalesDatePicker.Text))
                               .Select(sales => new
                               {
                                   salesDate = sales.Field<DateTime>("TransactionDate"),
                                   salesID = sales.Field<int>("SalesID"),
                                   salesCustName = sales.Field<string>("CustomerName"),
                                   salesProdID = sales.Field<int>("ProductID"),
                                   salesProdName = sales.Field<string>("ProductName"),
                                   salesProdCat = sales.Field<string>("ProductCategory"),
                                   salesQty = sales.Field<int>("QtySold"),
                                   salesTotal = sales.Field<double>("TotalAmount")
                               });


            foreach (var sales in dailysales)
            {

                DailySalesData.Rows.Add(sales.salesDate, sales.salesID, sales.salesCustName, sales.salesProdID, sales.salesProdName,
                    sales.salesProdCat, sales.salesQty, sales.salesTotal);
            }

            DailySalesGrid.DataSource = DailySalesData;






        }
    }
}
