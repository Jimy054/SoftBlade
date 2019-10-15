using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftBlade.DB;
using System.Data.SqlClient;
using SoftBlade.Model;
using SoftBlade.View.Purchase;

namespace SoftBlade.View
{
    public partial class PurchaseView : MetroFramework.Controls.MetroUserControl
    {
        public PurchaseView()
        {
            InitializeComponent();
            GridFill();
        }


        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListPurchase", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtPurchase = new DataTable();
            sqlData.Fill(dtPurchase);


            purchaseGrid.DataSource = dtPurchase;
            DataGridViewColumn column = purchaseGrid.Columns[0];
            column.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                DataGridViewColumn column1 = purchaseGrid.Columns[i];
                column1.Width = 188;
            }
        }


        PurchaseModel purchaseModel = new PurchaseModel();
        string id;
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("GenerateCodePurchase", Connection.SqlConnection());
                command.Parameters.AddWithValue("_PurchaseDate", DBNull.Value);
                command.Parameters.AddWithValue("_PurchaseTotal", DBNull.Value);
                command.Parameters.AddWithValue("_PurchaseReference", DBNull.Value);
                command.Parameters.AddWithValue("_ProviderID", DBNull.Value);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                SqlCommand mySqlCommand = new SqlCommand("select PurchaseID from Purchase", Connection.SqlConnection());
                SqlDataReader myReader;

                myReader = mySqlCommand.ExecuteReader();

                while (myReader.Read())
                {
                    id = myReader.GetInt32(0).ToString();
                    ///   MessageBox.Show("ID: "+id);

                }

                int providerID = int.Parse(id);
                AddPurchase purchaseView = new AddPurchase(providerID);
                purchaseView.ShowDialog();
                GridFill();
            }
            finally
            {
                Connection.SqlConnection().Close();
            }  

        }

        private void purchaseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
