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
        internal static login form;
        
        public login()
        {
            InitializeComponent();
            form = this;
        }

        private void login_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
            Global.con = new SqlConnection(Global.stringConectare);
            
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
            panel_Login.Controls.Add(childForm);
            panel_Login.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HideEverything() //Hide everything for openChildForm()
        {
            label_Password.Visible = false;
            label_Username.Visible = false;
            password_textbox.Visible = false; 
            username_textbox.Visible = false; 
            Login_Button.Visible = false;
            Register_Button.Visible = false;
            pictureBox.Visible = false;
        }

        public void ShowEverything() //Show everything when closing form from openChildForm()
        {
            label_Password.Visible = true;
            label_Username.Visible = true;
            password_textbox.Visible = true;
            username_textbox.Visible = true;
            Login_Button.Visible = true;
            Register_Button.Visible = true;
            pictureBox.Visible = true;
        }

       #region "Register and Login functions"

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
            string sql = "SELECT id,username,pass,atype,fullName,mobile FROM account WHERE username like '" + username+"' and pass like '" + password +"'  ";
            
            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            
           //Verify if the user exist in the database
            if(Global.ds.Tables.Count == 0 || Global.ds == null || Global.ds.Tables[0].Rows.Count==0) 
            {
                MessageBox.Show("Password or username incorrect!"); Global.con.Close();return;
            }
            else //if yes
            {
                int type = int.Parse(Global.ds.Tables[0].Rows[0]["atype"].ToString());
                Global.atype = type;
                if (type==1) //verify admin account
                {   
                    HideEverything();
                    openChildForm(new MenuAdmin());
                    
                }
                else 
                    if(type==0) //verify normal user account
                {
                    HideEverything();
                    openChildForm(new MenuAdmin()); //Trebuie schimbat inapoi cand ajung la partea asta si sters comentariu
                }
            }
            
            Global.CurrentUsername = username;
            Global.CurrentId = Global.ds.Tables[0].Rows[0]["id"].ToString();
            Global.CurrentFullName = Global.ds.Tables[0].Rows[0]["fullName"].ToString();
            Global.CurrentMobile = Global.ds.Tables[0].Rows[0]["mobile"].ToString();
            
            
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
            SqlCommand cmd = new SqlCommand(sql,Global.con);   //Verify if the username already exists
            object obj = cmd.ExecuteScalar(); 
            if(Convert.ToInt32(obj)>0)
            {
                MessageBox.Show("An user with the same name already exists"); 
                Global.con.Close();
                return;
            }

            string insert = "insert into account (username,pass,atype) values ('" + username + "','" + password + "',0)"; //If not then add him 
           
            cmd = new SqlCommand(insert, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }




        #endregion

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Order.DeleteOrder();
        }
    }
}
