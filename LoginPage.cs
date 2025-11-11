using Cafe_Management_System.UserControls;

namespace Cafe_Management_System
{

    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsrnm_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Functions dB = new Functions();

            if (dB.Login(txtUsrnm.Text, txtPsswd.Text))//if function returns true open next page.
            {
                this.Controls.Clear();
                LoginPanel.Dispose();
                this.Controls.Add(new HomePage());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsrnm.Clear();
            txtPsswd.Clear();
        }

        private void chkShowpsswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowpsswd.Checked)
            {
                txtPsswd.PasswordChar = '\0';
            }
            else
            {
                txtPsswd.PasswordChar = '*';

            }
        }

        private void lblUsernm_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
