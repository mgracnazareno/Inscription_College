using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal
{
    internal class Programme
    {
        private string _CodeProgramme;
        private string _Domaine;
        private string _NomProgramme;
        private int _NbHeures;

        public Programme() { }
        public Programme(string codeProgramme, string domaine, string nomProgramme, int nbHeures)
        {
            _CodeProgramme = codeProgramme;
            _Domaine = domaine;
            _NomProgramme = nomProgramme;
            _NbHeures = nbHeures;
        }

        public string CodeProgramme
        {
            get { return _CodeProgramme; }
            set { _CodeProgramme = value; }
        }

        public string Domaine { get => _Domaine; set => _Domaine = value; }
        public string NomProgramme { get => _NomProgramme; set => _NomProgramme = value; }
        public int NbHeures { get => _NbHeures; set => _NbHeures = value; }

        public override string ToString()
        {
            return _CodeProgramme + " " + _Domaine + " " + _NomProgramme + " " + _NbHeures;
        }

        public Programme GetProgrammeById(List<Programme> listProg, string codeProgramme)
        {           
            //bool found = false;

            foreach (Programme prog in listProg)
            {
                if (prog.CodeProgramme == codeProgramme)
                {                   
                    return prog;
                }
            }

            return null;
        }
    }
}
