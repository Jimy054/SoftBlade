using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftBlade.Model;
using System.Data.SqlClient;
using SoftBlade.DB;

namespace SoftBlade.View.Provider
{
    public partial class ProviderView : MetroFramework.Controls.MetroUserControl
    {
        public ProviderView()
        {
            InitializeComponent();
            GridFill();
        }

        ProviderModel providerModel = new ProviderModel();
        enum Search { Name, NIT, Code }
        Search name, nit, code;
        DataTable dtProvider;

        private void providerGrid_Click(object sender, EventArgs e)
        {
            try
            {

                if (providerGrid.CurrentRow.Index != -1)
                {
                    providerModel.Code = providerGrid.CurrentRow.Cells[1].Value.ToString();
                    providerModel.NIT = providerGrid.CurrentRow.Cells[2].Value.ToString();
                    providerModel.Name = providerGrid.CurrentRow.Cells[3].Value.ToString();
                    providerModel.Address = providerGrid.CurrentRow.Cells[4].Value.ToString();
                    providerModel.Telephone = providerGrid.CurrentRow.Cells[5].Value.ToString();
                    providerModel.Telephone2 = providerGrid.CurrentRow.Cells[6].Value.ToString();
                    providerModel.Email = providerGrid.CurrentRow.Cells[7].Value.ToString();
                    providerModel.MethodPayment = providerGrid.CurrentRow.Cells[8].Value.ToString();
                    providerModel.ProviderID = Convert.ToInt32(providerGrid.CurrentRow.Cells[0].Value.ToString());
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Debe de escoger un código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            AddProvider addProvider = new AddProvider();
            addProvider.ShowDialog();
            GridFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DeleteProvider", Connection.SqlConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_ProviderID", providerModel.ProviderID);
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
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("CanceledProvider"))
            {
                CanceledProvider canceledProvider = new CanceledProvider
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(canceledProvider);
            }
            Form1.Instance.MetroPanel.Controls["CanceledProvider"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("ListProvider", Connection.SqlConnection());
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProvider updateProvider =
         new UpdateProvider(providerModel.ProviderID, providerModel.Name, providerModel.Address,
         providerModel.Telephone, providerModel.Telephone2,
         providerModel.Email, providerModel.MethodPayment,
         providerModel.NIT, providerModel.Code);
            updateProvider.ShowDialog();
            GridFill();
        }

    }
}
