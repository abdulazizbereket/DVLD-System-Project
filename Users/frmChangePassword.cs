using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID = -1;
        clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

        }

      
      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Your Current Password Is Not True Please Check Your Information ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _User.Password = txtNewPassword.Text;
                if (_User.Save())
                {
                    MessageBox.Show("Saved Successfully");
                }
                else
                    MessageBox.Show("Didnt Save");
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm.Text.Trim() != txtNewPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirm, "Incurrect This Filed should Be Same As The Password");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirm, "");

            }
        }

        private void txtCurrentPassword_Validating(object sender,CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text.Trim()))
            {
                errorProvider1.SetError(
                    txtCurrentPassword,
                    "Current password is required.");

                e.Cancel = true;
                return;
            }
            else if (!_User.CheckIfPasswordIsTrue(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(
                    txtCurrentPassword,
                    "Current password is incorrect.");

                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(
                    txtCurrentPassword,
                    "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtNewPassword, "The New Password Is Required");
                e.Cancel = true;
            }
            if (txtCurrentPassword.Text == txtNewPassword.Text)
            {
                errorProvider1.SetError(txtNewPassword, "The New Password Shouldn't Be The Same As The Old Password");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");

            }
        }
        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirm.Text = "";
            txtCurrentPassword.Focus(); 
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
           
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show($"Couldn't Find The User With This ID = {_UserID}" , "Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUserInfo1.LoadUserInfo(_User.UserId);
        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
