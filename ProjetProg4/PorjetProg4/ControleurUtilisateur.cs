using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorjetProg4
{
    static class ControleurUtilisateur
    {
        public static void afficherTreeViewPieces(TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.ChercherTabPiece();
            foreach (Noeu noeu in list)
            {
          
                treeview.Nodes[1].Nodes.Add(noeu.Id, noeu.Nom);
            }
        }
         public static void afficherTreeViewSets(TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.ChercherTabSet();
            treeview.Nodes[0].Nodes.Clear();
            foreach (Noeu noeu in list)
            {
                treeview.Nodes[0].Nodes.Add(noeu.Id, noeu.Nom);
            }
        }


        public static void afficherTreeViewSetPieces(TreeView trewview, TreeNode Node)
        {
            List <Noeu> list = ConnexionDB.RechercherSetPieces(Node.Name);
            trewview.Nodes[0].Nodes.Clear();
            foreach(Noeu noeu in list)
            {
                trewview.Nodes[0].Nodes.Add(noeu.Id,noeu.Nom);
            }
        }
        public static void RechercherSets(string recherche,TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.RechercherSet(recherche);
            foreach(Noeu noeu in list)
            {
                treeview.Nodes[0].Nodes.Clear();
                treeview.Nodes[0].Nodes.Add(noeu.Id,noeu.Nom);
            }
        }



        public static void RechercherPieces(string recherche, TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.RechercherPieces(recherche);
            foreach (Noeu noeu in list)
            {
                treeview.Nodes[1].Nodes.Clear();
                treeview.Nodes[1].Nodes.Add(noeu.Id, noeu.Nom);
            }
        }

        public static void AfficherSetPieces(string idSets,TreeView treeview)
        {
            List<Noeu> list = ConnexionDB.RechercherSetPieces(idSets);
            foreach(Noeu noeu in list)
            {
                treeview.Nodes[0].Nodes.Clear();
                treeview.Nodes[0].Nodes.Add(noeu.Id,noeu.Nom);
            }
        }
        public static void AjouterSets(string id, string annee, string nbrpieces, string theme, string descr)
        {
            ConnexionDB.CreeSet(id, annee, nbrpieces, theme, descr);
        }
        public static void AjouterPieces(string id, string descr, string categ)
        {
            ConnexionDB.AjouterPiece(id,categ,descr);
        }
    }
}
