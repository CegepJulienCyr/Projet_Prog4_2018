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
    public partial class FrmCreeation : Form
    {
        public FrmCreeation()
        {
            InitializeComponent();
           
        }

        private void btnSets_Click(object sender, EventArgs e)
        {
            ControleurUtilisateur.AjouterSets(txtIdSets.Text, txtYear.Text,txtPieces.Text, txtTheme.Text, txtdescr.Text);
            MessageBox.Show("Set Ajouter :" + txtdescr.Text);
        }

        private void btnPiece_Click(object sender, EventArgs e)
        {
            ControleurUtilisateur.AjouterPieces(txtIdPiece.Text, txtdescrPiece.Text, txtCatego.Text);
            MessageBox.Show("Pieces Ajouter :" + txtPieces.Text);
        }
    }
}
