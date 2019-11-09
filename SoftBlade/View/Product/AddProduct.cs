using SoftBlade.DB;
using SoftBlade.Model;
using SoftBlade.View.Category;
using SoftBlade.View.Provider;
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
    public partial class AddProduct : MetroFramework.Forms.MetroForm
    {
      

        ProductModel productModel = new ProductModel();
        SqlCommand sqlCommand;
        SqlDataAdapter sqlData;



        public AddProduct()
        {
            InitializeComponent();
            ComboboxFillCategory();
            ComboboxFillProvider();
        }


        //Category
        public void ComboboxFillCategory()
        {
            sqlData = new SqlDataAdapter("ListCategory", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtCategory = new DataTable();
            sqlData.Fill(dtCategory);
            cmbCategory.DataSource = dtCategory;
            cmbCategory.DisplayMember = "nombre";
         //   AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
         //   cmbCategory.AutoCompleteCustomSource = MyCollection;

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
         

            sqlCommand = new SqlCommand("select CategoryID from Category where  name='" + cmbCategory.Text + "'", Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = sqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string id = myReader.GetInt32(0).ToString();
                    productModel.CategoryID = int.Parse(id);
                }
            

        }



        //Provider
        public void ComboboxFillProvider()
        {
            //   MySqlDataAdapter sqlData = new MySqlDataAdapter();
            sqlCommand = new SqlCommand("select name from Provider  where Status='Ingresado' ", Connection.SqlConnection());
            SqlDataReader myReader;
            try
            {            
                myReader = sqlCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    cmbProvider.Items.Add(name);
                }
            }catch (Exception)
            {
                
            }

        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvider.SelectedIndex == 0)
            {
                AddProvider addProvider = new AddProvider();
                addProvider.ShowDialog();
                ComboboxFillProvider();
            }
            else
            {
                try
                {                
                    sqlCommand = new SqlCommand("select ProviderID from Provider where name='" + cmbProvider.Text + "'", Connection.SqlConnection());
                    SqlDataReader myReader;
                    myReader = sqlCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        string id = myReader.GetInt32(0).ToString();
                        productModel.ProviderID = int.Parse(id);
                    }
                }finally{
                    Connection.SqlConnection().Close();
                }
            }

        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            productModel.Code = txtCode.Text;
            productModel.Name = txtName.Text;
            productModel.Description = rtDescription.Text;
            productModel.Units = int.Parse(txtUnit.Text);
           // productModel.Price = decimal.Parse(txtPrice.Text);
          //  productModel.Image = openFileDialog.FileName;
          //  productModel.PriceSale = decimal.Parse(txtPriceSale.Text);
            //productModel.Gain = productModel.PriceSale - productModel.Price;
            SqlCommand command = new SqlCommand("GenerateCodeProducts", Connection.SqlConnection());
            if (checkBox1.Checked)
            {
                productModel.Code = "";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_code", productModel.Code);
                command.Parameters.AddWithValue("_name", productModel.Name);
                command.Parameters.AddWithValue("_description", productModel.Description);
                command.Parameters.AddWithValue("_box", productModel.Quantity);
                command.Parameters.AddWithValue("_price", productModel.Price);

                command.Parameters.AddWithValue("_SalePrice", productModel.PriceSale);
                command.Parameters.AddWithValue("_gain", productModel.Gain);
                command.Parameters.AddWithValue("_units", productModel.Units);
                command.Parameters.AddWithValue("_CategoryID", productModel.CategoryID);
                command.Parameters.AddWithValue("_ProviderID", productModel.ProviderID);
                command.Parameters.AddWithValue("_automatically", false);
                
                    command.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Exitosamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
              

            }
            else
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_code", productModel.Code);
                command.Parameters.AddWithValue("_name", productModel.Name);
                command.Parameters.AddWithValue("_description", productModel.Description);
                command.Parameters.AddWithValue("_box", productModel.Quantity);
                command.Parameters.AddWithValue("_price", productModel.Price);

                command.Parameters.AddWithValue("_SalePrice", productModel.PriceSale);
                command.Parameters.AddWithValue("_gain", productModel.Gain);
                command.Parameters.AddWithValue("_units", productModel.Units);
                command.Parameters.AddWithValue("_image", productModel.Image);
                command.Parameters.AddWithValue("_CategoryID", productModel.CategoryID);
                command.Parameters.AddWithValue("_ProviderID", productModel.ProviderID);
                command.Parameters.AddWithValue("_automatically", true);
                
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Agregado Exitosamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
              

            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            ComboboxFillCategory();
        }
    }
}
