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

namespace SoftBlade.View.Client
{
    public partial class ClientView : MetroFramework.Controls.MetroUserControl
    {
        public ClientView()
        {
            InitializeComponent();
            GridFill();
        }
        ClientModel clientModel = new ClientModel();
        DataTable dtClient;

        private void btNew_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            GridFill();
        }

        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListClient", Connection.SqlConnection());
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

        private void clientGrid_Click(object sender, EventArgs e)
        {
            try
            {

                if (clientGrid.CurrentRow.Index != -1)
                {
                    clientModel.Code = clientGrid.CurrentRow.Cells[1].Value.ToString();
                    clientModel.NIT = clientGrid.CurrentRow.Cells[2].Value.ToString();
                    clientModel.Name = clientGrid.CurrentRow.Cells[3].Value.ToString();
                    clientModel.Address = clientGrid.CurrentRow.Cells[4].Value.ToString();
                    clientModel.Telephone = clientGrid.CurrentRow.Cells[5].Value.ToString();
                    clientModel.Telephone2 = clientGrid.CurrentRow.Cells[6].Value.ToString();
                    clientModel.Email = clientGrid.CurrentRow.Cells[7].Value.ToString();
                    clientModel.MethodPayment = clientGrid.CurrentRow.Cells[8].Value.ToString();
                    clientModel.ClientID = Convert.ToInt32(clientGrid.CurrentRow.Cells[0].Value.ToString());
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de escoger un código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient updateClient =
          new UpdateClient(
                  clientModel.ClientID,
                  clientModel.Name, 
                  clientModel.Address,
                  clientModel.Telephone,
                  clientModel.Telephone2,
                  clientModel.Email, 
                  clientModel.MethodPayment,
                  clientModel.NIT,
                  clientModel.Code);

            updateClient.ShowDialog();
            GridFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DeleteClient", Connection.SqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_ClientID", clientModel.ClientID);
            DialogResult dialogResult = MessageBox.Show("Desea Eliminar Este Registro", "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Elimnado Exitosamente", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridFill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("CanceledClient"))
            {
                CanceledClient canceledClient = new CanceledClient
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(canceledClient);
            }
            Form1.Instance.MetroPanel.Controls["CanceledClient"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }
    }
}
