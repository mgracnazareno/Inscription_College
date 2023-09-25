using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Business
{
    internal class User
    {
        private string nomUtilisateur;
        private string motDePasse;

        public User(string nomUtilisateur, string motDePasse)
        {
            this.NomUtilisateur = nomUtilisateur;
            this.MotDePasse = motDePasse;
        }

        public User() { }

        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }


    }
}
