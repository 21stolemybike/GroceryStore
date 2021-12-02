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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private static int Ordered = 0;
       
        private void Order_Load(object sender, EventArgs e)
        {
            if(Global.CurrentMobile == "" && Global.CurrentFullName == "")
            {
                panel.Visible = false;
            }  
            else
            {
                pictureBox1.Visible = false;
                panel.Visible = true;
              groupBox_MissingInfo.Visible = false;
            } //Hide/Show controls
            dataGridView_Products.ReadOnly = true;
            dataGridView_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ProductsGridViewRefresh();
            Global.nr = 0;
            loadComboBox();
        }

        private void loadComboBox() //Load products into comboBox
        {
            SqlDataAdapter daFarm = new SqlDataAdapter("Select product_name,id from Products", Global.con);
            daFarm.Fill(Global.ds, "Products");
            DataView dv = new DataView(Global.ds.Tables["Products"]);
            dv.Sort = "product_name";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "product_name";
            comboBox1.ValueMember = "id";
            
            //comboBox1.SelectedValue.ToString();
        }

        private void ProductsGridViewRefresh() //Refresh product datagridview
        {
            string sql = "select id as 'ID', product_name as 'Product Name', product_weight as 'Product Weight', product_origin as 'Product Origin', manufacture_date as 'Manufacture Date', expiration_date as 'Expiration Date', stock as 'Stock', price as 'Price' from products";
            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            dataGridView_Products.DataSource = Global.ds.Tables[0];
            Global.con.Close();
        }

        private void OrdersGridViewRefresh() //Refresh orders datagridview
        {
            string sql = "select product_name as 'Product Name', totalPrice as 'Total Price' from orders as A inner join products as B on A.product_id = B.id where account_id like " + Global.CurrentId;
            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            dataGridView_Orders.DataSource = Global.ds.Tables[0];
            Global.con.Close();
        }


        private void button_AddMissing_Click(object sender, EventArgs e) //Add missing information 
        {
            int nr = 0;
            if (string.IsNullOrEmpty(textBox_FullName.Text))
            {
                nr++; label_FullNameError.Text = "This field cannot be empty! ";
            }
            else
                label_FullNameError.Text = "";
            if(string.IsNullOrEmpty(textBox_Mobile.Text))
            {
                nr++; label_MobileError.Text = "This field cannot be empty! ";
            }
            else
                label_MobileError.Text = "";
            if (nr>0)
            { return; }
            Global.CurrentFullName = textBox_FullName.Text;
            Global.CurrentMobile = textBox_Mobile.Text;

            string sql = "update account set fullname ='"+Global.CurrentFullName+"', mobile = '"+Global.CurrentMobile+"' where id like "+Global.CurrentId;
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            
            panel.Visible = true;
            groupBox_MissingInfo.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button_AddItem_Click(object sender, EventArgs e) //Add item to order
        {
            if(string.IsNullOrEmpty(textBox_Quantity.Text))
            {
                MessageBox.Show("Quantity cannot be empty!"); return;
            }

            int selectedrowindex = dataGridView_Products.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_Products.Rows[selectedrowindex];

            double price = double.Parse(Convert.ToString(selectedRow.Cells["Price"].Value));
            double currentValue = price * double.Parse(textBox_Quantity.Text);
            Global.totalValue += currentValue;
            
            
            string sql = "insert into orders values ("+int.Parse(comboBox1.SelectedValue.ToString()) +","+int.Parse(Global.CurrentId) +","+currentValue+") ";
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery(); 
            Global.con.Close();
            OrdersGridViewRefresh();
            label_TotalAmount.Text = Global.totalValue.ToString();
            Global.nr++;
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e) //Event that occurs when form is closed
        {
            if(Ordered == 0)
               if (Global.nr > 0)
                {   Global.con.Open();
                    string sql = "delete from orders where id = (select max(id) from orders)";
                    SqlCommand cmd = new SqlCommand(sql, Global.con);
                    for (int i = 1; i <= Global.nr; i++)
                       cmd.ExecuteNonQuery();
                    
                    Global.con.Close();
                }
            
        }
    }
}
