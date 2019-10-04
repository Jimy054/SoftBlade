using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SoftBlade.DB;
using SoftBlade.Model;

namespace SoftBlade.View.Product
{
    public partial class ProductView : MetroFramework.Controls.MetroUserControl
    {

        ProductModel productModel = new ProductModel();
        enum Search { Name, Code }
        Search name, code;
        DataTable dtProduct;
        public ProductView()
        {
            InitializeComponent();
            GridFill();
        }


        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListProduct", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtProduct = new DataTable();
            sqlData.Fill(dtProduct);
            productGrid.DataSource = dtProduct;
            DataGridViewColumn column = productGrid.Columns[0];
            column.Visible = false;
            for (int i = 0; i <= 12; i++)
            {

                DataGridViewColumn column1 = productGrid.Columns[i];
                if (column1 == productGrid.Columns[11])
                {
                    column1.Visible = false;
                }

                if (column1 == productGrid.Columns[12])
                {
                    column1.Visible = false;
                }
                column1.Width = 82;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("CanceledProduct"))
            {
                CanceledProduct canceledProduct = new CanceledProduct
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(canceledProduct);
            }
            Form1.Instance.MetroPanel.Controls["CanceledProduct"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct(productModel.ProductID, productModel.Code, productModel.Name, productModel.Description, productModel.Quantity, productModel.Units, productModel.Price, productModel.PriceSale, productModel.Gain, productModel.CategoryID, productModel.ProviderID);
            updateProduct.ShowDialog();
            GridFill();
        }

        private void productGrid_Click(object sender, EventArgs e)
        {
            try
            {

                if (productGrid.CurrentRow.Index != -1)
                {

                    // MemoryStream memoryStream = new MemoryStream();
                    //  byte[] img = (byte[])productGrid.;

                    productModel.Code = productGrid.CurrentRow.Cells[1].Value.ToString();
                    productModel.Name = productGrid.CurrentRow.Cells[2].Value.ToString();
                    productModel.Description = productGrid.CurrentRow.Cells[3].Value.ToString();
                   // productModel.Quantity = int.Parse(productGrid.CurrentRow.Cells[4].Value.ToString());
                    productModel.Units = int.Parse(productGrid.CurrentRow.Cells[5].Value.ToString());
                    productModel.Price = decimal.Parse(productGrid.CurrentRow.Cells[6].Value.ToString());
                    productModel.PriceSale = decimal.Parse(productGrid.CurrentRow.Cells[7].Value.ToString());
                    productModel.Gain = decimal.Parse(productGrid.CurrentRow.Cells[8].Value.ToString());
                    productModel.CategoryID = int.Parse(productGrid.CurrentRow.Cells[11].Value.ToString());
                    productModel.ProviderID = int.Parse(productGrid.CurrentRow.Cells[12].Value.ToString());
                    //pictureBox1. = productGrid.CurrentRow.Cells[5].Value.ToString();
                    productModel.ProductID = Convert.ToInt32(productGrid.CurrentRow.Cells[0].Value.ToString());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de escoger un código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
