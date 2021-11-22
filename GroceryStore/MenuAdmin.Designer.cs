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
            this.Panel_ShowMenus = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_Menu.Controls.Add(this.button1);
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(319, 609);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Panel_ShowMenus
            // 
            this.Panel_ShowMenus.AutoSize = true;
            this.Panel_ShowMenus.BackColor = System.Drawing.SystemColors.ControlText;
            this.Panel_ShowMenus.Location = new System.Drawing.Point(325, 0);
            this.Panel_ShowMenus.Name = "Panel_ShowMenus";
            this.Panel_ShowMenus.Size = new System.Drawing.Size(1299, 0);
            this.Panel_ShowMenus.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(0, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1299, 609);
            this.Controls.Add(this.Panel_ShowMenus);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "MenuAdmin";
            this.Text = "AdminGroceryStore";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_ShowMenus;
        private System.Windows.Forms.Button button1;
    }
}

