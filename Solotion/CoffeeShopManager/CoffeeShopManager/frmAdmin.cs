﻿using CoffeeShopManager.DAO;
using CoffeeShopManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManager
{
    public partial class frmAdmin : Form
    {
        BindingSource drinkList = new BindingSource();
        public frmAdmin()
        {
            InitializeComponent();
            loadAll();

        }
        #region Method
        void loadAll()
        {
            dgvDrink.DataSource = drinkList;
            loadListBillByDate(dtpFromDate.Value, dtpEndDate.Value);
            loadDateTimePickerBill();
            loadListDrink();
            addDrinkBinding();
            loadCategoryToComboBox(cbDrinkCategory);
        }
        void loadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpEndDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void loadListBillByDate(DateTime dateCheckin, DateTime dateCheckout)
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBillByDate(dateCheckin, dateCheckout);

        }

        void loadListDrink()
        {
            drinkList.DataSource = DrinkDAO.Instance.GetListDrink();
        }
        void addDrinkBinding()
        {
            txtDrinkName.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtDrinkID.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void loadCategoryToComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";

        }
        #endregion

        #region Events 
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            loadListBillByDate(dtpFromDate.Value, dtpEndDate.Value);
        }
        private void btnViewDrink_Click(object sender, EventArgs e)
        {
            loadListDrink();
        }
        private void txtDrinkID_TextChanged(object sender, EventArgs e)
        {
            if (dgvDrink.SelectedCells.Count > 0)
            {
                int id = (int)dgvDrink.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbDrinkCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cbDrinkCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbDrinkCategory.SelectedIndex = index;
            }
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            string name = txtDrinkName.Text;
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            double price = Convert.ToDouble(txtPrice.Text);
            if (DrinkDAO.Instance.InsertDrink(name, idCategory, price))
            {
                MessageBox.Show("Thêm thành công");
                loadListDrink();
                if (insertDrink != null)
                {
                    insertDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }
        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            string name = txtDrinkName.Text;
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            double price = Convert.ToDouble(txtPrice.Text);
            int idDrink = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.UpdateDrink(idDrink, name, idCategory, price))
            {
                MessageBox.Show("Sửa thành công");
                loadListDrink();
                if (insertDrink != null)
                {
                    insertDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }
        }
        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            int idDrink = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.DeleteDrink(idDrink))
            {
                MessageBox.Show("Xóa thành công");
                loadListDrink();
                if (deleteDrink != null)
                {
                    deleteDrink(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        #region EventHandler
        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        { 
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        #endregion

        #endregion


    }
}
