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
        internal static Order form;

        public Order()
        {
            InitializeComponent();
            form = this;
        }

        int orderSaved = 0, CurrentQuantity = 0;
       
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
            OrdersGridViewRefresh();
            Global.nr = 0;
            loadComboBox();
            StyleDataGridView();
        } //Load form

        private void StyleDataGridView() //Load datagridview aspect
        {
            dataGridView_Products.BorderStyle = BorderStyle.None;
            dataGridView_Products.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(64, 0, 0);
            dataGridView_Products.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_Products.BackgroundColor = Color.FromArgb(64, 0, 0);
            dataGridView_Products.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView_Products.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_Products.EnableHeadersVisualStyles = false; 
            dataGridView_Products.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_Products.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView_Products.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView_Products.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView_Orders.BorderStyle = BorderStyle.None;
            dataGridView_Orders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(64, 0, 0);
            dataGridView_Orders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_Orders.BackgroundColor = Color.FromArgb(64, 0, 0);
            dataGridView_Orders.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView_Orders.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_Orders.EnableHeadersVisualStyles = false;
            dataGridView_Orders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void loadComboBox() //Load products into comboBox
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged; //Detach event
            
            
            SqlDataAdapter daFarm = new SqlDataAdapter("Select product_name,id from Products", Global.con);
            daFarm.Fill(Global.ds, "Products");
            DataView dv = new DataView(Global.ds.Tables["Products"]);
            dv.Sort = "product_name";
            comboBox1.DataSource = dv;
            comboBox1.DisplayMember = "product_name";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedValue = 0;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; //Attach event
        }

        private int VerifyStock(int n) //Verify if the current stock can supply quantity needds 
        {
            string sql = "select stock from products where id = " + comboBox1.SelectedValue;
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            object obj = cmd.ExecuteScalar();
            int TotalStock = Convert.ToInt32(obj);


            sql = "select quantity from orders where product_id = " + comboBox1.SelectedValue;
            cmd = new SqlCommand(sql, Global.con);
            obj = cmd.ExecuteScalar();
            int currentQuantity = 0;
            Global.con.Close();
            
            if (TotalStock - currentQuantity - n < 0)
            { label_QuantityError.Text = "Quantity bigger than stock!"; return 0; }
            else
                return 1;
            
        }
       
        private void StockLabelChange() //Change stock label value
        {
            string sql = "select stock from products where id like " + comboBox1.SelectedValue;
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            object obj = cmd.ExecuteScalar();
            int TotalStock = Convert.ToInt32(obj);

            sql = "select count(*) from orders where product_id = " + comboBox1.SelectedValue + " and account_id = " + Global.CurrentId;
            cmd = new SqlCommand(sql, Global.con); 
            obj = cmd.ExecuteScalar(); 
            int ifExists = Convert.ToInt32(obj);
            
            if(ifExists == 0)
            {
                label_Stock.Text = "Stock: " + TotalStock;
            }
            else if (ifExists>0)
            {
                sql = "select quantity from orders where product_id = " + comboBox1.SelectedValue+" and account_id = "+Global.CurrentId+" and saved = 0";
                cmd = new SqlCommand(sql, Global.con); 
                obj = cmd.ExecuteScalar(); 
                int currentQuantity = Convert.ToInt32(obj);
                label_Stock.Text = "Stock: " + (TotalStock - currentQuantity);
                CurrentQuantity = TotalStock - currentQuantity;
                
            }
            
            Global.con.Close();
        }

        public static void DeleteOrder()  //Delete products from current order
        {
            
            Global.con.Open();
            
                
                SqlCommand cmd = new SqlCommand("DeleteUnsaved", Global.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@accountId", Global.CurrentId));
                cmd.ExecuteNonQuery();
            
            Global.con.Close();
        }

        private void ProductsGridViewRefresh() //Refresh product datagridview
        {
            string sql = "select id as 'ID', product_name as 'Product Name', product_weight as 'Product Weight', product_origin as 'Product Origin', manufacture_date as 'Manufacture Date', expiration_date as 'Expiration Date', stock as 'Stock', price as 'Price' from products where stock > 0";
            Global.con.Open();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.ds = new DataSet();
            Global.da.Fill(Global.ds);
            dataGridView_Products.DataSource = Global.ds.Tables[0];
            Global.con.Close();
        }

        private void OrdersGridViewRefresh() //Refresh orders datagridview
        {
            string sql = "select A.id as 'Id',product_name as 'Product Name', quantity as 'Quantity', totalPrice as 'Total Price' from orders as A inner join products as B on A.product_id = B.id where account_id = " + Global.CurrentId+" and saved = 0";
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
            Global.con.Close();
            panel.Visible = true;
            groupBox_MissingInfo.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button_AddItem_Click(object sender, EventArgs e) //Add item to order
        {
            if (string.IsNullOrEmpty(textBox_Quantity.Text)) //Verify if quantity field is empty
            {
                label_QuantityError.Text = "This field cannot be empty!"; return;
            }
            else label_QuantityError.Text = "";

            if (VerifyStock(int.Parse(textBox_Quantity.Text)) ==0) //Verify if stock can supply quantity
            {
                label_QuantityError.Text = "Quantity bigger than stock!"; return;
            }
            else label_QuantityError.Text = "";

            //Get stock value from products table
            string sql = "select stock from products where id = "+ int.Parse(comboBox1.SelectedValue.ToString());
            Global.con.Open(); 
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            object obj = cmd.ExecuteScalar();
            int result = Convert.ToInt32(obj);
            
            
            //Verify if quantity is higher than stock
            if (int.Parse(textBox_Quantity.Text) > result) 
            {
                label_QuantityError.Text = "Quantity bigger than stock!"; Global.con.Close(); return;
            }
            else
                label_QuantityError.Text = ""; //Delete label text if value is correct

            //Get price value from products table
            sql = "select price from products where id = " + int.Parse(comboBox1.SelectedValue.ToString());
            cmd = new SqlCommand(sql, Global.con); 
            obj = cmd.ExecuteScalar(); 
            
            double price = Convert.ToDouble(obj); //Get price value
            double currentValue = price * double.Parse(textBox_Quantity.Text); //Calculate current value price*quantity
            Global.totalValue += currentValue; //Add curent value to total order Value

            //Verify if the product already exists in the order
            sql = "select count(*) from orders where product_id like " + int.Parse(comboBox1.SelectedValue.ToString()) + " and account_id like " + int.Parse(Global.CurrentId)+ " and saved like 0";
             cmd = new SqlCommand(sql, Global.con);
             obj = cmd.ExecuteScalar();
             result = Convert.ToInt32(obj);
            
            
            
            if (result >0)
            //update product quantity if it is in the order already
            {
                sql = "update orders set quantity = quantity + "+ double.Parse(textBox_Quantity.Text)+ ", totalPrice = totalPrice +"+currentValue +" where product_id like " + int.Parse(comboBox1.SelectedValue.ToString()) + " and account_id like " + int.Parse(Global.CurrentId);
                cmd = new SqlCommand(sql, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close(); //Connection must be closed before OrdersGridViewRefresh() call because the connection is open and closed in function
            }
            
            
            //Insert new data into sql table if the product is not in the order already
            else
            {   sql = "insert into orders values (" + int.Parse(comboBox1.SelectedValue.ToString()) + "," + int.Parse(Global.CurrentId) + "," + currentValue + "," + double.Parse(textBox_Quantity.Text) + "," + 0 +") ";
                
                cmd = new SqlCommand(sql, Global.con);
                cmd.ExecuteNonQuery();
                Global.con.Close(); //Connection must be closed before OrdersGridViewRefresh() call because the connection is open and closed in function
            }
            OrdersGridViewRefresh();
            label_TotalAmount.Text = Global.totalValue.ToString();

            StockLabelChange();
            

         }

        private void Order_FormClosed(object sender, FormClosedEventArgs e) //Event that occurs when form is closed
        {
            if(orderSaved == 0)
            DeleteOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Add current stock value to label
        {
            StockLabelChange();
            textBox_Quantity.Text = "";
            label_QuantityError.Text = "";
        }
       
        #region "Detele product from order" 

        private void TotalValueRefresh()
        {
            string sql = "select sum(totalPrice) from orders where account_id = " + Global.CurrentId + " and saved = 0";
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            Global.con.Open();
            object obj = cmd.ExecuteScalar();
            label_TotalAmount.Text = Convert.ToString(obj);
            Global.con.Close();
        }

        private void button_DeleteFromOrder_Click(object sender, EventArgs e) //Delete product from order
        {
            if (dataGridView_Products.SelectedRows.Count == 0)
            {
                label_DeleteFromOrderError.Text = "You need to select a product first!"; return;
            }
            else label_DeleteFromOrderError.Text = "";

            int selectedrowindex = dataGridView_Orders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_Orders.Rows[selectedrowindex];
            string id = Convert.ToString(selectedRow.Cells["id"].Value);


            string sql = "delete from orders where id = " + id;
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql, Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
            StockLabelChange();
            OrdersGridViewRefresh();
            TotalValueRefresh();
        }

       
        #endregion

        #region "Save order"        

        private void button_SaveOrder_Click(object sender, EventArgs e) //Save Order
        {
            Global.con.Open();
            foreach(DataGridViewRow row in dataGridView_Orders.Rows)
            {
                SqlCommand cmd = new SqlCommand("SaveOrder", Global.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@orderId", Convert.ToString(row.Cells["id"].Value)));
                cmd.ExecuteNonQuery();    
             }
            Global.con.Close();
            OrdersGridViewRefresh();
            ProductsGridViewRefresh();
            Global.totalValue = 0;
            orderSaved = 1;
        }
        #endregion
    }
}
