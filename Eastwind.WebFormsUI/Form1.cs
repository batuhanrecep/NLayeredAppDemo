﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eastwind.Business.Abstract;
using Eastwind.Business.Concrete;
using Eastwind.DataAccess.Concrete.EntityFramework;
using Eastwind.DataAccess.Concrete.NHibernate;

namespace Eastwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //For solid principles, we should use dependency injection and DI containers for this
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }



        //private IProductService _productService = new ProductManager(new NhProductDal());
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
                
            }
           

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }
    }
}
