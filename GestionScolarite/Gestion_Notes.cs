using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            CodeEleveTxt.Text = Gestion_Etudiants.CodeEleve;
            Dictionary<string, object> dico = new Dictionary<string, Object>();
            dico.Add("code", CodeEleveTxt.Text);
            Eleve elv = Eleve.select<Eleve>(dico)[0];
            dico.Clear();
            dico.Add("code_fil", elv.code_fil);
            dico.Add("niveau", elv.niveau);
            List<dynamic> lm = Module.select<Module>(dico);
            List<string> lCodeModule = new List<string>();
            foreach(Module m in lm)
            {
                lCodeModule.Add(m.code);
            }
            List<dynamic> lMat = new List<dynamic>();
            foreach(string module in lCodeModule)   
            {
                dico.Clear();
                dico.Add("code_module", module);
                List<dynamic> listMatiere = Matiere.select<Matiere>(dico);
                lMat.AddRange(listMatiere);
             }
            foreach(Matiere m in lMat)
            {
                MatiereCb.Items.Add(m.code);
            }
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
            if(!string.IsNullOrWhiteSpace(MatiereCb.Text) && !string.IsNullOrWhiteSpace(NoteTxt.Text)){
                decimal convertedNote = decimal.Parse(NoteTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
                List<dynamic> ln = getNote();
                if (convertedNote < 0 || convertedNote > 20)
                {
                    MessageBox.Show("veuillez saisir une note entre 0 et 20");
                }
                else if (ln.Count == 0)
                {
                    Note note = new Note(CodeEleveTxt.Text, MatiereCb.Text, convertedNote);
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
            if (!string.IsNullOrWhiteSpace(MatiereCb.Text) && !string.IsNullOrWhiteSpace(NoteTxt.Text))
            {
                Note note;
                List<dynamic> ln = getNote();
                decimal convertedNote =     decimal.Parse(NoteTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (convertedNote < 0 || convertedNote > 20)
                {
                    MessageBox.Show("veuillez saisir une note entre 0 et 20");
                }
                else if (ln.Count == 0)
                {                 
                     note = new Note(CodeEleveTxt.Text, MatiereCb.Text, convertedNote);
                     note.Save(); 
                    MessageBox.Show("Note Modifiee");
                }
                else 
                {
                    note = ln[0];
                    MessageBox.Show(note.id + note.code_eleve + note.note.ToString());
                    note.note = convertedNote;
                    note.Save();
                    MessageBox.Show("Note Modifiee");
                }
                
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
                    NoteTxt.Text = ln[0].note.ToString();
                    MessageBox.Show("Code Eleve : "+ CodeEleveTxt.Text + "\nmodule : " + MatiereCb.Text + "\nNote : " + ln[0].note);
                }
            }
        }
    }
}
