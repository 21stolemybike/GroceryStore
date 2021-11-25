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

namespace GroceryStore
{
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '*';
            textBox_ChangePass.PasswordChar = '*';
            button_Delete.Enabled = false;
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            button_Delete.Enabled = true;
            if(string.IsNullOrEmpty(textBox_Password.Text))
                button_Delete.Enabled = false;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("You need to enter your password first!");
            }

            string username = Global.CurrentUsername, password = textBox_Password.Text;
            string sql = "SELECT username,pass,atype FROM account WHERE username like '" + username + "' and pass like '" + password + "'  ";

            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            if (Global.ds.Tables.Count == 0 || Global.ds == null || Global.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Password incorrect!");Global.con.Close(); return;
            }

            sql = "delete from account where username like '" + username + "' ";
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();

            Global.con.Close();

            Application.Restart();
            login.form.ShowEverything();
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("You need to enter your password first!"); return;
            } 

            if(string.IsNullOrEmpty(textBox_ChangePass.Text))
            {
                MessageBox.Show("New Password field is empty"); return;
            }

            string username = Global.CurrentUsername, password = textBox_Password.Text;
            string sql = "SELECT username,pass,atype FROM account WHERE username like '" + username + "' and pass like '" + password + "'  ";

            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            if (Global.ds.Tables.Count == 0 || Global.ds == null || Global.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Password incorrect!"); return;
            }

            sql = "update account set pass = '" + textBox_ChangePass.Text + "' where username like '"+username+"' ";
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            textBox_ChangePass.Clear();
            textBox_Password.Clear();
        }

        
    }
}
