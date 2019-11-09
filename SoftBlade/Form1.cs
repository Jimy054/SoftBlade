using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftBlade.View;
using SoftBlade.View.Category;

namespace SoftBlade
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        static Form1 _instance;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;

            }
        }

        public MetroFramework.Controls.MetroPanel MetroPanel
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return metroLink1; }
            set { metroLink1 = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroLink1.Visible = false;
            _instance = this;
            MenuAdminView mainMenu = new MenuAdminView();
            mainMenu.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(mainMenu);          
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            
            Form1.Instance.MetroPanel.Controls["MenuView"].BringToFront();
            Form1.Instance.MetroBack.Visible = true;

        }
    }
}
