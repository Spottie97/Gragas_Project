using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Project
{
    public partial class fNavigation : Form
    {
        public fNavigation()
        {
            InitializeComponent();
        }

        private void kaasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cheddarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            this.Close();
            fProduct myProduct = new fProduct();
            myProduct.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            this.Close();
            fIngredients myIngredients = new fIngredients();    
            myIngredients.Show();
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Close();
            fExport myExport = new fExport();
            myExport.Show();
        }
    }
}
