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
    public partial class frmShowUserInfo : Form
    {
        int _UserID;
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ctrlUserInfo1.LoadUserInfo(UserID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
