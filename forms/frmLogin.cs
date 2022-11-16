using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSBFP
{
    public partial class frmLogin : Form
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to logout?",
                "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                val.Username = null;
                login.Show();
            } else
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit the program?",
                "EXIT", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login.AuthenticateUser(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show(this, "Login Sucessful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                forms.frmDashboard dashboard = new forms.frmDashboard();
                dashboard.FormClosing += new FormClosingEventHandler(Dashboard_FormClosing);
                dashboard.Show();
            } else
            {
                MessageBox.Show(this, "Incorrect username or password",
                    "Authetication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

            bool source_result = mysql.check_connection(connection.conString);
            if (source_result == false)
            {
                toolStripServerStatus.Text = "DISCONNECTED";
                toolStripServerStatus.ForeColor = Color.Red;
            }
            else
            {
                toolStripServerStatus.Text = "CONNECTED";
                toolStripServerStatus.ForeColor = Color.Green;
            }
        }
    }
}
