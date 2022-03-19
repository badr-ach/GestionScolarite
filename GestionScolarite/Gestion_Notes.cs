using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Models;

namespace GestionScolarite
{
    public partial class Gestion_Notes : Form
    {
        public Gestion_Notes()
        {
            InitializeComponent();
            
        }
        public List<dynamic> getNote()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_eleve", CodeEleveTxt.Text);
            dico.Add("code_mat", MatiereCb.Text);
            List<dynamic> ln = Note.select<Note>(dico);
            return ln;
        }
        private void Gestion_Notes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            MatiereCb.Text= "";
            NoteTxt.Text = "";
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(MatiereCb.SelectedItem.ToString()) && !string.IsNullOrWhiteSpace(NoteTxt.Text)){

                List<dynamic> ln = getNote();
                if(ln.Count == 0)
                {
                    Note note = new Note(CodeEleveTxt.Text, MatiereCb.Text, float.Parse(NoteTxt.Text));
                    note.Save();
                    MessageBox.Show("Note Ajoutee");
                }
                else
                {
                    MessageBox.Show("Une note est deja inseree pour ce module");
                }
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MatiereCb.SelectedItem.ToString()) && !string.IsNullOrWhiteSpace(NoteTxt.Text))
            {
                Note note;
       
                List<dynamic> ln = getNote();
                if(ln.Count == 0)
                {
                    note = new Note(CodeEleveTxt.Text, MatiereCb.Text, float.Parse(NoteTxt.Text));
                    note.Save();
                }
                else
                {
                    note = ln[0];
                    note.note = float.Parse(NoteTxt.Text);
                    note.Save();
                }
                MessageBox.Show("Note Modifiee");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(CodeEleveTxt.Text) && !string.IsNullOrWhiteSpace(MatiereCb.Text))
            {
                Note note;
                List<dynamic> ln = getNote();
                DialogResult dialogResult = MessageBox.Show("confirmer la suppresion de la note", "Suppression", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    if (ln.Count != 0)
                    {
                        note = ln[0];
                        note.Delete();
                    }
                    MessageBox.Show("Note supprimee");
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir les champs : Code Eleve et Code Matiere");
            }
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(CodeEleveTxt.Text) && !string.IsNullOrWhiteSpace(MatiereCb.Text))
            {
                List<dynamic> ln = getNote();
                if(ln.Count == 0)
                {
                    MessageBox.Show("cette matiere n'a pas une note");
                }
                else
                {
                    NoteTxt.Text = ln[0].note;
                    MessageBox.Show("Code Eleve : "+ CodeEleveTxt + "\nmodule : " + MatiereCb.Text + "\nNote : " + ln[0].note);
                }
            }
        }
    }
}
