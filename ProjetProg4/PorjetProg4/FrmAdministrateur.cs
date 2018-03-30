using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorjetProg4
{
    public partial class FrmAdministrateur : Form
    {
        public FrmAdministrateur()
        {
            InitializeComponent();
            treeSetPieces.Nodes.Add("Sets");
            treeSetPieces.Nodes.Add("Pieces");
            treeList.Nodes.Add("Sets");
            treeList.Nodes.Add("Pieces");
            ControleurAdministrateur.AfficherPiecetemp(treeSetPieces);
            ControleurAdministrateur.AfficherSettemp(treeSetPieces);
            ControleurUtilisateur.afficherTreeViewPieces(treeList);
            ControleurUtilisateur.afficherTreeViewSets(treeList);
            
        }

        private void button3_Click(object sender, EventArgs e) // Confirmer
        {
            if(treeSetPieces.SelectedNode.Parent.Text == "Sets")
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e) //Modifier
        {
            if (radioButton2.Checked)
            {
                ControleurAdministrateur.ModifierSet(txtIdSets.Text, txtYear.Text, txtPieces.Text, txtTheme.Text, txtdescr.Text);
            }
            else if (radioButton1.Checked)
            {
                ControleurAdministrateur.ModifierPieces(txtIdPiece.Text, txtdescrPiece.Text, txtCatego.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Supprimer
        {
            if(treeSetPieces.SelectedNode.Parent.Text == "Sets")
            {
                ControleurAdministrateur.SupprimerSet(treeList.SelectedNode.Name);
                MessageBox.Show("Sets Supprimer :" + treeList.SelectedNode.Text);
            }
            else
            {
                ControleurAdministrateur.SupprimerPiece(treeList.SelectedNode.Name);
                MessageBox.Show("Pieces Supprimer :" + treeList.SelectedNode.Text);
            }
        }
    }
}
