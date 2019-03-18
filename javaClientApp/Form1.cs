using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace javaClientApp
{
    public partial class frmServiceClient : Form
    {
        public frmServiceClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            ServiceReference1.ProductDB_APIDelegateClient client = new ServiceReference1.ProductDB_APIDelegateClient();
           lblMessage.Text =  client.getProduct(productCode);
          
        }
        
    }
}
