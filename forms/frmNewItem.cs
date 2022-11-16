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
    public partial class frmNewItem : Form
    {
        components.Connection connection = new components.Connection();
        functions.Items items = new functions.Items();
        
        public frmNewItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Changes will not be saved. Are you sure you want to exit?",
                "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Are you sure all data is correct?",
                "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int quantity = int.Parse(txtQuantity.Text);
                    addProgressbar.Minimum = 0;
                    addProgressbar.Maximum = quantity;
                    addProgressbar.Visible = true;

                    for (int i = 0; i < quantity; i++)
                    { 

                        items.AddItemRecord(cboArticle.Text, cboCategory.Text, txtDescription.Text, txtPropertyNum.Text, cboUnit.Text, txtDateAcquired.Value,
                            double.Parse(txtUnitValue.Text), 1, cboRegion.Text, txtPARnum.Text, txtReference.Text);
                        addProgressbar.Value = i;
                    }
                    addProgressbar.Value = quantity;
                    MessageBox.Show(this, "Data sucessfuly saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addProgressbar.Visible = false;
                }

            }

            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                MessageBox.Show(this, "Please check your data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
       
        }

        // Added functions
        public void SetNumbersOnly(TextBox txt, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '*')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtQuantity, e);
        }

        private void txtUnitValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtUnitValue, e);
        }
    }
}
