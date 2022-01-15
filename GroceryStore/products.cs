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

        private void StyleDataGrid()
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

        }

        private void products_Load(object sender, EventArgs e)
        {
            dateTimePicker_Manufacture.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Manufacture.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_Expiration.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Expiration.CustomFormat = "yyyy-MM-dd";

            LoadProductGrid();
            dataGridView_Products.ReadOnly = true;
            dataGridView_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            StyleDataGrid();
        } 

        private void LoadProductGrid() //Load datagridview
        {
            string sql = "select id as 'Id', product_name as 'Product Name', product_weight as 'Product Weight', product_origin as 'Product Origin', manufacture_date as 'Manufacture Date', expiration_date as 'Expiration Date', stock as 'Stock', price as 'Price' from products";
            Global.ProductsDataSet = new DataSet();
            Global.da = new SqlDataAdapter(sql, Global.con);
            Global.da.Fill(Global.ProductsDataSet, "Products");
            Global.cb = new SqlCommandBuilder(Global.da);
            Global.da.InsertCommand = Global.cb.GetInsertCommand(); 
            Global.da.DeleteCommand = Global.cb.GetDeleteCommand();
            Global.da.UpdateCommand = Global.cb.GetUpdateCommand();
            dataGridView_Products.DataSource = Global.ProductsDataSet.Tables["Products"];
        }

        private void ProductsGridViewRefresh() //Refresh datagridview 
        {
            
            dataGridView_Products.DataSource = Global.ProductsDataSet.Tables["Products"];
            
        }

        private void RemoveErrors () //Remove error text from labels 
        {
            TextboxErrors.SetError(textBox_ProductName, null);
            TextboxErrors.SetError(textBox_Weight, null);
            TextboxErrors.SetError(textBox_Origin, null);
            TextboxErrors.SetError(textBox_stock, null);
            TextboxErrors.SetError(textBox_Price, null);
        }

        private void button_Add_Click(object sender, EventArgs e) //Add a product to the database
        {
            int nr = 0;

            //Product name textbox
            if (string.IsNullOrEmpty(textBox_ProductName.Text))
            {
                TextboxErrors.SetError(textBox_ProductName, "This field cannot be empty!"); nr++;
            }
            else
                TextboxErrors.SetError(textBox_ProductName, null);


            //Weight textbox
            if (string.IsNullOrEmpty(textBox_Weight.Text))
            {
                TextboxErrors.SetError(textBox_Weight, "This field cannot be empty!"); nr++;
            }
            else
            if (double.TryParse(textBox_Weight.Text, out _) == false)
            {
                TextboxErrors.SetError(textBox_Weight, "Weight needs to be a number!"); nr++;
            }
            else
                TextboxErrors.SetError(textBox_Weight, null);

            
            //Origin textbox
            if (string.IsNullOrEmpty(textBox_Origin.Text))
            {
                TextboxErrors.SetError(textBox_Origin, "This field cannot be empty!"); nr++;
            }
            else
                TextboxErrors.SetError(textBox_Origin, null);

            
            //Stock textbox
            if (string.IsNullOrEmpty(textBox_stock.Text))
            {
                TextboxErrors.SetError(textBox_stock, "This field cannot be empty!"); nr++;
            }
            else
            if (int.TryParse(textBox_stock.Text, out _) == false)
            {
                TextboxErrors.SetError(textBox_stock, "Stock needs to be a number"); nr++;
            }
            else
                TextboxErrors.SetError(textBox_stock, null);

            
            //Price textbox
            if (string.IsNullOrEmpty(textBox_Price.Text))
            {
                TextboxErrors.SetError(textBox_Price, "This field cannot be empty!"); nr++;
            }
            else
           if (double.TryParse(textBox_Price.Text, out _) == false)
            {
                TextboxErrors.SetError(textBox_Price, "Price needs to be a number"); nr++;
            }
            else
                TextboxErrors.SetError(textBox_Price, null);

            if (nr > 0) 
                return;

            DataRow dr = Global.ProductsDataSet.Tables["Products"].NewRow(); //Generate new datasetRow
            dr["Product Name"] = textBox_ProductName.Text;
            dr["Product Weight"] = textBox_Weight.Text;
            dr["Product Origin"] = textBox_Origin.Text;
            dr["Manufacture Date"] = dateTimePicker_Manufacture.Text;
            dr["Expiration Date"] = dateTimePicker_Expiration.Text;
            dr["Stock"] = textBox_stock.Text;
            dr["Price"] = double.Parse(textBox_Price.Text);

            Global.ProductsDataSet.Tables["Products"].Rows.Add(dr);
           
           
        }

        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e) //Fill textbox - cell click
        {
            RemoveErrors();
            int selectedrowindex = dataGridView_Products.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_Products.Rows[selectedrowindex];
            
            textBox_ProductName.Text = Convert.ToString(selectedRow.Cells["Product Name"].Value);
            textBox_Weight.Text = Convert.ToString(selectedRow.Cells["Product Weight"].Value);
            textBox_Origin.Text = Convert.ToString(selectedRow.Cells["Product Origin"].Value);
            textBox_stock.Text = Convert.ToString(selectedRow.Cells["Stock"].Value);
            dateTimePicker_Manufacture.Text = Convert.ToString(selectedRow.Cells["Manufacture Date"].Value);
            dateTimePicker_Expiration.Text = Convert.ToString(selectedRow.Cells["Expiration Date"].Value);
            textBox_Price.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
            Global.nr = 1;
        }

        private void button_Clear_Click(object sender, EventArgs e) //Clear textbox
        {
            textBox_ProductName.Clear();
            textBox_Weight.Clear();
            textBox_Origin.Clear();
            textBox_stock.Clear();
            textBox_Price.Clear();
            RemoveErrors();
            Global.nr = 0;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product ?", "", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            int selectedrowindex = dataGridView_Products.SelectedCells[0].RowIndex;

            dataGridView_Products.Rows.RemoveAt(selectedrowindex);
            
            //ProductsGridViewRefresh();
            textBox_ProductName.Clear();
            textBox_Weight.Clear();
            textBox_Origin.Clear();
            textBox_stock.Clear();
            textBox_Price.Clear();
        } //Delete product

        private void button_Update_Click(object sender, EventArgs e)
        {
            if(Global.nr == 0)
            { MessageBox.Show("You need to select a product first! "); return; }

            int selectedrowindex = dataGridView_Products.SelectedCells[0].RowIndex;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Product Name"] = textBox_ProductName.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Product Weight"] = textBox_Weight.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Product Origin"] = textBox_Origin.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Manufacture Date"] = dateTimePicker_Manufacture.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Expiration Date"] = dateTimePicker_Expiration.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Stock"] = textBox_stock.Text;
            Global.ProductsDataSet.Tables["Products"].Rows[selectedrowindex]["Price"] = double.Parse(textBox_Price.Text);

            ProductsGridViewRefresh();

        } //Update product details

        private void button_ExportToXml_Click(object sender, EventArgs e)
        {
            Global.ProductsDataSet.WriteXml("D://facultate/Anul 2/Semestrul 1/Sisteme de gestiune a bazelor de date/GroceryStore/products.xml");
            MessageBox.Show("Export successfully!");
        } //Export products to xml

        private void button_SaveChanges_Click(object sender, EventArgs e) //Save datagridview changes
        {
            Global.con.Open();
            SqlTransaction tr = Global.con.BeginTransaction();
            Global.da.InsertCommand.Transaction = tr;
            Global.da.DeleteCommand.Transaction = tr;
            Global.da.UpdateCommand.Transaction = tr;
            DataTable table = Global.ProductsDataSet.Tables["Products"].GetChanges(); 
            try
            {
                if(table != null)
                {
                    Global.da.Update(table);
                    Global.ProductsDataSet.Tables["Products"].AcceptChanges();
                    tr.Commit();
                    MessageBox.Show("Saved successfully!!", "", MessageBoxButtons.OK);
                    LoadProductGrid();
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Save canceled" + ex);
                tr.Rollback();
            }
            finally
           {
                Global.con.Close();
            }
        }

        private void button_CancelChanges_Click(object sender, EventArgs e) //Cancel datagridview changes
        {
            Global.ProductsDataSet.Tables["Products"].RejectChanges();
        }
    }
}
