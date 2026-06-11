using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_System.People
{
    public partial class frmPersonDetails : Form
    {
        int PersonID;
        public frmPersonDetails(int pID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(pID);

        }
        public frmPersonDetails(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NationalNo);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
