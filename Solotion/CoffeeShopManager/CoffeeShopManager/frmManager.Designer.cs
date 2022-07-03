﻿namespace CoffeeShopManager
{
    partial class frmManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.itAccInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.itPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.itLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nbDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flbTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChangeTable = new System.Windows.Forms.ComboBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDrinkCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstvBill);
            this.panel2.Location = new System.Drawing.Point(27, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 397);
            this.panel2.TabIndex = 1;
            // 
            // lstvBill
            // 
            this.lstvBill.HideSelection = false;
            this.lstvBill.Location = new System.Drawing.Point(2, 3);
            this.lstvBill.Name = "lstvBill";
            this.lstvBill.Size = new System.Drawing.Size(500, 394);
            this.lstvBill.TabIndex = 0;
            this.lstvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Location = new System.Drawing.Point(560, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 70);
            this.panel3.TabIndex = 2;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(141, 23);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(115, 23);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDiscount.Location = new System.Drawing.Point(17, 19);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(115, 30);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "Khuyến mãi";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(298, 13);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 42);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAdmin,
            this.itAccInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itAdmin
            // 
            this.itAdmin.Name = "itAdmin";
            this.itAdmin.Size = new System.Drawing.Size(55, 20);
            this.itAdmin.Text = "Admin";
            this.itAdmin.Click += new System.EventHandler(this.itAdmin_Click);
            // 
            // itAccInfo
            // 
            this.itAccInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itPersonalInfo,
            this.itLogout});
            this.itAccInfo.Name = "itAccInfo";
            this.itAccInfo.Size = new System.Drawing.Size(122, 20);
            this.itAccInfo.Text = "Thông tin tài khoản";
            // 
            // itPersonalInfo
            // 
            this.itPersonalInfo.Name = "itPersonalInfo";
            this.itPersonalInfo.Size = new System.Drawing.Size(180, 22);
            this.itPersonalInfo.Text = "Thông tin cá nhân";
            this.itPersonalInfo.Click += new System.EventHandler(this.itPersonalInfo_Click);
            // 
            // itLogout
            // 
            this.itLogout.Name = "itLogout";
            this.itLogout.Size = new System.Drawing.Size(180, 22);
            this.itLogout.Text = "Đăng xuất";
            this.itLogout.Click += new System.EventHandler(this.itLogout_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nbDrinkCount);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cbDrink);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(27, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 77);
            this.panel4.TabIndex = 4;
            // 
            // nbDrinkCount
            // 
            this.nbDrinkCount.Location = new System.Drawing.Point(122, 25);
            this.nbDrinkCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbDrinkCount.Name = "nbDrinkCount";
            this.nbDrinkCount.Size = new System.Drawing.Size(88, 23);
            this.nbDrinkCount.TabIndex = 3;
            this.nbDrinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(10, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(225, 42);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(257, 23);
            this.cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(225, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(257, 23);
            this.cbCategory.TabIndex = 0;
            // 
            // flbTable
            // 
            this.flbTable.Location = new System.Drawing.Point(560, 35);
            this.flbTable.Name = "flbTable";
            this.flbTable.Size = new System.Drawing.Size(398, 447);
            this.flbTable.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChangeTable);
            this.panel1.Controls.Add(this.btnChangeTable);
            this.panel1.Location = new System.Drawing.Point(28, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 43);
            this.panel1.TabIndex = 6;
            // 
            // cbChangeTable
            // 
            this.cbChangeTable.FormattingEnabled = true;
            this.cbChangeTable.Location = new System.Drawing.Point(225, 9);
            this.cbChangeTable.Name = "cbChangeTable";
            this.cbChangeTable.Size = new System.Drawing.Size(257, 23);
            this.cbChangeTable.TabIndex = 4;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnChangeTable.Location = new System.Drawing.Point(9, 6);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(200, 30);
            this.btnChangeTable.TabIndex = 6;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flbTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbDrinkCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itAdmin;
        private System.Windows.Forms.ToolStripMenuItem itAccInfo;
        private System.Windows.Forms.ToolStripMenuItem itPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem itLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nbDrinkCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flbTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChangeTable;
        private System.Windows.Forms.Button btnChangeTable;
    }
}