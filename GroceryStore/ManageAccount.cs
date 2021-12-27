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

        private void ManageAccount_Load(object sender, EventArgs e) //Load manage account form
        {
            textBox_Password.PasswordChar = '*';
            textBox_ChangePass.PasswordChar = '*';
            button_Delete.Visible = false;
            groupBox_ChangePass.Visible = false;
            groupBox_ChangeMobile.Visible = false;

            
                groupBox_AddAdmin.Visible = false;

            
        } 

        private void textBoxPasswordTextChanged()
        {
            if (!string.IsNullOrEmpty(textBox_Password.Text))
                if (textBox_Password.Text == Global.CurrentPassword)
                {
                    button_Delete.Visible = true;
                    groupBox_ChangePass.Visible = true;
                    groupBox_ChangeMobile.Visible = true; 
                    if (Global.atype == 1)
                        groupBox_AddAdmin.Visible = true;
                }
                else
                {
                    button_Delete.Visible = false;
                    groupBox_ChangePass.Visible = false;
                    groupBox_ChangeMobile.Visible = false;
                    if (Global.atype == 1)
                        groupBox_AddAdmin.Visible = false;
                }
        } //TextBox password text changed method

        private void textBox_Password_TextChanged(object sender, EventArgs e) //Text Box password text changed
        {

            textBoxPasswordTextChanged();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Global.con.Open();
            string sql = "delete from account where id = '" + Global.CurrentId + "' ";
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            Application.Restart();
            login.form.ShowEverything();
        } //Delete account button

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(textBox_ChangePass.Text))
            {
                MessageBox.Show("New Password field is empty"); return;
            }
            Global.con.Open();
            string sql = "update account set pass = '" + textBox_ChangePass.Text + "' where id = '"+Global.CurrentId+"' ";
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            textBox_Password.Text = textBox_ChangePass.Text;
            Global.CurrentPassword = textBox_ChangePass.Text;
            textBox_ChangePass.Clear();
            textBoxPasswordTextChanged();

        } //Change Password button

        private void button_ChangeMobile_Click(object sender, EventArgs e) //Change Mobile button
        {
            string sql = "update account set mobile = " + textBox_Mobile.Text + " where id = " + Global.CurrentId;
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close(); 
            Global.CurrentMobile = textBox_Mobile.Text;
            textBox_Mobile.Clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string insert = "insert into account (username,pass,atype) values ('" + textBox_Username.Text + "','" + textBox_Pass.Text + "',1)";
            SqlCommand cmd = new SqlCommand(insert, Global.con);
            Global.con.Open();
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }//Add new admin account (only visible to admin accounts)
    }
}
