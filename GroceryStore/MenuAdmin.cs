using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            if (Global.atype == 0)
            {
                button_Products.Visible = false;
                button_Reports.Visible = false;
            }
            else
            {
                button_Products.Visible = true;
                button_Reports.Visible = true;
            }


        }

        private Form activeForm = null;

        private void openChildForm(Form childForm) //Open a form in a form
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_ShowMenus.Controls.Add(childForm);
            Panel_ShowMenus.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region "Menu Manage" 

        private void button_LogOut_Click(object sender, EventArgs e) //Log out
        {
            this.Close();
            login.form.ShowEverything();
        }

        private void button_Products_Click(object sender, EventArgs e) //Open products form
        {
            openChildForm(new products());
        }

        private void button_Order_Click(object sender, EventArgs e) //Open orders form
        {
            openChildForm(new Order());
        }

        private void button_Manage_Click(object sender, EventArgs e) //Open manage account form
        {
            openChildForm(new ManageAccount());
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            openChildForm(new Reports());
        }

        #endregion

        private void MenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       
    }
}
