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
            DataTable dt = new DataTable();
            dt = clsUser.GetAllUsers();
            dgvUsers.DataSource = dt;
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
    }
}
