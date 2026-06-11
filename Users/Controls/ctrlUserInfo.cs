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

namespace DVDL_System.Users.Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        clsUser _User;
        private int _UserID= -1;
        public int UserID
        {
            get {  return _UserID; }
        }
        public void LoadUserInfo(int UserId)
        {
            _UserID = UserId;
            _User = clsUser.Find(UserId);
            if (_User == null)
            {
                _ResetValues(); 
                MessageBox.Show($"No User With User ID = {_UserID}","Didnt Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();

        }
        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserId.ToString();
            lblUserName.Text = _User.UserName.ToString();
            lblActive.Text = (_User.IsActive ? "Yes" : "No"); 
        }

        private void _ResetValues()
        {
            ctrlPersonCard1.ResetValues();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblActive.Text = "[???]";
        }
        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
