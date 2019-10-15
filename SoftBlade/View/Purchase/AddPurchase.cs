using SoftBlade.DB;
using SoftBlade.Model;
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

namespace SoftBlade.View.Purchase
{
    public partial class AddPurchase : MetroFramework.Forms.MetroForm
    {
        PurchaseModel purchaseModel = new PurchaseModel();
        PurchaseDetailModel purchaseDetailModel = new PurchaseDetailModel();
        SqlCommand command;


        public AddPurchase(int id)
        {
            InitializeComponent();

            FillNIT();
            FillCode();
            FillProvider();

            FillProductCode();
            FillProductName();

        }


        #region Product

      
        public void FillProductCode()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("ListProductCode", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProduct = new DataTable();
                sqlData.Fill(dtProduct);
                cmbCodeProduct.DataSource = dtProduct;
                cmbCodeProduct.DisplayMember = "code";
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }

        public void FillProductName()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("ListProductName", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProduct = new DataTable();
                sqlData.Fill(dtProduct);
                cmbProduct.DataSource = dtProduct;
                cmbProduct.DisplayMember = "name";
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }
        #endregion


        #region ProductEvents
        private void cmbCodeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("ListProductAllWithCode", Connection.SqlConnection())
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@_productCode", cmbCodeProduct.Text);
                command.Parameters.Add("@_productCodeOutput", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@_productName", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@_productQuantity", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@_productID", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                //Recibe
                //cmbCodeProduct.Text = command.Parameters["@providerCode"].Value.ToString();
                cmbProduct.Text = command.Parameters["@_productName"].Value.ToString();
                purchaseDetailModel.ProductID = (int)command.Parameters["@_productID"].Value;
                MessageBox.Show(purchaseModel.ProviderID + "");
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }
        #endregion

        #region Providers
        public void FillNIT()
       {
            try
            {

                SqlDataAdapter sqlData = new SqlDataAdapter("ListProviderNIT", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbNIT.DataSource = dtProvider;
                cmbNIT.DisplayMember = "nit";

                
                
                /*SqlCommand mySqlCommand = new SqlCommand("select nit from Provider where Status='Ingresado'", Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = mySqlCommand.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (myReader.Read())
                {
                    string nit = myReader.GetString(0);
                    cmbNIT.Items.Add(nit);
                }
                cmbNIT.AutoCompleteCustomSource = MyCollection;*/
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }


        public void FillCode()
        {
            try
            {

                SqlDataAdapter sqlData = new SqlDataAdapter("ListProviderCode", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbCodeProvider.DataSource = dtProvider;
                cmbCodeProvider.DisplayMember = "code";
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();               
                cmbCodeProvider.AutoCompleteCustomSource = MyCollection;
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }


        public void FillProvider()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("ListProviderName", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbProvider.DataSource = dtProvider;
                cmbProvider.DisplayMember = "name";
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                cmbProvider.AutoCompleteCustomSource = MyCollection; 
            }
            finally
            {
                Connection.SqlConnection().Close();
            }

        }
        #endregion



        #region ProviderEvents

        private void cmbNIT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("ListProviderAllNIT", Connection.SqlConnection())
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@providerNIT", cmbNIT.Text);
                command.Parameters.Add("@providerNITOutput", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@providerCode", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@providerName", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                command.Parameters.Add("@providerID", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                //Recibe
                cmbCodeProvider.Text = command.Parameters["@providerCode"].Value.ToString();
                cmbProvider.Text = command.Parameters["@providerName"].Value.ToString();
                purchaseModel.ProviderID = (int)command.Parameters["@providerID"].Value;
                MessageBox.Show(purchaseModel.ProviderID+"");
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }
        #endregion




        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider();
            addProvider.ShowDialog();
            FillNIT();
            FillCode();
            FillProvider();
        }

   
    }
}
