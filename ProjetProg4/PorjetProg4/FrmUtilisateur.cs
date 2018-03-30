using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace PorjetProg4
{
    public partial class FrmUtilisateur : Form
    {
        public FrmUtilisateur()
        {
            InitializeComponent();
           

            PictureBox pictureBox = new PictureBox();

            pictureBox.Location = new Point(312, 260);
            pictureBox.Size = new Size(315, 250);
            pictureBox.BorderStyle = new BorderStyle();
            
            pictureBox.Parent = this;
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picSet.SizeMode = PictureBoxSizeMode.StretchImage;
            Sets.Parent = this;
            lblList.Location = new Point(12, 60);
            Sets.Location = new Point(12, 101);
            Sets.Size = new Size(200, this.Height);
            Sets.Anchor = AnchorStyles.Top | AnchorStyles.Left |
                AnchorStyles.Bottom | AnchorStyles.Right;
            Inventaire.Nodes.Add("Set");
            Inventaire.Nodes.Add("Pieces");
            
            Sets.Nodes.Add("Sets");
            Sets.Nodes.Add("Pieces");
            PiecesSet.Nodes.Add("Pieces");     
            Sets.NodeMouseClick += new TreeNodeMouseClickEventHandler(Node_MouseClick);
            PiecesSet.NodeMouseClick += Node_MouseClick;
            Inventaire.NodeMouseClick += Node_MouseClick;
            Sets.ItemDrag += Sets_ItemDrag;
            Inventaire.DragEnter += Inventaire_DragEnter;
            Inventaire.DragDrop += Inventaire_DragDrop;
            ControleurUtilisateur.afficherTreeViewSets(Sets);
            ControleurUtilisateur.afficherTreeViewPieces(Sets);
            Sets.Show();
            pictureBox.Show();

            // Sets->node vers Inventaire
            


        }

        private void Inventaire_DragDrop(object sender, DragEventArgs e)
        {
            // code bouger la node d'un treeview a l'autre 

            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if(draggedNode.Parent.Text == "Sets")
            {
                Inventaire.Nodes[0].Nodes.Add((TreeNode)draggedNode.Clone());
            }
            else if(draggedNode.Parent.Text == "Pieces")
            {
                Inventaire.Nodes[1].Nodes.Add(draggedNode.Name, draggedNode.Text);
            }
            
            
        }

        private void Inventaire_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void Sets_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Commencement du doDragdrop
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }




        private void Node_MouseClick(object sender, EventArgs e) // To Do Associer a la Forme FrmUtilisateur
        {
            try
            {
                if (Sets.SelectedNode.Parent.Text == "Sets")
                {
                    ControleurUtilisateur.afficherTreeViewSetPieces(PiecesSet, Sets.SelectedNode);
                    if (File.Exists(Directory.GetCurrentDirectory() + @"\image\Lego_Sets\images\" + Sets.SelectedNode.Name + ".jpg"))
                    {
                        picSet.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\image\Lego_Sets\images\" + Sets.SelectedNode.Name + ".jpg");
                    }
                }
                else
                {
                    if (Sets.SelectedNode.Parent.Text == "Pieces")
                    {
                        if(File.Exists(Directory.GetCurrentDirectory() + @"\image\piece\" + Sets.SelectedNode.Name + ".png"))
                        {
                            picImage.Image = Image.FromFile(Directory.GetCurrentDirectory()  + @"\image\piece\" + Sets.SelectedNode.Name + ".png");
                        }
                        else
                        {
                            picImage.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\image\piece\NoImage.jpg");
                        }            
                    }
                }
            }
            catch (Exception)
            {
               
                Console.WriteLine("erreur");
            }
        }
        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            
        }

        private void Sets_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Sets":
                    ControleurUtilisateur.afficherTreeViewSets(Sets);
                    break;
                case "Pieces" :
                    ControleurUtilisateur.afficherTreeViewPieces(Sets);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string recherhe = txtRechercher.Text;
            ControleurUtilisateur.RechercherSets(recherhe, Sets);
            ControleurUtilisateur.RechercherPieces(recherhe, Sets);
        }

        private void btnCree_Click(object sender, EventArgs e)
        {
            FrmCreeation frmCreeation = new FrmCreeation();
           
            frmCreeation.Show();
            
        }
    }
}
