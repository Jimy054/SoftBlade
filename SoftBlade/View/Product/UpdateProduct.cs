using SoftBlade.DB;
using SoftBlade.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftBlade.View.Product
{
    public partial class UpdateProduct : MetroFramework.Forms.MetroForm
    {
        ProductModel productModel = new ProductModel();

        public UpdateProduct(int id, string code, string name, string description, int quantity, int unit, decimal price, float priceSale, decimal gain, int categoryID, int providerID)
        {
            var total = (priceSale*0.25) + priceSale;
            InitializeComponent();
            txtCode.Text = code;
            txtName.Text = name;
            rtDescription.Text = description;
            txtUnit.Text = unit.ToString();
            txtPrice.Text = price.ToString();           
            txtSalePrice.Text = total.ToString();
            lblGain.Text = gain.ToString();
            productModel.ProviderID = providerID;
            productModel.CategoryID = categoryID;
            SearchCategory();
            SearchProvider();
            ComboboxFillCategory();
            ComboboxFillProvider();
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
                SqlCommand mySqlCommand = new SqlCommand("select name from Categories", Connection.SqlConnection());
                SqlDataReader myReader;
                try
                {
                    myReader = mySqlCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        string name = myReader.GetString(0);
                        cmbCategory.Items.Add(name);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                Connection.SqlConnection().Close();
            }

        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand mySqlCommand = new SqlCommand("select CategoryID from Category where name='" + cmbCategory.Text + "'", Connection.MakeConnection());
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
            SqlCommand mySqlCommand = new SqlCommand("select ProviderID from Provider where name='" + cmbProvider.Text + "'", Connection.MakeConnection());
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
            productModel.PriceSale = float.Parse(txtSalePrice.Text);
            productModel.Gain = productModel.PriceSale - productModel.Price;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_ProductID", productModel.ProductID);
            command.Parameters.AddWithValue("_code", productModel.Code);
            command.Parameters.AddWithValue("_name", productModel.Name);
            command.Parameters.AddWithValue("_description", productModel.Description);
       //     command.Parameters.AddWithValue("_box", productModel.Quantity);
            command.Parameters.AddWithValue("_price", productModel.Price);
            command.Parameters.AddWithValue("_SalePrice", productModel.PriceSale);
          //  command.Parameters.AddWithValue("_gain", productModel.Gain);
            command.Parameters.AddWithValue("_units", productModel.Units);
            command.Parameters.AddWithValue("_CategoryID", productModel.CategoryID);
            command.Parameters.AddWithValue("_ProviderID", productModel.ProviderID);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado Exitosamente", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Código Repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
