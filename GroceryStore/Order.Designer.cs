namespace GroceryStore
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DeleteFromOrder = new System.Windows.Forms.Button();
            this.button_SaveOrder = new System.Windows.Forms.Button();
            this.label_DeleteFromOrderError = new System.Windows.Forms.Label();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_QuantityError = new System.Windows.Forms.Label();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.dataGridView_Orders = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_MissingInfo = new System.Windows.Forms.GroupBox();
            this.label_MobileError = new System.Windows.Forms.Label();
            this.label_FullNameError = new System.Windows.Forms.Label();
            this.button_AddMissing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Mobile = new System.Windows.Forms.TextBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).BeginInit();
            this.groupBox_MissingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.label_DeleteFromOrderError);
            this.panel.Controls.Add(this.label_TotalAmount);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.dataGridView_Products);
            this.panel.Controls.Add(this.dataGridView_Orders);
            this.panel.Controls.Add(this.button2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1240, 709);
            this.panel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_DeleteFromOrder);
            this.panel1.Controls.Add(this.button_SaveOrder);
            this.panel1.Location = new System.Drawing.Point(958, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 100);
            this.panel1.TabIndex = 28;
            // 
            // button_DeleteFromOrder
            // 
            this.button_DeleteFromOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_DeleteFromOrder.FlatAppearance.BorderSize = 0;
            this.button_DeleteFromOrder.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteFromOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_DeleteFromOrder.Location = new System.Drawing.Point(0, 0);
            this.button_DeleteFromOrder.Name = "button_DeleteFromOrder";
            this.button_DeleteFromOrder.Size = new System.Drawing.Size(216, 47);
            this.button_DeleteFromOrder.TabIndex = 25;
            this.button_DeleteFromOrder.Text = "Delete From Order";
            this.button_DeleteFromOrder.UseVisualStyleBackColor = true;
            this.button_DeleteFromOrder.Click += new System.EventHandler(this.button_DeleteFromOrder_Click);
            // 
            // button_SaveOrder
            // 
            this.button_SaveOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_SaveOrder.FlatAppearance.BorderSize = 0;
            this.button_SaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_SaveOrder.Location = new System.Drawing.Point(0, 53);
            this.button_SaveOrder.Name = "button_SaveOrder";
            this.button_SaveOrder.Size = new System.Drawing.Size(216, 47);
            this.button_SaveOrder.TabIndex = 27;
            this.button_SaveOrder.Text = "💾";
            this.button_SaveOrder.UseVisualStyleBackColor = true;
            this.button_SaveOrder.Click += new System.EventHandler(this.button_SaveOrder_Click);
            // 
            // label_DeleteFromOrderError
            // 
            this.label_DeleteFromOrderError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DeleteFromOrderError.AutoSize = true;
            this.label_DeleteFromOrderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeleteFromOrderError.ForeColor = System.Drawing.Color.Red;
            this.label_DeleteFromOrderError.Location = new System.Drawing.Point(739, 413);
            this.label_DeleteFromOrderError.Name = "label_DeleteFromOrderError";
            this.label_DeleteFromOrderError.Size = new System.Drawing.Size(0, 24);
            this.label_DeleteFromOrderError.TabIndex = 26;
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_TotalAmount.Location = new System.Drawing.Point(719, 451);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(51, 32);
            this.label_TotalAmount.TabIndex = 24;
            this.label_TotalAmount.Text = "text";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(553, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = " Total Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_Stock);
            this.groupBox1.Controls.Add(this.label_QuantityError);
            this.groupBox1.Controls.Add(this.button_AddItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Quantity);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(74, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 154);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // label_Stock
            // 
            this.label_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Stock.AutoSize = true;
            this.label_Stock.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stock.ForeColor = System.Drawing.Color.Red;
            this.label_Stock.Location = new System.Drawing.Point(13, 112);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(27, 32);
            this.label_Stock.TabIndex = 28;
            this.label_Stock.Text = "1";
            // 
            // label_QuantityError
            // 
            this.label_QuantityError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_QuantityError.AutoSize = true;
            this.label_QuantityError.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QuantityError.ForeColor = System.Drawing.Color.Red;
            this.label_QuantityError.Location = new System.Drawing.Point(419, 112);
            this.label_QuantityError.Name = "label_QuantityError";
            this.label_QuantityError.Size = new System.Drawing.Size(27, 32);
            this.label_QuantityError.TabIndex = 27;
            this.label_QuantityError.Text = "1";
            // 
            // button_AddItem
            // 
            this.button_AddItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_AddItem.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_AddItem.Location = new System.Drawing.Point(858, 57);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(148, 40);
            this.button_AddItem.TabIndex = 6;
            this.button_AddItem.Text = "Add Product";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Product";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_Quantity.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Quantity.Location = new System.Drawing.Point(464, 67);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(205, 37);
            this.textBox_Quantity.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 40);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Products.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Products.Location = new System.Drawing.Point(74, 29);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Products.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Products.Size = new System.Drawing.Size(896, 228);
            this.dataGridView_Products.TabIndex = 21;
            // 
            // dataGridView_Orders
            // 
            this.dataGridView_Orders.AllowUserToAddRows = false;
            this.dataGridView_Orders.AllowUserToDeleteRows = false;
            this.dataGridView_Orders.AllowUserToResizeColumns = false;
            this.dataGridView_Orders.AllowUserToResizeRows = false;
            this.dataGridView_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_Orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Orders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Orders.Location = new System.Drawing.Point(74, 451);
            this.dataGridView_Orders.Name = "dataGridView_Orders";
            this.dataGridView_Orders.ReadOnly = true;
            this.dataGridView_Orders.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Orders.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Orders.Size = new System.Drawing.Size(446, 228);
            this.dataGridView_Orders.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, -184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox_MissingInfo
            // 
            this.groupBox_MissingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_MissingInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MissingInfo.Controls.Add(this.label_MobileError);
            this.groupBox_MissingInfo.Controls.Add(this.label_FullNameError);
            this.groupBox_MissingInfo.Controls.Add(this.button_AddMissing);
            this.groupBox_MissingInfo.Controls.Add(this.label2);
            this.groupBox_MissingInfo.Controls.Add(this.label1);
            this.groupBox_MissingInfo.Controls.Add(this.textBox_Mobile);
            this.groupBox_MissingInfo.Controls.Add(this.textBox_FullName);
            this.groupBox_MissingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_MissingInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_MissingInfo.Location = new System.Drawing.Point(84, 29);
            this.groupBox_MissingInfo.Name = "groupBox_MissingInfo";
            this.groupBox_MissingInfo.Size = new System.Drawing.Size(1093, 160);
            this.groupBox_MissingInfo.TabIndex = 3;
            this.groupBox_MissingInfo.TabStop = false;
            this.groupBox_MissingInfo.Text = "Add missing information";
            // 
            // label_MobileError
            // 
            this.label_MobileError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MobileError.AutoSize = true;
            this.label_MobileError.ForeColor = System.Drawing.Color.Red;
            this.label_MobileError.Location = new System.Drawing.Point(783, 88);
            this.label_MobileError.Name = "label_MobileError";
            this.label_MobileError.Size = new System.Drawing.Size(0, 20);
            this.label_MobileError.TabIndex = 6;
            // 
            // label_FullNameError
            // 
            this.label_FullNameError.AutoSize = true;
            this.label_FullNameError.ForeColor = System.Drawing.Color.Red;
            this.label_FullNameError.Location = new System.Drawing.Point(103, 88);
            this.label_FullNameError.Name = "label_FullNameError";
            this.label_FullNameError.Size = new System.Drawing.Size(0, 20);
            this.label_FullNameError.TabIndex = 5;
            // 
            // button_AddMissing
            // 
            this.button_AddMissing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_AddMissing.FlatAppearance.BorderSize = 0;
            this.button_AddMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddMissing.Location = new System.Drawing.Point(3, 119);
            this.button_AddMissing.Name = "button_AddMissing";
            this.button_AddMissing.Size = new System.Drawing.Size(1087, 38);
            this.button_AddMissing.TabIndex = 4;
            this.button_AddMissing.Text = "Add";
            this.button_AddMissing.UseVisualStyleBackColor = true;
            this.button_AddMissing.Click += new System.EventHandler(this.button_AddMissing_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name:";
            // 
            // textBox_Mobile
            // 
            this.textBox_Mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Mobile.Location = new System.Drawing.Point(787, 59);
            this.textBox_Mobile.Name = "textBox_Mobile";
            this.textBox_Mobile.Size = new System.Drawing.Size(194, 26);
            this.textBox_Mobile.TabIndex = 1;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(107, 59);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(195, 26);
            this.textBox_FullName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GroceryStore.Properties.Resources.blurred_supermarket_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 709);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1240, 709);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox_MissingInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Order";
            this.Text = "Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).EndInit();
            this.groupBox_MissingInfo.ResumeLayout(false);
            this.groupBox_MissingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox_MissingInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Mobile;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddMissing;
        private System.Windows.Forms.Label label_MobileError;
        private System.Windows.Forms.Label label_FullNameError;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView_Orders;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_DeleteFromOrder;
        private System.Windows.Forms.Label label_DeleteFromOrderError;
        private System.Windows.Forms.Label label_QuantityError;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Button button_SaveOrder;
        private System.Windows.Forms.Panel panel1;
    }
}