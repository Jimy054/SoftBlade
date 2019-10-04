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

namespace SoftBlade.View.Client
{
    public partial class CanceledClient : MetroFramework.Controls.MetroUserControl
    {
        public CanceledClient()
        {
            InitializeComponent();
            GridFill();
        }

        private void CanceledClient_Load(object sender, EventArgs e)
        {

        }
        DataTable dtClient;

        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListCanceledClient", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtClient = new DataTable();
            sqlData.Fill(dtClient);

            clientGrid.DataSource = dtClient;
            DataGridViewColumn column = clientGrid.Columns[0];
            column.Visible = false;

            for (int i = 0; i < 9; i++)
            {

                DataGridViewColumn column1 = clientGrid.Columns[i];

                column1.Width = 100;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("ClientView"))
            {
                ClientView clientView = new ClientView
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(clientView);               
            }
            Form1.Instance.MetroPanel.Controls["ClientView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }
    }
}
