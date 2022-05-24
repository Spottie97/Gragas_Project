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
    public partial class fProduct : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programming_Projects\Gragas_Project\Gragas_Project\DairyProducts.mdf;Integrated Security=True";
        public fProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            fNavigation myNav = new fNavigation();
            myNav.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.Close();
            fCalculations myCalculations = new fCalculations();
            myCalculations.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //This allows you to update the edited data on the database to ensure the changes are made.

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
            fNewProduct myNewProd = new fNewProduct();
            myNewProd.Show();
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        private void ProductList()
        {
            //Here is where we add the Products for the dropdown box, they are hardcoded for now as they are the base products.
            cbProductName.Items.Clear();
            cbProductName.Items.Add("Cheddar");
            cbProductName.Items.Add("Drinking Yogurt");
            cbProductName.Items.Add("Dubble Thick Yogurt");
            cbProductName.Items.Add("Edam");
            cbProductName.Items.Add("Feta");
            cbProductName.Items.Add("Gouda");
            cbProductName.Items.Add("Halloumi");
            cbProductName.Items.Add("Low Fat Yogurt");
            cbProductName.Items.Add("Milk");
            cbProductName.Items.Add("Mozzarella");
            cbProductName.Items.Add("Roomkaas");
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This is the code for the dropdown box, code here will be assigned based on the product selected. I will be trying to make use of pointers for this code instead of If and else.
            if (cbProductName.SelectedIndex == 0)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Cheddar", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 1)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from DrinkingYogurt", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 2)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from DubbleThickYogurt", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 3)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Edam", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 4)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Feta", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 5)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Gouda", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 6)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Halloumi", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 7)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from LowFatYogurt", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 8)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Milk", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 9)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Mozzarella", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
            else if (cbProductName.SelectedIndex == 10)
            {
                SqlConnection myConn = new SqlConnection(conn);
                myConn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from Roomkaas", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }

        }
    }
}
