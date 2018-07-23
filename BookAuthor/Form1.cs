using DAL.Context;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookAuthor
{
    public partial class Form1 : Form

    {

        AuteurRepository ar = new AuteurRepository();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private  void btnAjout_Click(object sender, EventArgs e)
        { 
            if (txtNomAuteur.Text=="")
        {
            MessageBox.Show("Remplir le nom !!");
        }
            else if (txtPrenomAuteur.Text == "")
            {
                MessageBox.Show("Remplir le prenom !!");
            }

            else
            {

                Auteur auteur = new Auteur();


                auteur.NomAuteur = txtNomAuteur.Text;
                auteur.prenomAuteur = txtPrenomAuteur.Text;
                ar.Add(auteur);
                MessageBox.Show(txtNomAuteur.Text + " " + txtPrenomAuteur.Text+" "+"est ajouté");

            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Auteur> lst = ar.GetAll().ToList();
            auteurlist.Items.Clear();

            foreach (var item in lst)
            {
                ListViewItem la = new ListViewItem(item.AuteurId.ToString());
                la.SubItems.Add(item.NomAuteur.ToString());
                la.SubItems.Add(item.prenomAuteur.ToString());
                auteurlist.Items.Add(la);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form2().Show();
            
        }
    }
}
