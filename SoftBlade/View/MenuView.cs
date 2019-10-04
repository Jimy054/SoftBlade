using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftBlade.View.Category;
using SoftBlade.View.Client;
using SoftBlade.View.Provider;
using SoftBlade.View.Product;

namespace SoftBlade.View
{
    public partial class MenuView : MetroFramework.Controls.MetroUserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void mtCategory_Click(object sender, EventArgs e)
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

        private void metroTile3_Click(object sender, EventArgs e)
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

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.MetroPanel.Controls.ContainsKey("ProviderView"))
            {
                ProviderView providerView = new ProviderView
                {
                    Dock = DockStyle.Fill
                };
                Form1.Instance.MetroPanel.Controls.Add(providerView);
            }
            Form1.Instance.MetroPanel.Controls["ProviderView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;
        }

        private void metroTile4_Click(object sender, EventArgs e)
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
    }
}
