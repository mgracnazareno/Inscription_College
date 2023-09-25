using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectFinal
{
    public partial class FormTest : Form
    {
        ErrorProvider ErrorProvider = new ErrorProvider();
        public FormTest()
        {
            InitializeComponent();
            txtCode.Enabled = false;
            txtCode.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTimePicker dtp = new DateTimePicker();
            try
            {
                string code = txtFname.Text.Substring(0, 3) + txtLname.Text.Substring(0, 1);
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                string date = dtpDate.Text;

                //txtCode.Show();
                //txtCode.Enabled = true;
                // txtCode.ReadOnly = true;
                txtCode.Text = code.ToUpper();
                txtFname.Text = fname.ToUpper();
                txtFname.Text = lname.ToUpper();
                lblDate.Text = dtp.Value.ToShortDateString();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            //txtCode.Hide();
            
           
        }

        private void txtLname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();

        }
        private bool ValidateName()
        {

            bool bStatus = true;
            if ((string.IsNullOrEmpty(txtLname.Text) || (txtFname.Text.Length < 3)))
            {
                ErrorProvider.SetError(txtFname, "Nom doit etre au moins 3 letters");
                bStatus = false;
            }
            else
                ErrorProvider.SetError(txtFname, "");
            return bStatus;

        }

        private void txtFname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            ValidatePrenom();
        }
        private bool ValidatePrenom()
        {

            bool bStatus = true;
            if (string.IsNullOrEmpty(txtFname.Text) || (txtFname.Text.Length < 1))
            {
                ErrorProvider.SetError(txtFname, "Prenom must be more thatn 1 character");
                bStatus = false;
            }
            else
                ErrorProvider.SetError(txtFname, "");
            return bStatus;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
