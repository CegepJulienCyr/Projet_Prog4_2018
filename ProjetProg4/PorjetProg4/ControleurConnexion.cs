using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.Sql;
using System.Text.RegularExpressions;

namespace PorjetProg4
{
    public static class ControleurConnexion
    {
       
        public static string Connection(string users, string password)
        {
            string[] tbldonnes = ConnexionDB.Connection(users, password);
            if (tbldonnes[1] == "1")
            {
                if (tbldonnes[0] == "U")
                    return "U";
                else
                    return "A";
            }
            else
                return "Pseudo ou mot de pass invalide";
        }


          public static bool AjouterUtilisateur(string Users,string password,string type)
          {
            Regex reg = new Regex("[^<>[\\]{\\}|\\/^ ~%# :;,$&%?\0-\\cZ]+");
            if (reg.IsMatch(Users))
            {
                ConnexionDB.CreeUtilisateur(Users, password, type);
                return true;
            }
            else
                return false;
            
          }
    }
}

