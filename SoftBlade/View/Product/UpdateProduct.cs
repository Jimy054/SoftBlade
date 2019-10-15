using SoftBlade.DB;
using SoftBlade.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftBlade.View.Product
{
    public partial class UpdateProduct : MetroFramework.Forms.MetroForm
    {
        ProductModel productModel = new ProductModel();
        decimal price1, price2;
        NumberFormatInfo setPrecision = new NumberFormatInfo();

       

        public UpdateProduct(int id, string code, string name, string description, int quantity, int unit, decimal price, decimal priceSale, decimal gain, int categoryID, int providerID)
        {
            setPrecision.NumberDecimalDigits = 2;

            var total = (priceSale*0.25m) + priceSale;

            InitializeComponent();
            productModel.ProductID = id;
            txtCode.Text = code;
            txtName.Text = name;
            rtDescription.Text = description;
            txtUnit.Text = unit.ToString();
            txtPrice.Text = price.ToString();
            MessageBox.Show("Total"+ total );
            txtSalePrice.Text = total.ToString("N", setPrecision);
            lblGain.Text = gain.ToString();
            productModel.ProviderID = providerID;
            productModel.CategoryID = categoryID;           
            ComboboxFillCategory();
            ComboboxFillProvider();
            SearchCategory();
            SearchProvider();
            MessageBox.Show("Provider "+providerID);

            MessageBox.Show("Category " + categoryID);
        }

        //Category
        #region Category

        private void SearchCategory()
        {
            SqlCommand mySqlCommand = new SqlCommand("select name from Category where CategoryID='" + productModel.CategoryID + "'", Connection.SqlConnection());
            SqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                string name = myReader.GetString(0).ToString();
                MessageBox.Show(name);
                cmbCategory.Text = name;
            }

        }


        public void ComboboxFillCategory()
        {
            try
            {            
                //   MySqlDataAdapter sqlData = new MySqlDataAdapter();
                SqlCommand mySqlCommand = new SqlCommand("select name from Category", Connection.SqlConnection());
                SqlDataReader myReader;
                
                    myReader = mySqlCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        string name = myReader.GetString(0);
                        cmbCategory.Items.Add(name);
                    }
                
                //    MessageBox.Show("Ocurrio un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                Connection.SqlConnection().Close();
            }

        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand mySqlCommand = new SqlCommand("select CategoryID from Category where name='" + cmbCategory.Text + "'", Connection.SqlConnection());
            SqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                string id = myReader.GetInt32(0).ToString();
                productModel.CategoryID = int.Parse(id);
            }

        }

        #endregion


        #region Provider

        private void SearchProvider()
        {
            SqlCommand mySqlCommand = new SqlCommand("select name from Provider where ProviderID='" + productModel.ProviderID + "'", Connection.SqlConnection());
            SqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                string name = myReader.GetString(0);
                cmbProvider.Text = name;
            }
        }

        public void ComboboxFillProvider()
        {
            //   MySqlDataAdapter sqlData = new MySqlDataAdapter();
            SqlCommand mySqlCommand = new SqlCommand("select name from Provider", Connection.SqlConnection());
            SqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                string name = myReader.GetString(0);
                cmbProvider.Items.Add(name);
            }

        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand mySqlCommand = new SqlCommand("select ProviderID from Provider where name='" + cmbProvider.Text + "'", Connection.SqlConnection());
            SqlDataReader myReader;
            myReader = mySqlCommand.ExecuteReader();
            while (myReader.Read())
            {
                string id = myReader.GetInt32(0).ToString();
                productModel.ProviderID = int.Parse(id);
            }
        }
        #endregion

                     
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("UpdateProduct", Connection.SqlConnection());
            productModel.Code = txtCode.Text;
            productModel.Name = txtName.Text;
            productModel.Description = rtDescription.Text;
          //  productModel.Quantity = int.Parse(txtQuantity.Text);
            productModel.Units = int.Parse(txtUnit.Text);
            productModel.Price = decimal.Parse(txtPrice.Text);
            productModel.PriceSale = decimal.Parse(txtSalePrice.Text);
            productModel.Gain = productModel.PriceSale - productModel.Price;

            MessageBox.Show("Code"+productModel.Code);
            MessageBox.Show("Name" + productModel.Name);
            MessageBox.Show("Description" + productModel.Description);
            MessageBox.Show("Unit" + productModel.Units);
            MessageBox.Show("price" + productModel.Price);
            MessageBox.Show("price sale" + productModel.PriceSale);
            MessageBox.Show("gain" + productModel.Gain);
            MessageBox.Show("product id" + productModel.ProductID);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_ProductID", productModel.ProductID);
            command.Parameters.AddWithValue("_code", productModel.Code);
            command.Parameters.AddWithValue("_name", productModel.Name);
            command.Parameters.AddWithValue("_description", productModel.Description);
            command.Parameters.AddWithValue("_box", 0);
            command.Parameters.AddWithValue("_price", productModel.Price);
            command.Parameters.AddWithValue("_SalePrice", productModel.PriceSale);
            command.Parameters.AddWithValue("_gain", productModel.Gain);
            command.Parameters.AddWithValue("_units", productModel.Units);
            command.Parameters.AddWithValue("_categoryID", productModel.CategoryID);
            command.Parameters.AddWithValue("_providerID", productModel.ProviderID);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado Exitosamente", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                throw;
            };
           
        }

        private void txtCode_Click(object sender, EventArgs e)
        {

        }


        private void txtPriceSale_TextChanged(object sender, EventArgs e)
        {
            if (txtSalePrice.Text == "")
            {
                price2 = 0.00M;
            }
            else
            {
                price2 = decimal.Parse(txtSalePrice.Text);
            }
            productModel.Gain = decimal.Parse(lblGain.Text = (price2 - price1).ToString());
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                price1 = 0.00M;
            }
            else
            {
                price1 = decimal.Parse(txtPrice.Text);
            }

            productModel.Gain = decimal.Parse(lblGain.Text = (price2 - price1).ToString());
        }


    }
}
