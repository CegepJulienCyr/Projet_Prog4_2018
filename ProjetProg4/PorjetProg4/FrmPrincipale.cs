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
    public partial class FrmPrincipale : Form
    {
        public FrmAdministrateur frmAdmin = new FrmAdministrateur();

        public FrmUtilisateur frmUtilisateur = new FrmUtilisateur();

        Label luser = new Label();
        Label lpassword = new Label();
        TextBox users = new TextBox();
        TextBox password = new TextBox();
        TreeView TVClient = new TreeView();


        Button btnAdministeur = new Button();
        Button btnUtilisateur = new Button();


        public FrmPrincipale()
        {
            InitializeComponent();
            
            luser.Parent = this;
            lpassword.Parent = this;
            users.Parent = this;
            password.Parent = this;
            password.UseSystemPasswordChar = true;
            users.Location = new Point(3, 50);
            password.Location = new Point(3, 110);
            //frmUtilisateur.Parent = this;
            //frmAdmin.Parent = this;
            this.FormClosed += new FormClosedEventHandler(FrmUtilisateur_FormClosed);
            luser.Text = "Users";
            lpassword.Text = "Password";
            listeLego.Nodes.Add("Sets");
            listeLego.Nodes.Add("Pieces");
            ControleurUtilisateur.afficherTreeViewPieces(listeLego);
            ControleurUtilisateur.afficherTreeViewSets(listeLego);
            luser.Location = new Point(3, 25);
            lpassword.Location = new Point(3, 80);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(800, 500);
            luser.Show();
            lpassword.Show();
            users.Show();
            password.Show();

            this.Show();
        }

        private void FrmPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            string typeuser =
            ControleurConnexion.Connection(users.Text, password.Text);

            if (typeuser == "U")
            {
                frmUtilisateur.Activate();
                frmUtilisateur.Show();
            }
            else if (typeuser == "A")
            {
                frmAdmin.Activate();
                frmAdmin.Show();
            }
            else
            {
                MessageBox.Show(typeuser);
            }

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool Verif;
            if (!radAdmin.Checked)
            {
                Verif = ControleurConnexion.AjouterUtilisateur(users.Text, password.Text, "U");
            }
            else
            {
                Verif = ControleurConnexion.AjouterUtilisateur(users.Text, password.Text, "A");
            }

            if (!Verif)
                MessageBox.Show("Le Champ d'utilisateur ne dois pas contenir de caractere special");
            else
            {
                MessageBox.Show("Utilisateur à été Crée : " + users.Text);
                radAdmin.Checked = false;
                users.Clear();
                password.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmUtilisateur.Activate();
            frmUtilisateur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin.Activate();
            frmAdmin.ShowDialog();
        }

        private void FrmUtilisateur_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUtilisateur = new FrmUtilisateur();
        }
    }
}
