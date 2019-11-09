using SoftBlade.DB;
using SoftBlade.Model;
using SoftBlade.View.Product;
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
        SqlDataAdapter sqlData;
        float price,price1;
        int quantity;
        double iva,withoutIva;
        float discount;

        public AddPurchase(int id)
        {
            InitializeComponent();

            
            btnAddDetails.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            //cmbDiscount.Visible = false;
          

            purchaseDetailModel.PurchaseID = id;
            purchaseModel.PurchaseID = id;
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
                sqlData = new SqlDataAdapter("ListProduct", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProduct = new DataTable();
                sqlData.Fill(dtProduct);
                cmbCodeProduct.DataSource = dtProduct;
                cmbCodeProduct.DisplayMember = "Codigo";
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
                sqlData = new SqlDataAdapter("ListProduct", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProduct = new DataTable();
                sqlData.Fill(dtProduct);
                cmbProduct.DataSource = dtProduct;
                cmbProduct.DisplayMember = "Nombre";
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
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }



        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            FillProductCode();
            FillProductName();

        }

        #endregion





        #region Providers
        public void FillNIT()
       {
            try
            {

                sqlData = new SqlDataAdapter("ListProvider", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbNIT.DataSource = dtProvider;
                cmbNIT.DisplayMember = "NIT";

                
                
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
                sqlData = new SqlDataAdapter("ListProvider", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbCodeProvider.DataSource = dtProvider;
                cmbCodeProvider.DisplayMember = "Codigo";
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
                sqlData = new SqlDataAdapter("ListProvider", Connection.SqlConnection());
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProvider = new DataTable();
                sqlData.Fill(dtProvider);
                cmbProvider.DataSource = dtProvider;
                cmbProvider.DisplayMember = "Nombre";
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
                command = new SqlCommand("select ProviderID,NIT,Code,Name from Provider where nit='" + cmbNIT.Text + "'", Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    string providerID = myReader.GetInt32(0).ToString();
                    string nit = myReader.GetString(1);
                    string code = myReader.GetString(2);
                    string name = myReader.GetString(3);
                    //   string name = myReader.GetString("Name");
                    // cmbProvider.Text = name;
                    purchaseModel.ProviderID = int.Parse(providerID);
                   // cmbNIT.Text = nit;
                    cmbCodeProvider.Text = code;
                    cmbProvider.Text = name;
                }
                /*
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
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();*/
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }

        private void cmbCodeProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select ProviderID,NIT,Code,Name from Provider where code='" + cmbCodeProvider.Text + "'", Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    string providerID = myReader.GetInt32(0).ToString();
                    string nit = myReader.GetString(1);
                    string code = myReader.GetString(2);
                    string name = myReader.GetString(3);
                    //   string name = myReader.GetString("Name");
                    // cmbProvider.Text = name;
                    purchaseModel.ProviderID = int.Parse(providerID);
                    cmbNIT.Text = nit;
                    cmbCodeProvider.Text = code;
                    cmbProvider.Text = name;
                }
                /*
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
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();*/
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }


        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select ProviderID,NIT,Code,Name from Provider where name='" + cmbProvider.Text + "'", Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    string providerID = myReader.GetInt32(0).ToString();
                    string nit = myReader.GetString(1);
                    string code = myReader.GetString(2);
                    string name = myReader.GetString(3);
                    //   string name = myReader.GetString("Name");
                    // cmbProvider.Text = name;
                    purchaseModel.ProviderID = int.Parse(providerID);
                    cmbNIT.Text = nit;
                    cmbCodeProvider.Text = code;
                    cmbProvider.Text = name;
                }
                /*
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
                // cmbNIT.Text = command.Parameters["@providerNITOutput"].Value.ToString();*/
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }



        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider();
            addProvider.ShowDialog();
            FillNIT();
            FillCode();
            FillProvider();
        }
        #endregion



        #region Button
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand("GeneratePurchaseDetail", Connection.SqlConnection());
                if (txtPrice.Text == "")
                {
                    purchaseDetailModel.Price = 0;
                }
                else
                {
                    purchaseDetailModel.Price = float.Parse(txtPrice.Text);
                }

                if (txtQuantity.Text == "")
                {
                    purchaseDetailModel.Quantity = 0;
                }
                else
                {
                    purchaseDetailModel.Quantity = int.Parse(txtQuantity.Text);
                }



                purchaseDetailModel.Observation = rtObservation.Text;

               
                purchaseDetailModel.IVA = float.Parse(lblIVA.Text);
                purchaseDetailModel.PriceWithoutIVA = float.Parse(lblWithoutIVA.Text);

                purchaseDetailModel.SubTotal = purchaseDetailModel.Quantity * purchaseDetailModel.Price - purchaseDetailModel.Discount;
                
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_Price", purchaseDetailModel.Price);
                command.Parameters.AddWithValue("_Quantity", purchaseDetailModel.Quantity);
                command.Parameters.AddWithValue("_IVA", purchaseDetailModel.IVA);
                command.Parameters.AddWithValue("_PriceWithoutIVA", purchaseDetailModel.PriceWithoutIVA);
                command.Parameters.AddWithValue("_SubTotal", purchaseDetailModel.SubTotal);
                command.Parameters.AddWithValue("_PurchaseID", purchaseDetailModel.PurchaseID);
                command.Parameters.AddWithValue("_ProductID", purchaseDetailModel.ProductID);
                command.Parameters.AddWithValue("_Observation", purchaseDetailModel.Observation);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Exitosamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew.Enabled = true;
                GridFill();
                GetTotal();
                Clear();
            }

            finally
            {
                Connection.SqlConnection().Close();
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UpdatePurchase", Connection.SqlConnection());
                purchaseModel.PurchaseReference = txtReference.Text;
                purchaseModel.PurchaseDate = DateTime.Parse(dtDate.Text);
                purchaseModel.PriceWithoutIVA = float.Parse(lblWithoutIVA.Text);
                purchaseModel.IVA = float.Parse(lblIVA.Text);
                purchaseModel.Serie = txtSerie.Text;
                if (ckGenerateCode.Checked)
                {

                    purchaseModel.PurchaseReference = "";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_Serie", purchaseModel.Serie);
                    command.Parameters.AddWithValue("_PurchaseID", purchaseModel.PurchaseID);
                    command.Parameters.AddWithValue("_PurchaseReference", purchaseModel.PurchaseReference);
                    command.Parameters.AddWithValue("_PurchaseDate", purchaseModel.PurchaseDate);
                    command.Parameters.AddWithValue("_ProviderID", purchaseModel.ProviderID);

                    command.Parameters.AddWithValue("_PriceWithoutIVA", purchaseModel.PriceWithoutIVA);
                    command.Parameters.AddWithValue("_IVA", purchaseModel.PriceWithoutIVA);
                    command.Parameters.AddWithValue("_ProviderID", purchaseModel.ProviderID);

                    command.Parameters.AddWithValue("_automatically", false);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Factura Agregada Exitosamente", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_Serie", purchaseModel.Serie);
                    command.Parameters.AddWithValue("_PurchaseID", purchaseModel.PurchaseID);
                    command.Parameters.AddWithValue("_PurchaseReference", purchaseModel.PurchaseReference);
                    command.Parameters.AddWithValue("_PurchaseDate", purchaseModel.PurchaseDate);
                    command.Parameters.AddWithValue("_ProviderID", purchaseModel.ProviderID);

                    command.Parameters.AddWithValue("_automatically", true);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Factura Agregada Exitosamente", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Methods
        public void GridFill()
        {
            try
            {
                sqlData = new SqlDataAdapter("ListPurchaseDetail", Connection.SqlConnection());
                sqlData.SelectCommand.Parameters.AddWithValue("_PurchaseID", purchaseDetailModel.PurchaseID);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtProduct = new DataTable();
                sqlData.Fill(dtProduct);
                gridPurchase.DataSource = dtProduct;
                DataGridViewColumn column = gridPurchase.Columns[0];
                column.Visible = false;

                for (int i = 0; i < 5; i++)
                {
                    DataGridViewColumn column1 = gridPurchase.Columns[i];
                    column1.Width = 108;
                }
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }

        public void Clear()
        {

            cmbProduct.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
         //   txtDiscount.Text = "";
        //    lblTotal.Text = "";
            cmbCodeProduct.Text = "";
            rtObservation.Text = "";
        }

        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            /*
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }



        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

       



        public void GetTotal()
        {
            try
            {
                float total;
                SqlCommand mySqlCommand = new SqlCommand("select purchaseTotal from Purchase where PurchaseID="+purchaseModel.PurchaseID, Connection.SqlConnection());
                SqlDataReader myReader;
                myReader = mySqlCommand.ExecuteReader();
               
                // AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (myReader.Read())
                {
                    total = myReader.GetFloat(0);
                    MessageBox.Show("Total "+total);
                    lblTotal.Text = total.ToString();

                }
            }
            finally
            {
                Connection.SqlConnection().Close();
            }
        }

        public void ValidatePurchasesDetails()
        {
            if (cmbCodeProduct.Text == "" && txtQuantity.Text == "" && txtPrice.Text == ""  && cmbCodeProduct.Text == "")
            {
                btnAddDetails.Enabled = false;
            }
            else
            {
                btnAddDetails.Enabled = true;
            }
        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            ValidatePurchasesDetails();

            if (txtQuantity.Text == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = int.Parse(txtQuantity.Text);
            }

            withoutIva = Math.Round(((price * quantity - discount) / 1.12), 2);
            iva = Math.Round(withoutIva * .12, 2);

            lblWithoutIVA.Text = withoutIva.ToString();
            lblIVA.Text = iva.ToString();

            lblSublTotal.Text = (price * quantity- discount).ToString();
        }

    

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            ValidatePurchasesDetails();

            if (txtPrice.Text == "")
            {
                price = 0.00f;
            }
            else
            {
                price = float.Parse(txtPrice.Text);
            }

            withoutIva = Math.Round(( (price * quantity - discount) / 1.12), 2);
            iva = Math.Round(withoutIva * .12, 2);

            lblWithoutIVA.Text = withoutIva.ToString();
            lblIVA.Text = iva.ToString();



            lblSublTotal.Text = (price * quantity- discount).ToString();
        }

      /*  private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                discount = 0;
            }
            else
            {
                discount = float.Parse(txtDiscount.Text);
                withoutIva = Math.Round(((price * quantity - discount) / 1.12), 2);
                iva = Math.Round(withoutIva * .12, 2);
                lblWithoutIVA.Text = withoutIva.ToString();
                lblIVA.Text = iva.ToString();


                MessageBox.Show("Descuento" + (price - discount).ToString());



                lblSublTotal.Text = (price * quantity-discount).ToString();
                /*price1 = price;

                withoutIva = Math.Round((price1 * quantity / 1.12), 2);
                iva = Math.Round(withoutIva * .12, 2);
                MessageBox.Show("IVA Descuento" +iva);
                MessageBox.Show("Sin iva descuento" + withoutIva);
                

            }
        }*/

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
           
          


          //  lblSublTotal.Text = (price * quantity - discount).ToString();
        }




        #endregion

      
    }
}
