
namespace Gragas_Project
{
    public partial class fWelcome : Form
    {
        public fWelcome()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            StartUp();
            this.tProgress.Start();
            await Task.Delay(7000);
            Switch();
            this.Hide();

        }
        private static void StartUp()
        {  
            fNavigation myNav = new fNavigation();
            myNav.Hide();   

        }
        private static async void Switch()
        {
            
            fNavigation myNav = new fNavigation();
            myNav.Show();
        }

        private void tProgress_Tick(object sender, EventArgs e)
        {
            this.pBLoadingStart.Increment(1);
        }

        private void h1_Click(object sender, EventArgs e)
        {
            
        }
    }
}