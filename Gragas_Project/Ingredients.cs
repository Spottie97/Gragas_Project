using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gragas_Project
{
    public partial class fIngredients : Form
    {
        public fIngredients()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fNavigation myNav = new fNavigation();
            myNav.Show();
        }

        private void fIngredients_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programming_Projects\Gragas_Project\Gragas_Project\DairyProducts.mdf;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(conn);
            myConn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Ingredients", myConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvIngredient.DataSource = dt;

        }
    }
}
