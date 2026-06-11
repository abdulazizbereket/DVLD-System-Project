using DVDL_System.Properties;
using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {

        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPerson
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int PerosnID)
        {
            _Person  = clsPerson.FindpID(PerosnID);
            if (_Person == null)
            {
                ResetValues();
                MessageBox.Show("The Selected Person Is Not Found!", "Error Finding Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetValues();
                MessageBox.Show("The Selected Person Is Not Found!", "Error Finding Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void ResetValues()
        {
            _PersonID = -1;
            lblPhone.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblPhone.Text = "[????]";
            lblEmail.Text = "[????]";
            lblGender.Text = "[????]";
            lblAddress.Text = "[????]";
            lblCountry.Text = "[????]";
            lblDate.Text = "[????]";
            pbImage.Image = Resources.Male_512;
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;
            string ImagePath = _Person.ImagePath;
            if(ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("The Image Was Not Found ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void _FillPersonInfo()
        {
            lblLink.Visible = true;
            _PersonID = _Person.PersonID;
            lblID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName();
            lblNationalNo.Text = _Person.NationalNo.ToString();
            lblGender.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblPhone.Text = _Person.Phone.ToString();
            lblAddress.Text= _Person.Address.ToString();
            lblEmail.Text = _Person.Email.ToString();
            lblDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Person.CountryInfo.CountryName.ToString();

            _LoadPersonImage();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frmUpdate = new frmAddEditPerson(_PersonID);
            frmUpdate.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
