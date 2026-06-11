using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVDL_System.Users
{
    public partial class frmAddEditNewUser : Form
    {
        clsUser _User;
        int _UserID = -1;
        int _PersonID = -1;
        enum enMode { eAdd = 1, eUpdate = 2 };
        enMode Mode= enMode.eAdd;
        public frmAddEditNewUser()
        {
            InitializeComponent();
            enMode Mode = enMode.eAdd;
            _User = new clsUser();
        }
        public frmAddEditNewUser(int UserID)
        {
            InitializeComponent();
            _UserID= UserID;
            Mode = enMode.eUpdate;

        }
        private void _FillData()
        {
            _User = clsUser.Find(_UserID);
            ctrlPersonCardWithFIlter1.FilterEnabled = false;
            if (_User == null)
            {
                MessageBox.Show("No User With This ID");
                this.Close();
                return;
            }

            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtPasswordConfirm.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFIlter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardWithFIlter1.SelectPerson();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.eUpdate)
            {
                btnSave.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                return;

            }
            if (ctrlPersonCardWithFIlter1.PersonID != -1)
            {
                
                 if (clsUser.IsPerson_User(_PersonID))
                 {
                    MessageBox.Show("This Person Is All Ready Exist As A User You Cannot Make Another User ");
                    ctrlPersonCardWithFIlter1.SetFocus();
                 }
                else
                {
                    btnSave.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                }
            }
            else
            {
                MessageBox.Show("Select A Person To Create A New User ","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ctrlPersonCardWithFIlter1.SetFocus();
            }
            
        }

        private void ctrlPersonCardWithFIlter1_OnPersonSelected(int obj)
        {
            _PersonID = ctrlPersonCardWithFIlter1.PersonID;
        }

        private void ValidateRequiredField(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txt, "");
            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            ValidateRequiredField((TextBox)sender,e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField((TextBox)sender,e);

        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField((TextBox)sender,e);
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider1.SetError(txtPasswordConfirm, "The Password Is Not Same Please Fill The Plank With Right Info");
            }
        }
        private void _ResetValues()
        {
            //ctrlPersonCardWithFIlter1.LoadPersonInfo(-1);
            if (Mode == enMode.eAdd)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                ctrlPersonCardWithFIlter1.SetFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                btnSave.Enabled = true;
            }
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtPasswordConfirm.Text = "";
            chkIsActive.Checked = true;

        }
        private void Save()
        {
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;
            _User.PersonID = _PersonID;
            if (_User.Save())
            {
                Mode = enMode.eUpdate;
                lblUserID.Text = _User.UserId.ToString();
                lblTitle.Text = "Update User" + _User.UserId;
                this.Text = "Update User";
                MessageBox.Show("Data Was Saved Successfuly With User ID " + _User.UserId.ToString());
            }
            else
            {
                MessageBox.Show("Error Was Happend User Wasnt Add ");
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordConfirm.Text))
            {
                errorProvider1.SetError(txtPasswordConfirm, "Password Confirm is required");
                isValid = false;
            }

            return isValid;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fix validation errors first.");
                return;
            }
            Save();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            
            _ResetValues();
            if (Mode == enMode.eUpdate)
            {
                _FillData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void ctrlPersonCardWithFIlter1_Load(object sender, EventArgs e)
        {

        }
    }
}
