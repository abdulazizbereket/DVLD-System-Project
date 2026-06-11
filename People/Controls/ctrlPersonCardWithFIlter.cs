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

namespace DVDL_System.People.Controls
{
    public partial class ctrlPersonCardWithFIlter : UserControl
    {
        // Define Acactum Event Handler delegate 
        public event Action<int> OnPersonSelected;
        // Create A Protedted Method To Raise The Event
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
                handler(PersonID);
        }
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set {
                _ShowAddPerson = value; 
                btnAdd.Visible = _ShowAddPerson;
                }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
                }
        }
        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPerson; }
        }

        public ctrlPersonCardWithFIlter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAdd = new frmAddEditPerson();
            frmAdd.DataBack += DataBackEvent;
            frmAdd.ShowDialog();

        }
        public void LoadPersonInfo(int PersonID)
        {
            cmbFilter.SelectedIndex = 1;
            txtText.Text  = PersonID.ToString();
            _FindNow();
        }
        private void _FindNow()
        {
            if (string.IsNullOrEmpty(txtText.Text))
                return;
            switch (cmbFilter.Text)
            {
                case "National No":
                    ctrlPersonCard1.LoadPersonInfo(txtText.Text.Trim());
                    break;

                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtText.Text));
                    break;

                default:
                    break;
            }
            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonCard1.PersonID);

        }
        private void DataBackEvent(object sender, int PersonID)
        {
            txtText.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            cmbFilter.SelectedIndex = 1;
            btnSelect.Visible = (PersonID != -1);
            

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtText.Text = "";
            txtText.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Filed Are Required ,Put The Mouse Over The Red Icon's To See The Errors", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }

        private void ctrlPersonCardWithFIlter_Load(object sender, EventArgs e)
        {
            txtText.Focus();
            cmbFilter.SelectedIndex = 0;
        }

        private void txtText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtText.Text.Trim()))
            {
               
                errorProvider1.SetError(txtText, "This Filed Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtText, null);
            }
        }
        public void SetFocus()
        {
            txtText.Focus();
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonCard1.PersonID);
            btnSelect.Visible = false; 
        }
        public void SelectPerson()
        {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            btnSelect.Visible = false;

        }
        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}
