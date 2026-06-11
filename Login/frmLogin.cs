using DVDL_System.Global_Classes;
using DVDLBusinussLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVDL_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.GetUserByUserNameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());
            if (User != null)
            {
                if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("The User Is not Active Please Contact Your Admin");
                    return;
                }
                clsGeneral.CurrentUser = User;
                this.Hide();
                Mainfrm  frm = new Mainfrm(this);

                frm.ShowDialog();

            }


         else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void NullValidate(object sender, CancelEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrEmpty(text.Text))
            {
                errorProvider1.SetError(text, "Fill The Plank");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void _ResetValues()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            checkBox1.Checked = false;
            txtUserName.Focus();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _ResetValues();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
