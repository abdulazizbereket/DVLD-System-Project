using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DVDL_System.People
{
    public partial class frmManagePeople : Form
    {
        private readonly string[] _PeopleColumns =
        {
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gendor",
            "DateOfBirth",
            "CountryName",
            "Phone",
            "Email"

        };
        private DataTable _dtAllPeople;

        private DataTable _dtPeople;


        public frmManagePeople()
        {
            InitializeComponent();
        }
        private void _RefreshPeople()
        {
             _dtAllPeople = clsPerson.GetAllPersons();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, _PeopleColumns);
            dgvPeople.DataSource = _dtPeople;
            lblRecords.Text = dgvPeople.Rows.Count.ToString();
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshPeople();
            cmFilter.SelectedIndex = 0;
            //int CountOfPerson = _dtPeople.Rows.Count;
            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;

                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 130;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Country Name";
                dgvPeople.Columns[8].Width = 120;

                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;

                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;

            }
        }
        private void _FunctionAddEditNew(int PersonID)
        {
            frmAddEditPerson frmAddEdit = new frmAddEditPerson(PersonID);
            frmAddEdit.ShowDialog();
            _RefreshPeople();
        }
        private void _FunctionAddEditNew()
        {
            frmAddEditPerson frmAddEdit = new frmAddEditPerson();
            frmAddEdit.ShowDialog();
            _RefreshPeople();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _FunctionAddEditNew();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAddEditPerson frmPerson = new frmAddEditPerson();
            int PID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            _FunctionAddEditNew(PID);
        }

     
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FunctionAddEditNew();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PID = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
            clsPerson pp = clsPerson.FindpID(PID);
            if (clsPerson.Deleteperson(PID))
            {
                MessageBox.Show($"This Person {PID}Was Deleted Successfuly ");
             
                    if (pp.ImagePath != "")
                       System.IO.File.Delete(pp.ImagePath);
                 
                _RefreshPeople();


            }
            else
            {
                MessageBox.Show("Error Was Happend Person Is Not Deleted","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _UnderDevelopment()
        {
            MessageBox.Show("This functionality is currently under development and will be added in upcoming releases.", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UnderDevelopment();
        }

        private void sendPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _UnderDevelopment();
        }

      
        private void personInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmPersonDetails frmDetails = new frmPersonDetails((int)dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
            frmDetails.ShowDialog();
            _RefreshPeople();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonId";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecords.Text = dgvPeople.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "PersonId" || FilterColumn == "NationalNo")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]  = {1}", FilterColumn, txtValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtValue.Text.Trim());
            lblRecords.Text = dgvPeople.Rows.Count.ToString();
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Visible = !(cmFilter.Text == "None");


            if (txtValue.Visible)
            {
                txtValue.Text = "";
                txtValue.Focus();
            }
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFilter.Text == "Person ID" || cmFilter.Text == "National No")
                e.Handled = !char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }
    }
}
