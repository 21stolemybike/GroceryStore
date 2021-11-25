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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {
            dateTimePicker_Manufacture.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Manufacture.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_Expiration.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Expiration.CustomFormat = "yyyy-MM-dd";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int nr = 0;
            
            if (string.IsNullOrEmpty(textBox_ProductName.Text))
            {
                label_NameError.Text = "This field cannot be empty!"; nr++;
            }
            else
                label_NameError.Text = "";


            if (string.IsNullOrEmpty(textBox_Weight.Text))
            {
                label_WeightError.Text = "This field cannot be empty!"; nr++;
            }
            else
            if (double.TryParse(textBox_Weight.Text, out _) == false)
            {
                label_WeightError.Text = "Weight needs to be a number!"; nr++;
            }
            else
                label_WeightError.Text = "";

            if(string.IsNullOrEmpty(textBox_Origin.Text))
            {
                label_CountryError.Text = "This field cannot be empty!"; nr++;
            }
            else 
            label_CountryError.Text = "";

            if (string.IsNullOrEmpty(textBox_stock.Text))
            {
                label_StockError.Text = "This field cannot be empty!"; nr++;
            }
            else
            if (int.TryParse(textBox_stock.Text, out _) == false)
            {
                label_StockError.Text = "Weight needs to be a number!"; nr++;
            }
            else
                label_StockError.Text = "";

            if (nr > 0)
                return;

            string sql = "insert into products values ('" + textBox_ProductName.Text + "','" + textBox_Weight.Text + "','" + textBox_Origin.Text + "','" + dateTimePicker_Manufacture.Text + "','" + dateTimePicker_Expiration.Text + "','" + textBox_stock.Text + "') ";
            MessageBox.Show(sql);
            Global.con.Open();
            SqlCommand cmd = new SqlCommand(sql,Global.con);
            cmd.ExecuteNonQuery();
            Global.con.Close();
        }
    }
}
