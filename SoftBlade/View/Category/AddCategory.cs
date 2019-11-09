using SoftBlade.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SoftBlade.DB;

namespace SoftBlade.View.Category
{
    public partial class AddCategory : MetroFramework.Forms.MetroForm
    {
        CategoryModel categoryModel = new CategoryModel();

        public AddCategory()
        {
            InitializeComponent();
            btnNew.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("GenerateCodeCategory",Connection.SqlConnection());
                categoryModel.Code = txtCode.Text;
                categoryModel.Name = txtName.Text;

                if (ckCode.Checked)
                {
                    categoryModel.Code = "";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_code", categoryModel.Code);
                    command.Parameters.AddWithValue("_name", categoryModel.Name);
                    command.Parameters.AddWithValue("_automatically", false);
                   // try
                   // {

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Agregado Exitosamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                   // }
                   // catch (Exception)
                   // {
                    //    MessageBox.Show("Código  Repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_name", categoryModel.Name);
                    command.Parameters.AddWithValue("_code", categoryModel.Code);
                    command.Parameters.AddWithValue("_automatically", true);
                    //command.ExecuteNonQuery();
                    try
                    {

                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Agregado Exitosamente", "Registro Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Código  Repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            finally
            {
                Connection.SqlConnection().Close();
            }




        }

        private void ckCode_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCode.Checked)
            {
                txtCode.ReadOnly = true;
            }
            else
            {
                txtCode.ReadOnly = false;
            }
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if ((txtCode.Text == "" && !ckCode.Checked) || txtName.Text == "")
            {
                btnNew.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if ((txtCode.Text == "" && !ckCode.Checked) || txtName.Text == "")
            {
                btnNew.Enabled = false;
            }
            else
            {
                btnNew.Enabled = true;
            }
        }
    }
}
