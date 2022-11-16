using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSBFP.forms
{
    public partial class frmDashboard : Form
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Record record = new functions.Record();


        public frmDashboard()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.frmAbout about = new forms.frmAbout();
            about.ShowDialog();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.frmNewItem newItem = new forms.frmNewItem();
            newItem.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            record.LoadDRRErecords();
            lblDRRE.Text = val.DRREequipment.ToString();
        }
    }
}
