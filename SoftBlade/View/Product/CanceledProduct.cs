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

namespace SoftBlade.View.Product
{
    public partial class CanceledProduct : UserControl
    {
        public CanceledProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("ProductView"))
            {
                ProductView providerView = new ProductView
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(providerView);
            }
            Form1.Instance.MetroPanel.Controls["ProductView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        DataTable dtProduct;


        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListCanceledProduct", Connection.SqlConnection());
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
    }
}
