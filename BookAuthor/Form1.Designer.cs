namespace BookAuthor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomAuteur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenomAuteur = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.auteurlist = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Auteur";
            // 
            // txtNomAuteur
            // 
            this.txtNomAuteur.Location = new System.Drawing.Point(94, 66);
            this.txtNomAuteur.Name = "txtNomAuteur";
            this.txtNomAuteur.Size = new System.Drawing.Size(100, 20);
            this.txtNomAuteur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom Auteur";
            // 
            // txtPrenomAuteur
            // 
            this.txtPrenomAuteur.Location = new System.Drawing.Point(94, 115);
            this.txtPrenomAuteur.Name = "txtPrenomAuteur";
            this.txtPrenomAuteur.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomAuteur.TabIndex = 3;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(96, 167);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(87, 30);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Auteur";
            // 
            // auteurlist
            // 
            this.auteurlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.nom,
            this.prenom});
            this.auteurlist.Location = new System.Drawing.Point(250, 64);
            this.auteurlist.Name = "auteurlist";
            this.auteurlist.Size = new System.Drawing.Size(451, 161);
            this.auteurlist.TabIndex = 6;
            this.auteurlist.UseCompatibleStateImageBehavior = false;
            this.auteurlist.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 136;
            // 
            // prenom
            // 
            this.prenom.Text = "Prenom";
            this.prenom.Width = 179;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refrech";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(94, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Aller au livre";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 287);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.auteurlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtPrenomAuteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomAuteur);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomAuteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenomAuteur;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView auteurlist;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

