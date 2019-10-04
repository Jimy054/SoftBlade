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

namespace SoftBlade.View.Category
{
    public partial class CanceledCategory : MetroFramework.Controls.MetroUserControl
    {
        public CanceledCategory()
        {
            InitializeComponent();
            GridFill();
        }



        DataTable dtCategory;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("CategoryView"))
            {
                CategoryView categoryView = new CategoryView
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(categoryView);
            }
            Form1.Instance.MetroPanel.Controls["CategoryView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        public void GridFill()
        {
            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("listcanceledcategory", Connection.SqlConnection());
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
                //     80.Columns.GetColumnsWidth();

            }
            finally
            {

                Connection.SqlConnection().Close();
            }
        }


    }
}
