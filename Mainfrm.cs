using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDL_System.Global_Classes;
using DVDL_System.People;
using DVDL_System.Users;
using DVDLBusinussLayer;
namespace DVDL_System
{
    public partial class Mainfrm : Form
    {
        frmLogin _frmLogin;
        public Mainfrm(frmLogin login)
        {
            InitializeComponent();
            _frmLogin = login;
        }
 

        private void Mainfrm_Load(object sender, EventArgs e)
        {
        }
        private void _UnderDevelopment()
        {
            MessageBox.Show("This functionality is currently under development and will be added in upcoming releases.", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople frmPeople  = new frmManagePeople();
            frmPeople.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UnderDevelopment();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUsers = new frmManageUsers();
            frmUsers.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGeneral.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(clsGeneral.CurrentUser.UserId);

            frmChangePassword.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmUserInfo = new frmShowUserInfo(clsGeneral.CurrentUser.UserId);
            frmUserInfo.Show();
        }
    }
}
