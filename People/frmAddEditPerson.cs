using DVDL_System.Global_Classes;
using DVDL_System.Properties;
using DVDLBusinussLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.People
{
    public partial class frmAddEditPerson : Form
    {

        public delegate void DataBackEventHandeler(object sender, int PersonID);

        public event DataBackEventHandeler DataBack;


        private enum enGendor { enMale = 0, enFemale = 1 };
        public enum enMode { enAdd = 1, enUpdate };
        public enMode _Mode;
        clsPerson _Person;
        int _PersonID = -1;
        public frmAddEditPerson(int PID)
        {
            InitializeComponent();
            _PersonID = PID;
            _Mode = enMode.enUpdate;
        }
        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.enAdd;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsEmptyValidation(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                errorProvider1.SetError(temp, "This Field Should not Be Empty");
            }
            else
                errorProvider1.SetError(temp, null);
        }
        private bool _HandelPersonImage()
        {
            if (_Person.ImagePath != pbImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);

                    }
                    catch
                    {
                        //Error Happend
                    }
                }

                if (pbImage.ImageLocation != null)
                {
                    string SourceImage = pbImage.ImageLocation.ToString();
                    


                    if (clsUtil.CopyImageToProjectImageFolder(ref SourceImage))
                    {
                        _Person.ImagePath = SourceImage;
                        pbImage.ImageLocation = SourceImage;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image Fiel","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (errorProvider1. == true)
            //{

            //}
            if (!_HandelPersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecond.Text.Trim();
            _Person.ThirdName = txtThird.Text.Trim();
            _Person.LastName = txtLast.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtDate.Value;
            if (rdMale.Checked)
                _Person.Gendor = (short)enGendor.enMale;
            else
                _Person.Gendor = (short)enGendor.enFemale;

            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.NationalityCountryID = clsCountry.GetCountry(ckbCountry.Text).CountryID;

            if (pbImage.ImageLocation != null)
                _Person.ImagePath = pbImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {

                _Mode = enMode.enUpdate;
                lblAddUpdateText.Text = "Update Person ";
                lblPersonID.Text = _Person.PersonID.ToString();
                MessageBox.Show("Your Info Saved Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }   
            else
                MessageBox.Show(" Some Thing Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }
        private void _LoadData()
        {



            _Person = clsPerson.FindpID(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("The Current Person Was Not Found" + _Person.PersonID);
                this.Close();
                return;
            }


            //load
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtDate.Value = _Person.DateOfBirth;
            if (_Person.Gendor == 0)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            ckbCountry.SelectedIndex = ckbCountry.FindString(_Person.CountryInfo.CountryName);
            if (_Person.ImagePath != "")
            {
                pbImage.ImageLocation = _Person.ImagePath;
                llblRemove.Visible = (_Person.ImagePath != "");

            }
        }
        private void _FillCountriesInCompobox()
        {
            DataTable dt = new DataTable();
            dt = clsCountry.GetAllCountries();
            foreach (DataRow dr in dt.Rows)
            {
                ckbCountry.Items.Add(dr["CountryName"]);
            }

        }
        private void _ResetDefualtValues()
        {
            _FillCountriesInCompobox();
            if (_Mode == enMode.enAdd)
            {
                lblAddUpdateText.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
                lblAddUpdateText.Text = "Update Person";

            if (rdMale.Checked)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;

            llblRemove.Visible = (pbImage.ImageLocation != null);
            dtDate.MaxDate = DateTime.Now.AddYears(-18);
            dtDate.Value = dtDate.MaxDate;
            dtDate.MinDate = DateTime.Now.AddYears(-100);

            ckbCountry.SelectedIndex = ckbCountry.FindString("Syria");


            txtFirstName.Text = "";
            txtSecond.Text = "";
            txtThird.Text = "";
            txtLast.Text = "";
            txtNationalNo.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            rdMale.Checked = true;
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.enUpdate)
                _LoadData();

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            IsEmptyValidation(sender, e);

            if (!clsValidation.IsValidNumber(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This National Number is Not Valid");
                return;
            }

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                errorProvider1.SetError(txtNationalNo, "National Number Is Used By Another Person");
            }

            errorProvider1.SetError(txtNationalNo, null);

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            if (txtEmail.Text.Trim() == "")
                return;
            if (clsValidation.IsValidEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, null);
            }
            else
                errorProvider1.SetError(txtEmail, "This Email Is Not Vlaied");

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            IsEmptyValidation(sender, e);
            if (clsValidation.IsValidPhone(txtPhone.Text))
                errorProvider1.SetError(txtPhone, null);
            else
                errorProvider1.SetError(txtPhone, "This Number is Not Valid");
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Female_512;
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Male_512;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "Chose An Image For This Person";
            openFileDialog1.Filter = "Image Files |*.jpg;.*png;*.jpeg;*.gif;";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedIamge = openFileDialog1.FileName;
                pbImage.ImageLocation = SelectedIamge;
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;

            if (rdFemale.Checked)
                pbImage.Image = Resources.Female_512;
            else
                pbImage.Image = Resources.Male_512;
            llblRemove.Visible = false;
        }
    }
}
