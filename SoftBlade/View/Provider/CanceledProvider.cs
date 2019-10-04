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

namespace SoftBlade.View.Provider
{
    public partial class CanceledProvider : MetroFramework.Controls.MetroUserControl
    {
        public CanceledProvider()
        {
            InitializeComponent();
            GridFill();
        }

        DataTable dtProvider;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("ProviderView"))
            {
                ProviderView clientView = new ProviderView
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(clientView);
            }
            Form1.Instance.MetroPanel.Controls["ProviderView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListCanceledProvider", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtProvider = new DataTable();
            sqlData.Fill(dtProvider);
            providerGrid.DataSource = dtProvider;
            DataGridViewColumn column = providerGrid.Columns[0];
            column.Visible = false;

            for (int i = 0; i < 9; i++)
            {

                DataGridViewColumn column1 = providerGrid.Columns[i];

                column1.Width = 103;
            }

        }
    }
}
