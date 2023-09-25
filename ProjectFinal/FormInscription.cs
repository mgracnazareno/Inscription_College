	using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class FormInscription : Form
    {
        List<Programme> listProg = new List<Programme>();
        List<Etudiant> listEtud = new List<Etudiant>();
        ErrorProvider ErrorProvider = new ErrorProvider();
        static int nbrEtud = 0;
        static int nbrProgramme = 0;
        public FormInscription()
        {
            InitializeComponent();
            txtECode.Enabled = false;
            txtECode.ReadOnly = true;
        }
        private void FormInscription_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            //Creer object de type Programme
            try
            {
                Programme prog = new Programme();
                prog.CodeProgramme = txtCode.Text;
                prog.Domaine = txtDomaine.Text;
                prog.NomProgramme = txtNom.Text;
                prog.NbHeures = int.Parse(txtHeures.Text);
                listProg.Add(prog);
                nbrProgramme++;

                //Vider les champs
                ResetProg();
                MessageBox.Show(listProg.Count.ToString() + " " + "Programme ajouté avec succès!");
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez remplir tous les inputs!");
            }

        }

        private void BtnLister_Click(object sender, EventArgs e)
        {
            dgProgramme.Refresh();
            if (listProg.Count == 0)
            {
                MessageBox.Show("Aucun programme à afficher!");
            }
            else
            {
                try
                {
                    dgProgramme.Rows.Clear();
                    dgProgramme.Columns.Clear();

                    // Adding columns to the DataGridView
                    dgProgramme.Columns.Add("CodeProgramme", "Code Programme");
                    dgProgramme.Columns.Add("Domaine", "Domaine");
                    dgProgramme.Columns.Add("NomProgramme", "Nom Programme");
                    dgProgramme.Columns.Add("NbHeures", "Nombre d'Heures");
                    foreach (Programme prog in listProg)
                    {
                        dgProgramme.Rows.Add(prog.CodeProgramme, prog.Domaine, prog.NomProgramme, prog.NbHeures);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Aucun programme à afficher!");
                }
            }

            //dgProgramme.Refresh();
            //if (listProg.Count == 0)
            //{
            //    MessageBox.Show("Aucun programme à afficher!");
            //}
            //else
            //{
            //    try
            //    {
            //        dgProgramme.Refresh();
            //        dgProgramme.Rows.Clear();
            //        //dgProgramme.Columns.Clear();

            //        //Adding columns to the DataGridView
            //        //dgProgramme.Columns.Add("CodeProgramme", "Code Programme");
            //        //dgProgramme.Columns.Add("Domaine", "Domaine");
            //        //dgProgramme.Columns.Add("NomProgramme", "Nom Programme");
            //        //dgProgramme.Columns.Add("NbHeures", "Nombre d'Heures");
            //        foreach (Programme prog in listProg)
            //        {
            //            dgProgramme.Rows.Add(prog.CodeProgramme, prog.Domaine, prog.NomProgramme, prog.NbHeures);

            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Aucun programme à afficher!");
            //    }
            //}

        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            ResetProg();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dgProgramme.Refresh();
            Programme prog = new Programme();
            prog = prog.GetProgrammeById(listProg, txtCode.Text);
            if (prog != null)
            {
                listProg.Remove(prog);

                //
                dgProgramme.Rows.Clear();

                //nbrProgramme--;

                foreach (Programme progItem in listProg)
                {
                    dgProgramme.Rows.RemoveAt(dgProgramme.CurrentRow.Index);
                    //dgProgramme.Rows.Add(progItem.CodeProgramme, progItem.Domaine, progItem.NomProgramme, progItem.NbHeures);
                    ////listProg.Remove(progItem);
                    ////nbrProgramme--;
                }
                dgProgramme.Refresh();
                ResetProg();
                MessageBox.Show( "Programme supprimé avec succès!");
                nbrProgramme = listProg.Count;
                MessageBox.Show(nbrProgramme.ToString());
            }
            else
            {
                MessageBox.Show("Programme introuvable!");
                ResetProg();
            }
             dgProgramme.Rows.Clear();
            dgProgramme.DataSource = listProg;
        }
        //Programme prog = new Programme();
        //prog = prog.GetProgrammeById(listProg, txtCode.Text);
        //if (prog != null)
        //{
        //    listProg.Remove(prog);
        //    dgProgramme.DataSource = null;
        //    dgProgramme.Rows.Clear();

        //    //refresh data grid view

        //    //foreach (Programme progItem in listProg)
        //    //{
        //    //    dgProgramme.Rows.Add(progItem.CodeProgramme, progItem.Domaine, progItem.NomProgramme, progItem.NbHeures);
        //    //}
        //    dgProgramme.Refresh();
        //    ResetProg();
        //    nbrProgramme = listProg.Count;
        //    MessageBox.Show(nbrProgramme + " " + "Programme supprimé avec succès!");
        //}
        //else
        //{
        //    MessageBox.Show("Programme introuvable!");
        //    ResetProg();
        //}


        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Programme prog = new Programme();
            prog = prog.GetProgrammeById(listProg, txtSearchId.Text);
            if (prog != null)
            {
                txtCode.Text = prog.CodeProgramme;
                txtDomaine.Text = prog.Domaine;
                txtNom.Text = prog.NomProgramme;
                txtHeures.Text = prog.NbHeures.ToString();
                txtSearchId.Clear();
                txtSearchId.Focus();
            }
            else
            {
                MessageBox.Show("Programme introuvable!");
                txtSearchId.Clear();
                txtSearchId.Focus();
            }
        }
        private void ResetProg()
        {
            txtCode.Clear();
            txtDomaine.Text = "";
            txtNom.Text = "";
            txtHeures.Text = "";
            txtCode.Focus();
        }
        private void ResetEtudiant()
        {
            txtECode.Clear();
            txtENom.Clear();
            txtEPrenom.Clear();
            // dtpNaissance.Value = DateTime.Now;
            txtCourriel.Clear();
            cboProgCode.Refresh();

        }

        private void cboProgCode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2) // tabPage2 contains ComboBox
            {
                // Clear and rebind the ComboBox
                cboProgCode.DataSource = null;
                BindComboBox();

            }
        }

        private void btnEAjouter_Click(object sender, EventArgs e)
        {
            //DateTime date = DateTime.Now;
            string date = dtpNaissance.Value.ToShortDateString();
            IsNomEmpty();
            if (cboProgCode.SelectedIndex == -1)
            {
                MessageBox.Show("Aller au Tab Programme et ajouter un programme!");
            }

            //if (listEtud.Count > 0)
            //{
            Etudiant etud = new Etudiant();
            txtECode.Text = GenerateCodeEtudiant();
            txtECode.Enabled = true;
            etud.CodeEtudiant = txtECode.Text;
            etud.NomEtudiant = txtENom.Text;
            etud.PrenomEtudiant = txtEPrenom.Text;
            etud.DateNaissance = date;
            etud.Courriel = txtCourriel.Text;
            etud.CodeProgramme = cboProgCode.SelectedValue.ToString();
            listEtud.Add(etud);
            ResetEtudiant();
            MessageBox.Show(listEtud.Count.ToString() + " " + "Etudiant ajouté avec succès!");

            //}
            //else
            //    MessageBox.Show("Veuillez remplir tout les requis avant d'ajouter un étudiant!");

        }
        private void btnEAffiche_Click(object sender, EventArgs e)
        {
            try
            {
                dgEtudiant.Rows.Clear();
                dgEtudiant.Columns.Clear();

                // Adding columns to the DataGridView
                dgEtudiant.Columns.Add("CodeEtudiant", "Code Etudiant");
                dgEtudiant.Columns.Add("NomEtudiant", "Nom Etudiant");
                dgEtudiant.Columns.Add("PrenomEtudiant", "Prenom Etudiant");
                dgEtudiant.Columns.Add("DateNaissance", "Date Naissance");
                dgEtudiant.Columns.Add("Courriel", "Courriel");
                dgEtudiant.Columns.Add("CodeProgramme", "Code Programme");

                foreach (Etudiant etud in listEtud)
                {
                    dgEtudiant.Rows.Add(etud.CodeEtudiant, etud.NomEtudiant, etud.PrenomEtudiant, etud.DateNaissance, etud.Courriel, etud.CodeProgramme);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Aucun programme à afficher!");
            }
        }
        private void BindComboBox()
        {
            cboProgCode.DataSource = listProg;
            cboProgCode.DisplayMember = "CodeProgramme";
            cboProgCode.ValueMember = "CodeProgramme";
        }
        private void IsNomEmpty()
        {
            if (string.IsNullOrEmpty(txtENom.Text) || string.IsNullOrEmpty(txtEPrenom.Text))
            {
                MessageBox.Show("Veuillez remplir tout les requis avant d'ajouter un etudiant");
                return;
            }
        }
        private string GenerateCodeEtudiant()
        {
            if (txtENom.Text.Length >= 3 && txtEPrenom.Text.Length >= 1)
            {
                string code = txtENom.Text.Substring(0, 3) + txtEPrenom.Text.Substring(0, 1);
                txtECode.Text = code.ToUpper();
                return code.ToUpper();
            }
            return string.Empty;
        }
        private void RefreshComboBox()
        {
            cboProgCode.Items.Clear();
            foreach (Programme prog in listProg)
            {
                cboProgCode.Items.Add(prog.CodeProgramme);
                listProg.Add(prog);
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TxtENom_TextChanged(object sender, EventArgs e)
        {
            GenerateCodeEtudiant();
        }

        private void txtEPrenom_TextChanged(object sender, EventArgs e)
        {
            GenerateCodeEtudiant();
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            ValiderTextBoxLength(txtNom, "Il faut entrer le nom du programme");
        }

        private void txtDomaine_Validating(object sender, CancelEventArgs e)
        {
            ValiderTextBoxLength(txtDomaine, "Domaine doit etre rempli");
        }

        private void txtHeures_Validating(object sender, CancelEventArgs e)
        {
            ValiderNbHeure(txtHeures, "Il faut entrer le nombre d'heures");
        }

        private bool ValiderTextBoxLength(TextBox txtBox, int minLength, string errormsg)
        {
            bool bStatus = true;
            if ((string.IsNullOrEmpty(txtBox.Text) || txtBox.Text.Length < minLength))
            {
                ErrorProvider.SetError(txtBox, errormsg);
                bStatus = false;
            }
            else
            {
                ErrorProvider.SetError(txtBox, "");
            }
            return bStatus;
        }
        private bool ValiderNbHeure(TextBox txtBox, string errormsg)
        {
            bool bStatus = true;
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                ErrorProvider.SetError(txtBox, errormsg);
                bStatus = false;
            }
            else
            {
                ErrorProvider.SetError(txtBox, "");
            }
            return bStatus;
        }
        private bool ValiderTextBoxLength(TextBox txtBox, string errormsg)
        {
            bool bStatus = true;
            if (string.IsNullOrEmpty(txtBox.Text))
            {
                ErrorProvider.SetError(txtBox, errormsg);
                bStatus = false;
            }
            else
            {
                ErrorProvider.SetError(txtBox, "");
                try
                {
                    int temp = int.Parse(txtHeures.Text);
                    ErrorProvider.SetError(txtHeures, "");
                    if (temp <= 0)
                    {
                        ErrorProvider.SetError(txtHeures, "Le nombre heures doit etre positif");
                        bStatus = false;
                    }
                    else
                    {
                        ErrorProvider.SetError(txtHeures, "");
                    }
                }
                catch (FormatException)
                {
                    ErrorProvider.SetError(txtHeures, "Le nombre heures doit etre un nombre");
                }
            }
            return bStatus;
        }

        private void txtENom_Validating(object sender, CancelEventArgs e)
        {
            ValiderTextBoxLength(txtENom, 3, "Le nom doit contenir au moins 3 caractères");
        }

        private void txtEPrenom_Validated(object sender, EventArgs e)
        {
            ValiderTextBoxLength(txtEPrenom, 1, "Le prénom doit contenir au moins 1 caractère");
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            ValiderTextBoxLength(txtCode, "champ requis");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgProgramme.Refresh();
            if (listProg.Count == 0)
            {
                MessageBox.Show("Aucun programme a afficher");
            }
            else
            {
                try
                {
                    // Clear the DataGridView rows
                    dgProgramme.Rows.Clear();

                    // Populate the DataGridView
                    foreach (Programme prog in listProg)
                    {
                        dgProgramme.Rows.Add(prog.CodeProgramme, prog.Domaine, prog.NomProgramme, prog.NbHeures);
                    }
                }
                catch (Exception ex)  // Add 'ex' to catch block to see exception details
                {
                    MessageBox.Show("An error occurred: " + ex.Message);  // Display the actual exception
                }
            }
        }
    }
}
