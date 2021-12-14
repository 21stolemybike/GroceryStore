namespace GroceryStore
{
    partial class MenuAdmin
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
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.button_AboutUs = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_Manage = new System.Windows.Forms.Button();
            this.button_Reports = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.Panel_ShowMenus = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Menu.Controls.Add(this.button_Products);
            this.Panel_Menu.Controls.Add(this.button_Order);
            this.Panel_Menu.Controls.Add(this.button_LogOut);
            this.Panel_Menu.Controls.Add(this.button_AboutUs);
            this.Panel_Menu.Controls.Add(this.button_Reports);
            this.Panel_Menu.Controls.Add(this.button_Manage);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(322, 748);
            this.Panel_Menu.TabIndex = 0;
            // 
            // button_AboutUs
            // 
            this.button_AboutUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_AboutUs.FlatAppearance.BorderSize = 0;
            this.button_AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AboutUs.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AboutUs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AboutUs.Location = new System.Drawing.Point(0, 701);
            this.button_AboutUs.Name = "button_AboutUs";
            this.button_AboutUs.Size = new System.Drawing.Size(318, 43);
            this.button_AboutUs.TabIndex = 5;
            this.button_AboutUs.Text = "❓          About us";
            this.button_AboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AboutUs.UseVisualStyleBackColor = true;
            // 
            // button_LogOut
            // 
            this.button_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LogOut.FlatAppearance.BorderSize = 0;
            this.button_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogOut.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_LogOut.Location = new System.Drawing.Point(-2, 466);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(318, 46);
            this.button_LogOut.TabIndex = 4;
            this.button_LogOut.Text = "🚪           Log Out";
            this.button_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_Manage
            // 
            this.button_Manage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Manage.FlatAppearance.BorderSize = 0;
            this.button_Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Manage.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Manage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Manage.Location = new System.Drawing.Point(-2, 407);
            this.button_Manage.Name = "button_Manage";
            this.button_Manage.Size = new System.Drawing.Size(316, 53);
            this.button_Manage.TabIndex = 3;
            this.button_Manage.Text = "☀   Manage Account";
            this.button_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Manage.UseVisualStyleBackColor = true;
            this.button_Manage.Click += new System.EventHandler(this.button_Manage_Click);
            // 
            // button_Reports
            // 
            this.button_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reports.FlatAppearance.BorderSize = 0;
            this.button_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reports.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reports.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Reports.Location = new System.Drawing.Point(1, 303);
            this.button_Reports.Name = "button_Reports";
            this.button_Reports.Size = new System.Drawing.Size(315, 54);
            this.button_Reports.TabIndex = 2;
            this.button_Reports.Text = "✔           Reports";
            this.button_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Reports.UseVisualStyleBackColor = true;
            // 
            // button_Order
            // 
            this.button_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Order.FlatAppearance.BorderSize = 0;
            this.button_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Order.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Order.Location = new System.Drawing.Point(3, 354);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(322, 47);
            this.button_Order.TabIndex = 1;
            this.button_Order.Text = "⛟              Shop";
            this.button_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_Products
            // 
            this.button_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Products.FlatAppearance.BorderSize = 0;
            this.button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Products.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Products.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Products.Location = new System.Drawing.Point(-2, 257);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(318, 40);
            this.button_Products.TabIndex = 0;
            this.button_Products.Text = "🍞          Products";
            this.button_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // Panel_ShowMenus
            // 
            this.Panel_ShowMenus.BackColor = System.Drawing.Color.Black;
            this.Panel_ShowMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ShowMenus.Location = new System.Drawing.Point(322, 0);
            this.Panel_ShowMenus.Name = "Panel_ShowMenus";
            this.Panel_ShowMenus.Size = new System.Drawing.Size(1256, 748);
            this.Panel_ShowMenus.TabIndex = 0;
            // 
            // MenuAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1578, 748);
            this.Controls.Add(this.Panel_ShowMenus);
            this.Controls.Add(this.Panel_Menu);
            this.MinimumSize = new System.Drawing.Size(1475, 705);
            this.Name = "MenuAdmin";
            this.Text = "AdminGroceryStore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_ShowMenus;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_AboutUs;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_Manage;
        private System.Windows.Forms.Button button_Reports;
    }
}

