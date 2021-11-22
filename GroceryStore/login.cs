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



namespace GroceryStore
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
            Global.con = new SqlConnection(Global.stringConectare);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(username_textbox.Text))
            {
                MessageBox.Show("Username field is empty");
                return;
            }
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Password field is empty");
                return;
            }

            string username = username_textbox.Text, password = password_textbox.Text;
            string sql = "SELECT username,pass,atype FROM account WHERE username like '" + username+"' and pass like '" + password +"'  ";
            
            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            
           //Verify if the user exist in the database
            if(Global.ds.Tables.Count == 0 || Global.ds == null || Global.ds.Tables[0].Rows.Count==0) 
            {
                MessageBox.Show("Password or username incorrect!");
            }
            else //if yes
            {
                int type = int.Parse(Global.ds.Tables[0].Rows[0]["atype"].ToString());
                if(type==1) //verify admin account
                {
                    this.Hide();
                    MenuAdmin menuAdmin = new MenuAdmin(); 
                    menuAdmin.ShowDialog();
                    
                }
                else 
                    if(type==0) //verify normal user account
                {
                    this.Hide();
                    MenuUser menuuser = new MenuUser(); 
                    menuuser.ShowDialog();
                }
            }


            Global.con.Close();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_textbox.Text))
            {
                MessageBox.Show("Username field is empty");
                return;
            }
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Password field is empty");
                return;
            }
            string username = username_textbox.Text, password = password_textbox.Text;
            string sql = "select count(*) from account where username = '" + username + "' ";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql,Global.con); 
            object obj = cmd.ExecuteScalar(); 
            if(Convert.ToInt32(obj)>0)
            {
                MessageBox.Show("An user with the same name already exists");
                return;
            }

            string insert = "insert into account values ('" + username + "','" + password + "',0)";
            MessageBox.Show(insert);
            cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }
    }
}
