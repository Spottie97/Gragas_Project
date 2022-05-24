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
    public partial class fCalculations : Form
    {
        public fCalculations()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fNavigation myNav = new fNavigation();
            myNav.Show();
        }
    }
}
