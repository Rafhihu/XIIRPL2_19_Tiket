using XIIRPL2_19_Tiket.MasterForm;

namespace XIIRPL2_19_Tiket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDaftar frmDaftar = new FrmDaftar();
            frmDaftar.Show();
            this.Close();
        }
    }
}