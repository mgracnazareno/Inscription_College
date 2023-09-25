using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinal.Business;

namespace ProjectFinal
{
    public partial class FormLogin : Form
    {
        static List<User> users = new List<User>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            string username = TxtNomUtilisateur.Text;
            string motDePasse = TxtMotPass.Text;

            User user1 = new User("admin", "admin");
            User user2 = new User("user1", "user1");
            User user3 = new User("agent", "agent");
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            if (TxtNomUtilisateur.Text == "" && TxtMotPass.Text == "")
            {
                BtnConnexion.Enabled = false;
                MessageBox.Show("Veuillez remplir tous les champs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnConnexion.Enabled =true;
            }
            else
            {
               
                ValiderCredentials(username, motDePasse);
                BtnConnexion.Enabled = true;


            }
            TxtNomUtilisateur.Clear();
            TxtMotPass.Clear() ;
            TxtNomUtilisateur.Focus();


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponse =
          MessageBox.Show("Voulez vous vraiment quitter ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
                Application.Exit();
        }
        private static void ValiderCredentials(string username, string motPass)
        {
            FormInscription formInscription = new FormInscription();
            FormLogin formLogin = new FormLogin();
            foreach (User user in users)
            {
                if (user.NomUtilisateur == username && user.MotDePasse == motPass)
                {
                    formLogin.Close();
                    MessageBox.Show("Bienvenu " + username, "Confirmation");
                    formInscription.ShowDialog();
                    return;
                }
               
            }
            MessageBox.Show("Nom d'utilisateur ou mot de passe sont incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
