namespace PorjetProg4
{
    partial class FrmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.Label();
            this.Sets = new System.Windows.Forms.TreeView();
            this.PiecesSet = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventaire = new System.Windows.Forms.TreeView();
            this.btnCree = new System.Windows.Forms.Button();
            this.lblImageSet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.picSet = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(809, 416);
            this.txtRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(156, 22);
            this.txtRechercher.TabIndex = 1;
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Location = new System.Drawing.Point(485, 270);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(110, 20);
            this.image.TabIndex = 2;
            this.image.Text = "Image Pieces";
            // 
            // Sets
            // 
            this.Sets.Location = new System.Drawing.Point(12, 101);
            this.Sets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sets.MaximumSize = new System.Drawing.Size(225, 384);
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(225, 384);
            this.Sets.TabIndex = 3;
            this.Sets.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Sets_AfterSelect);
            // 
            // PiecesSet
            // 
            this.PiecesSet.Location = new System.Drawing.Point(253, 101);
            this.PiecesSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PiecesSet.Name = "PiecesSet";
            this.PiecesSet.Size = new System.Drawing.Size(177, 389);
            this.PiecesSet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pieces du Set";
            // 
            // Inventaire
            // 
            this.Inventaire.AllowDrop = true;
            this.Inventaire.Location = new System.Drawing.Point(627, 68);
            this.Inventaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Inventaire.Name = "Inventaire";
            this.Inventaire.Size = new System.Drawing.Size(163, 422);
            this.Inventaire.TabIndex = 7;
            // 
            // btnCree
            // 
            this.btnCree.Location = new System.Drawing.Point(811, 372);
            this.btnCree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCree.Name = "btnCree";
            this.btnCree.Size = new System.Drawing.Size(155, 39);
            this.btnCree.TabIndex = 8;
            this.btnCree.Text = "Création";
            this.btnCree.UseVisualStyleBackColor = true;
            this.btnCree.Click += new System.EventHandler(this.btnCree_Click);
            // 
            // lblImageSet
            // 
            this.lblImageSet.AutoSize = true;
            this.lblImageSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSet.Location = new System.Drawing.Point(485, 54);
            this.lblImageSet.Name = "lblImageSet";
            this.lblImageSet.Size = new System.Drawing.Size(84, 20);
            this.lblImageSet.TabIndex = 10;
            this.lblImageSet.Text = "Image Set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inventaire";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(12, 68);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(48, 24);
            this.lblList.TabIndex = 13;
            this.lblList.Text = "Liste";
            // 
            // picSet
            // 
            this.picSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSet.Location = new System.Drawing.Point(447, 78);
            this.picSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSet.Name = "picSet";
            this.picSet.Size = new System.Drawing.Size(174, 142);
            this.picSet.TabIndex = 12;
            this.picSet.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(445, 292);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(175, 142);
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 505);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.picSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImageSet);
            this.Controls.Add(this.btnCree);
            this.Controls.Add(this.Inventaire);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PiecesSet);
            this.Controls.Add(this.Sets);
            this.Controls.Add(this.image);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUtilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.TreeView Sets;
        private System.Windows.Forms.TreeView PiecesSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TreeView Inventaire;
        private System.Windows.Forms.Button btnCree;
        private System.Windows.Forms.Label lblImageSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSet;
        private System.Windows.Forms.Label lblList;
    }
}