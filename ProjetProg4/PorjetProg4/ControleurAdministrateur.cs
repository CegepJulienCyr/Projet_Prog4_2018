using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PorjetProg4
{
     static class ControleurAdministrateur
     {

        
        
        public static void AjouterSet(string id, string nombrePiece, string year, string piece,string theme,string descr) // A reviser 
        {
            ConnexionDB.AjouterSet(id,year, nombrePiece,theme,descr);
        }

        public static void AjouterPiece(string id, string descr, string catego)
        {
            ConnexionDB.AjouterPiece(id, catego, descr);
        }
        public static void SupprimerPiece(string id)
        {
            ConnexionDB.SupprimerPieces(id);
        }

        public static void SupprimerSet(string id)
        {
            ConnexionDB.SupprimerSets(id);
        }
        public static void AfficherSettemp(TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.RechercherSetTemp();
            foreach(Noeu noeu in list)
            {
                treeview.Nodes[0].Nodes.Add(noeu.Id, noeu.Nom);
            }
        }

        public static void AfficherPiecetemp(TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.RechercherSetTemp();
            foreach (Noeu noeu in list)
            {
                treeview.Nodes[1].Nodes.Add(noeu.Id, noeu.Nom);
            }
        }

        public static bool ModifierSet(string id, string year, string pieces, string theme, string descr)
        {
            try
            {
                ConnexionDB.ModifierSet(id, year, pieces, theme, descr);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ModifierPieces(string id,string descr,string category)
        {
            try
            {
                ConnexionDB.ModifierPiece(id, descr, category);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

