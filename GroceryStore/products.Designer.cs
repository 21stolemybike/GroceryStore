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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
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
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextboxErrors = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_ExportToXml = new System.Windows.Forms.Button();
            this.button_SaveChanges = new System.Windows.Forms.Button();
            this.button_CancelChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextboxErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Manufacture
            // 
            this.dateTimePicker_Manufacture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_Manufacture.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePicker_Manufacture.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Manufacture.Location = new System.Drawing.Point(107, 247);
            this.dateTimePicker_Manufacture.Name = "dateTimePicker_Manufacture";
            this.dateTimePicker_Manufacture.Size = new System.Drawing.Size(225, 37);
            this.dateTimePicker_Manufacture.TabIndex = 1;
            // 
            // dateTimePicker_Expiration
            // 
            this.dateTimePicker_Expiration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker_Expiration.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePicker_Expiration.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Expiration.Location = new System.Drawing.Point(874, 247);
            this.dateTimePicker_Expiration.Name = "dateTimePicker_Expiration";
            this.dateTimePicker_Expiration.Size = new System.Drawing.Size(224, 37);
            this.dateTimePicker_Expiration.TabIndex = 2;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProductName.Location = new System.Drawing.Point(29, 110);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(152, 37);
            this.textBox_ProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(304, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight ";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Weight.Location = new System.Drawing.Point(275, 110);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(156, 37);
            this.textBox_Weight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(535, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Country of origin";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(863, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // textBox_Origin
            // 
            this.textBox_Origin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Origin.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Origin.Location = new System.Drawing.Point(561, 110);
            this.textBox_Origin.Name = "textBox_Origin";
            this.textBox_Origin.Size = new System.Drawing.Size(154, 37);
            this.textBox_Origin.TabIndex = 9;
            // 
            // textBox_stock
            // 
            this.textBox_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_stock.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stock.Location = new System.Drawing.Point(832, 110);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(151, 37);
            this.textBox_stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(110, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Manufacture Date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(888, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Expiration Date";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Add.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Add.Location = new System.Drawing.Point(526, 161);
            this.button_Add.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(234, 40);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "Add Product";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Delete.Location = new System.Drawing.Point(526, 207);
            this.button_Delete.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(234, 40);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete Product ";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Update.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Update.Location = new System.Drawing.Point(526, 253);
            this.button_Update.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(234, 40);
            this.button_Update.TabIndex = 15;
            this.button_Update.Text = "Update Product";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Products.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Products.Location = new System.Drawing.Point(206, 394);
            this.dataGridView_Products.MaximumSize = new System.Drawing.Size(950, 800);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.RowHeadersVisible = false;
            this.dataGridView_Products.RowTemplate.Height = 26;
            this.dataGridView_Products.RowTemplate.ReadOnly = true;
            this.dataGridView_Products.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Products.Size = new System.Drawing.Size(892, 240);
            this.dataGridView_Products.TabIndex = 20;
            this.dataGridView_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_CellClick);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Clear.Location = new System.Drawing.Point(526, 299);
            this.button_Clear.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(234, 40);
            this.button_Clear.TabIndex = 21;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.Location = new System.Drawing.Point(1041, 110);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(151, 37);
            this.textBox_Price.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(1077, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price";
            // 
            // TextboxErrors
            // 
            this.TextboxErrors.BlinkRate = 1;
            this.TextboxErrors.ContainerControl = this;
            this.TextboxErrors.Icon = ((System.Drawing.Icon)(resources.GetObject("TextboxErrors.Icon")));
            // 
            // button_ExportToXml
            // 
            this.button_ExportToXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExportToXml.BackColor = System.Drawing.Color.Transparent;
            this.button_ExportToXml.FlatAppearance.BorderSize = 0;
            this.button_ExportToXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExportToXml.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.button_ExportToXml.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ExportToXml.Location = new System.Drawing.Point(940, 650);
            this.button_ExportToXml.Name = "button_ExportToXml";
            this.button_ExportToXml.Size = new System.Drawing.Size(297, 47);
            this.button_ExportToXml.TabIndex = 25;
            this.button_ExportToXml.Text = "Export products to XML";
            this.button_ExportToXml.UseVisualStyleBackColor = false;
            this.button_ExportToXml.Click += new System.EventHandler(this.button_ExportToXml_Click);
            // 
            // button_SaveChanges
            // 
            this.button_SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_SaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_SaveChanges.FlatAppearance.BorderSize = 0;
            this.button_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SaveChanges.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveChanges.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SaveChanges.Location = new System.Drawing.Point(510, 650);
            this.button_SaveChanges.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_SaveChanges.Name = "button_SaveChanges";
            this.button_SaveChanges.Size = new System.Drawing.Size(187, 40);
            this.button_SaveChanges.TabIndex = 26;
            this.button_SaveChanges.Text = "Save Changes";
            this.button_SaveChanges.UseVisualStyleBackColor = false;
            this.button_SaveChanges.Click += new System.EventHandler(this.button_SaveChanges_Click);
            // 
            // button_CancelChanges
            // 
            this.button_CancelChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CancelChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_CancelChanges.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CancelChanges.FlatAppearance.BorderSize = 0;
            this.button_CancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CancelChanges.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelChanges.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_CancelChanges.Location = new System.Drawing.Point(723, 650);
            this.button_CancelChanges.MaximumSize = new System.Drawing.Size(234, 40);
            this.button_CancelChanges.Name = "button_CancelChanges";
            this.button_CancelChanges.Size = new System.Drawing.Size(211, 40);
            this.button_CancelChanges.TabIndex = 27;
            this.button_CancelChanges.Text = "Cancel Changes";
            this.button_CancelChanges.UseVisualStyleBackColor = false;
            this.button_CancelChanges.Click += new System.EventHandler(this.button_CancelChanges_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1240, 709);
            this.Controls.Add(this.button_CancelChanges);
            this.Controls.Add(this.button_SaveChanges);
            this.Controls.Add(this.button_ExportToXml);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.dataGridView_Products);
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
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextboxErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider TextboxErrors;
        private System.Windows.Forms.Button button_ExportToXml;
        private System.Windows.Forms.Button button_CancelChanges;
        private System.Windows.Forms.Button button_SaveChanges;
    }
}