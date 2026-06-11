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
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEventHandeler(object sender, int PersonID);
        public event DataBackEventHandeler Databack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Databack?.Invoke(this, ctrlPersonCardWithFIlter1.PersonID);
        }

        private void ctrlPersonCardWithFIlter1_Load(object sender, EventArgs e)
        {

        }
    }
}
