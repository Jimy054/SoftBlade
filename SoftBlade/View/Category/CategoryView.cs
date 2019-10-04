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

namespace SoftBlade.View.Category
{
    public partial class CategoryView : MetroFramework.Controls.MetroUserControl
    {

        CategoryModel categoryModel = new CategoryModel();
        DataTable dtCategory;

/*
        static CategoryView _instance;

        public static CategoryView Instance
        {
            get
            {
                if (_instance == null) { 
                    _instance = new CategoryView();
                }
                return _instance;

            }
        }

      */


        public CategoryView()
        {
            InitializeComponent();
            GridFill();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            GridFill();
        }

        public void GridFill()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("listcategory", Connection.SqlConnection());
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtCategory = new DataTable();
            sqlData.Fill(dtCategory);
            categoryGrid.DataSource = dtCategory;
            DataGridViewColumn column = categoryGrid.Columns[0];
            column.Visible = false;
            DataGridViewColumn column1 = categoryGrid.Columns[1];
            DataGridViewColumn column2 = categoryGrid.Columns[2];
            column1.Width = 416;
            column2.Width = 416;         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategory updateCategory = new UpdateCategory(categoryModel.CategoryID, categoryModel.Name, categoryModel.Code);
            updateCategory.ShowDialog();
            GridFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
       
                SqlCommand command = new SqlCommand("DeleteCategory", Connection.SqlConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("_CategoryID", categoryModel.CategoryID);
                DialogResult dialogResult = MessageBox.Show("Desea Eliminar Este Registro", "Eliminar Registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    GridFill();
                }
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("CanceledCategory"))
            {
                CanceledCategory canceledCategory = new CanceledCategory
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(canceledCategory);
            }
            Form1.Instance.MetroPanel.Controls["CanceledCategory"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        private void categoryGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryGrid.CurrentRow.Index != -1)
                {
                    categoryModel.Code = categoryGrid.CurrentRow.Cells[1].Value.ToString();
                    categoryModel.Name = categoryGrid.CurrentRow.Cells[2].Value.ToString();
                    categoryModel.CategoryID = Convert.ToInt32(categoryGrid.CurrentRow.Cells[0].Value.ToString());
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de escoger un código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
