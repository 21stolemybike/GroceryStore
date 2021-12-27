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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            loadComboBoxProducts();
            loadComboBoxAccounts();
            
            //Products Sold
            label2.Visible = false;
            label_Sold.Visible = false;
            label3.Visible = false;
            label_TotalValue.Visible = false;
            
            //Account Purchases
            label6.Visible = false;
            label_TotalMoney.Visible = false;
        } //Load Form

        
        private void loadComboBoxAccounts() //Load accounts into comboBox 
        {
            comboBox_Account.SelectedIndexChanged -= comboBox_Account_SelectedIndexChanged; //Detach event
            
            SqlDataAdapter daAccounts = new SqlDataAdapter("Select distinct  A.id, fullName from account as A inner join orders as B on A.id = B.account_id where fullName is not null ", Global.con);
            daAccounts.Fill(Global.ds, "account");
            DataView dv = new DataView(Global.ds.Tables["account"]);
            dv.Sort = "fullName";
            comboBox_Account.DataSource = dv;
            comboBox_Account.DisplayMember = "fullName";
            comboBox_Account.ValueMember = "id";
            comboBox_Account.SelectedValue = 0;

            comboBox_Account.SelectedIndexChanged += comboBox_Account_SelectedIndexChanged; //Attach event
        }
        
        
        private void loadComboBoxProducts() //Load products into comboBox
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged; //Detach event

            SqlDataAdapter daFarm = new SqlDataAdapter("Select product_name,id from Products", Global.con);
            DataSet ds = new DataSet(); 
            daFarm.Fill(ds, "Products");
            DataView dv = new DataView(ds.Tables["Products"]);
            dv.Sort = "product_name";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "product_name";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedValue = 0;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; //Attach event
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Change products comboBox index
        {
            SqlCommand cmd = new SqlCommand("GetProductsSale", Global.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@productId", comboBox1.SelectedValue);
            SqlParameter outSum = new SqlParameter("@sum",SqlDbType.Float) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(outSum);
            SqlParameter outQuant = new SqlParameter("@quant",SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(outQuant);
            Global.con.Open();
            cmd.ExecuteNonQuery();
            float Sum; int Quant;
            Sum = Convert.ToSingle(outSum.Value);
            Quant = Convert.ToInt32(outQuant.Value);
            Global.con.Close();
            label_Sold.Text = Quant.ToString();
            label_TotalValue.Text = Sum.ToString();

            label2.Visible = true;
            label_Sold.Visible = true;
            label3.Visible = true;
            label_TotalValue.Visible = true;
        }

        private void comboBox_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("GetAccountTotalValue", Global.con); 
            cmd.CommandType= CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@accountId",comboBox_Account.SelectedValue);
            SqlParameter outSum = new SqlParameter("@sum", SqlDbType.Float) { Direction= ParameterDirection.Output };
            cmd.Parameters.Add(outSum);
            Global.con.Open();
            cmd.ExecuteNonQuery ();
            float Sum; 
            Sum = Convert.ToSingle (outSum.Value);
            Global.con.Close();
            label_TotalMoney.Text = Sum.ToString();

            label6.Visible = true;
            label_TotalMoney.Visible = true;
        } //Change account comboBox index
    }
}
