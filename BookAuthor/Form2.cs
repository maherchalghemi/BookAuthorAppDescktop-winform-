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
    public partial class Form2 : Form
    {
        LivreRepository lr = new LivreRepository();
        AuteurRepository ar = new AuteurRepository();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomLivre.Text == "")
            {
                MessageBox.Show("Remplir le nom !!");
            }
            

            else
            {

                Livre livre = new Livre();


              
                livre.NomLivre = txtNomLivre.Text;
                livre.date = date.Value;

                livre.Auteur_Id = Convert.ToInt32(comboBox1.SelectedValue); 
                lr.Add(livre);
                MessageBox.Show("Le livre" + " " +txtNomLivre.Text +" " + "est ajouté :)");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Livre> lstL = lr.GetAll().ToList();
            List<Auteur> lstA = ar.GetAll().ToList();
            var liste = from livre in lstL join auteur in lstA on livre.Auteur_Id equals auteur.AuteurId select new { auteur.NomAuteur, auteur.prenomAuteur, livre.NomLivre, livre.date };
            livrelist.Items.Clear();

            foreach (var item in liste)
            {
                ListViewItem la = new ListViewItem(item.NomAuteur.ToString());
                la.SubItems.Add(item.prenomAuteur.ToString());
                la.SubItems.Add(item.NomLivre.ToString());
                la.SubItems.Add(item.date.ToString());
                livrelist.Items.Add(la);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Auteur> lst = ar.GetAll().ToList();

            
            comboBox1.DataSource = lst;
            
            comboBox1.DisplayMember = "prenomAuteur";
          
           comboBox1.ValueMember = "AuteurId";
            /*foreach (var item in lst)
           {
               comboBox1.Items.Add(item.prenomAuteur+" "+item.NomAuteur);

                
           }*/
            


           

        }
    }
}
