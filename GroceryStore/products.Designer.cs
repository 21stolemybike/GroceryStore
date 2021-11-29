namespace GroceryStore
{
    partial class products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_Manufacture = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Expiration = new System.Windows.Forms.DateTimePicker();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Origin = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_NameError = new System.Windows.Forms.Label();
            this.label_WeightError = new System.Windows.Forms.Label();
            this.label_CountryError = new System.Windows.Forms.Label();
            this.label_StockError = new System.Windows.Forms.Label();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GroceryStore.Properties.Resources.blurred_supermarket_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker_Manufacture
            // 
            this.dateTimePicker_Manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Manufacture.Location = new System.Drawing.Point(38, 248);
            this.dateTimePicker_Manufacture.Name = "dateTimePicker_Manufacture";
            this.dateTimePicker_Manufacture.Size = new System.Drawing.Size(268, 26);
            this.dateTimePicker_Manufacture.TabIndex = 1;
            // 
            // dateTimePicker_Expiration
            // 
            this.dateTimePicker_Expiration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_Expiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Expiration.Location = new System.Drawing.Point(937, 248);
            this.dateTimePicker_Expiration.Name = "dateTimePicker_Expiration";
            this.dateTimePicker_Expiration.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker_Expiration.TabIndex = 2;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProductName.Location = new System.Drawing.Point(38, 71);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(143, 26);
            this.textBox_ProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(433, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight ";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Weight.Location = new System.Drawing.Point(386, 71);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(156, 26);
            this.textBox_Weight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(635, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Country of origin";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1048, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // textBox_Origin
            // 
            this.textBox_Origin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Origin.Location = new System.Drawing.Point(620, 71);
            this.textBox_Origin.Name = "textBox_Origin";
            this.textBox_Origin.Size = new System.Drawing.Size(154, 26);
            this.textBox_Origin.TabIndex = 9;
            // 
            // textBox_stock
            // 
            this.textBox_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stock.Location = new System.Drawing.Point(1002, 71);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(151, 26);
            this.textBox_stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(97, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Manufacture Date";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(998, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Expiration Date";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(550, 162);
            this.button_Add.MaximumSize = new System.Drawing.Size(234, 31);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(187, 26);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "Add Product";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(550, 202);
            this.button_Delete.MaximumSize = new System.Drawing.Size(234, 31);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(187, 26);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete Product";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(550, 250);
            this.button_Update.MaximumSize = new System.Drawing.Size(234, 31);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(187, 26);
            this.button_Update.TabIndex = 15;
            this.button_Update.Text = "Update Product";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_NameError
            // 
            this.label_NameError.AutoSize = true;
            this.label_NameError.BackColor = System.Drawing.Color.Transparent;
            this.label_NameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_NameError.Location = new System.Drawing.Point(21, 112);
            this.label_NameError.Name = "label_NameError";
            this.label_NameError.Size = new System.Drawing.Size(0, 20);
            this.label_NameError.TabIndex = 16;
            // 
            // label_WeightError
            // 
            this.label_WeightError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_WeightError.AutoSize = true;
            this.label_WeightError.BackColor = System.Drawing.Color.Transparent;
            this.label_WeightError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WeightError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_WeightError.Location = new System.Drawing.Point(369, 112);
            this.label_WeightError.Name = "label_WeightError";
            this.label_WeightError.Size = new System.Drawing.Size(0, 20);
            this.label_WeightError.TabIndex = 17;
            // 
            // label_CountryError
            // 
            this.label_CountryError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CountryError.AutoSize = true;
            this.label_CountryError.BackColor = System.Drawing.Color.Transparent;
            this.label_CountryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CountryError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_CountryError.Location = new System.Drawing.Point(601, 112);
            this.label_CountryError.Name = "label_CountryError";
            this.label_CountryError.Size = new System.Drawing.Size(0, 20);
            this.label_CountryError.TabIndex = 18;
            // 
            // label_StockError
            // 
            this.label_StockError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_StockError.AutoSize = true;
            this.label_StockError.BackColor = System.Drawing.Color.Transparent;
            this.label_StockError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StockError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_StockError.Location = new System.Drawing.Point(977, 112);
            this.label_StockError.Name = "label_StockError";
            this.label_StockError.Size = new System.Drawing.Size(0, 20);
            this.label_StockError.TabIndex = 19;
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Products.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Products.Location = new System.Drawing.Point(316, 389);
            this.dataGridView_Products.MaximumSize = new System.Drawing.Size(885, 600);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Products.Size = new System.Drawing.Size(880, 240);
            this.dataGridView_Products.TabIndex = 20;
            this.dataGridView_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_CellClick);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(550, 300);
            this.button_Clear.MaximumSize = new System.Drawing.Size(234, 31);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(187, 26);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1240, 709);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.label_StockError);
            this.Controls.Add(this.label_CountryError);
            this.Controls.Add(this.label_WeightError);
            this.Controls.Add(this.label_NameError);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_Origin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.dateTimePicker_Expiration);
            this.Controls.Add(this.dateTimePicker_Manufacture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Manufacture;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expiration;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Origin;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_NameError;
        private System.Windows.Forms.Label label_WeightError;
        private System.Windows.Forms.Label label_CountryError;
        private System.Windows.Forms.Label label_StockError;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Button button_Clear;
    }
}