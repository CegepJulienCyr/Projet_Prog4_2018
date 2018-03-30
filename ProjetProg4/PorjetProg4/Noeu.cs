using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorjetProg4
{
    public class Noeu
    {
        private string id;
        private string nom;

        public string Id { get { return id; } }
        public string Nom { get { return nom; } }

        public Noeu(string idN, string nomN)
        {
            id = idN;
            nom = nomN;
        }
    }
}
