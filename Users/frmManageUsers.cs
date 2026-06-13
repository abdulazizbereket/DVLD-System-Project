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

namespace DVDL_System.Users
{
    public partial class frmManageUsers : Form
    {
        private static DataTable _dtAllUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new frmAddEditNewUser();
            frmAddUser.ShowDialog();
            _RefreshUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _RefreshUsers()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cmbFilter.SelectedIndex = 0;
            lblRecords.Text = dgvUsers.Rows.Count.ToString();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsers();
            cmbFilter.SelectedIndex = 0;
            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 93;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 92;

                dgvUsers.Columns[2].HeaderText = "Full Name ";
                dgvUsers.Columns[2].Width = 252;

                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 154;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 95;


            }
        }

        private void adsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new frmAddEditNewUser();
            frmAddUser.ShowDialog();
            _RefreshUsers();
        }

        private void asdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmAddEditNewUser frmAddUser = new frmAddEditNewUser(UserID);
            frmAddUser.ShowDialog();
            _RefreshUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete This User", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfully");
                    _RefreshUsers();
                }
            else
                {
                    MessageBox.Show("This Person Cannot Be Deleted Cause Of Connected In other Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                {
                    MessageBox.Show("Some Thing Went Wrong Please User Didnt Delete");
                }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            Form frmChangePass = new frmChangePassword(UserID);
            frmChangePass.ShowDialog();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Is Active")
            {
                txtFilterText.Visible = false;
                cmbIsActive.Visible = true;
                cmbIsActive.SelectedIndex = 0;
                cmbIsActive.Focus();
            }
            else
            {
                txtFilterText.Visible = (cmbFilter.Text.Trim() != "None");
                cmbIsActive.Visible = false;
                txtFilterText.Text = "";
                txtFilterText.Focus();
            }
        }

        private void txtFilterText_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            

            if (txtFilterText.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecords.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "UserName" && FilterColumn != "FullName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterText.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterText.Text.Trim());

            lblRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cmbIsActive.Text;
            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }
            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}]  = {1}", FilterColumn, FilterValue);

            lblRecords.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txtFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Person ID" || cmbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
