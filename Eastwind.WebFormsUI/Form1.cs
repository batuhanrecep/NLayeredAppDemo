using System;
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
        }



        //private IProductService _productService = new ProductManager(new NhProductDal());
        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        { 
            
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
