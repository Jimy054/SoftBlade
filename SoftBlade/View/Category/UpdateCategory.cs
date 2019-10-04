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

namespace SoftBlade.View.Category
{
    public partial class UpdateCategory : MetroFramework.Forms.MetroForm
    {
        CategoryModel categoryModel = new CategoryModel();

        public UpdateCategory(int id, string name, string code)
        {
            InitializeComponent();
            categoryModel.CategoryID = id;
            txtName.Text = name;
            txtCode.Text = code;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UpdateCategory", Connection.SqlConnection());
            categoryModel.Code = txtCode.Text;
            categoryModel.Name = txtName.Text;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_categoryID", categoryModel.CategoryID);
            command.Parameters.AddWithValue("_code", categoryModel.Code);
            command.Parameters.AddWithValue("_name", categoryModel.Name);
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
