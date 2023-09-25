using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFinal.Properties;

namespace ProjectFinal
{
    internal class Etudiant
    { 
        private string _CodeEtudiant;
        private string _NomEtudiant;
        private string _PrenomEtudiant;
        private string _DateNaissance;
        private string _Courriel;
       // private List<Programme> programmes;
       private string _CodeProgramme;

        public Etudiant(string codeEtudiant, string nomEtudiant, string prenomEtudiant, string dateNaissance, string courriel, string codeP)
        {
            _CodeEtudiant = codeEtudiant;
            _NomEtudiant = nomEtudiant;
            _PrenomEtudiant = prenomEtudiant;
            _DateNaissance = dateNaissance;
            _Courriel = courriel;
            _CodeProgramme = codeP;
        }
        public Etudiant() { }
        public string CodeEtudiant { get => _CodeEtudiant; set => _CodeEtudiant = value; }
        public string NomEtudiant { get => _NomEtudiant; set => _NomEtudiant = value; }
        public string PrenomEtudiant { get => _PrenomEtudiant; set => _PrenomEtudiant = value; }
        public string DateNaissance { get => _DateNaissance; set => _DateNaissance = value; }
        public string Courriel { get => _Courriel; set => _Courriel = value; }
        public string CodeProgramme { get => _CodeProgramme; set => _CodeProgramme = value; }

        public override string ToString()
        {
            return _CodeEtudiant + " " + _NomEtudiant + " " + _PrenomEtudiant + " " + _DateNaissance + " " + _Courriel;
        }
        public Etudiant GetEtudiantById(List<Etudiant> listEtud, string codeEtudiant)
        {          
            foreach (Etudiant etud in listEtud)
            {
                if (etud.CodeEtudiant.Trim() == codeEtudiant.Trim())
                {
                    return etud;
                }
            }        
            return null;
        }       
    }
}
