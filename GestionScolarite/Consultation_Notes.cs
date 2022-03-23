using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace GestionScolarite
{
    public partial class Consultation_Notes : Form
    {
        public Consultation_Notes()
        {
            InitializeComponent();
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(filiereCb.Text) && !string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(MatiereCb.Text))
            {
                LoadData();

            }
        }

        private void Consultation_Notes_Load(object sender, EventArgs e)
        {
            filiereCb.Items.Clear();
            Filiere filiere = new Filiere();
            List<dynamic> Filieres = filiere.All();
            foreach (Filiere f in Filieres)
            {
                filiereCb.Items.Add(f.code);
            }
            NoteGrid.ColumnCount = 4;
            NoteGrid.Columns[0].Name = "Code";
            NoteGrid.Columns[1].Name = "Nom";
            NoteGrid.Columns[2].Name = "Prenom";
            NoteGrid.Columns[3].Name = "Note";
        }

        private void MatiereCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filiereCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = filiereCb.Text;
            if(choix == "")
            {

            }
            else if (choix == "AP")
            {
                NiveauCb.Items.Clear();
                NiveauCb.Items.Add(1);
                NiveauCb.Items.Add(2);
            }
            else
            {
                NiveauCb.Items.Clear();
                NiveauCb.Items.Add(1);
                NiveauCb.Items.Add(2);
                NiveauCb.Items.Add(3);
            }
            if(!string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(filiereCb.Text))
            {
                LoadMatiere();
            }
            else
            {
                MatiereCb.Items.Clear();
            }
        }

        private void NiveauCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(filiereCb.Text))
            {
                LoadMatiere();
            }
        }
        public void LoadMatiere()
        {
            try
            {
                Dictionary<string, Object> dico = new Dictionary<string, Object>();
                MatiereCb.Items.Clear();
                dico.Add("niveau", NiveauCb.Text);
                dico.Add("code_fil", filiereCb.Text);
                List<dynamic> lmodule = Module.select<Module>(dico);
                List<dynamic> lMatiere = new List<dynamic>();
                if(lmodule.Count != 0)
                {
                    foreach (Module m in lmodule)
                    {
                        dico.Clear();
                        dico.Add("code_module", m.code);
                        lMatiere.AddRange(Matiere.select<Matiere>(dico));
                    }
                    foreach (Matiere mat in lMatiere)
                    {
                        MatiereCb.Items.Add(mat.code);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void LoadData()
        {
            double moyenne = 0;
            NoteGrid.Rows.Clear();
            Dictionary<string, object> dico = new Dictionary<string, Object>();
            dico.Add("code_fil", filiereCb.Text);
            dico.Add("niveau", NiveauCb.Text);
            List<dynamic> le = Eleve.select<Eleve>(dico);
            List<List<string>> l = new List<List<string>>();

            
            foreach (Eleve elv in le)
            {
                dico.Clear();
                dico.Add("code_eleve", elv.code);
                dico.Add("code_mat", MatiereCb.Text);
                List<dynamic> note = Note.select<Note>(dico);
                if(note.Count != 0)
                {
                    List<string> etud = new List<string>();
                    etud.Add(elv.code);
                    etud.Add(elv.nom);
                    etud.Add(elv.prenom);
                    etud.Add(note[0].note.ToString());
                    l.Add(etud);
                }
                
            }
            
            for(int i = 0; i < l.Count; i++) 
            {
                NoteGrid.Rows.Add();
                NoteGrid.Rows[i].Cells[0].Value = l[i][0];
                NoteGrid.Rows[i].Cells[1].Value = l[i][1];
                NoteGrid.Rows[i].Cells[2].Value = l[i][2];
                NoteGrid.Rows[i].Cells[3].Value = l[i][3];
                moyenne += double.Parse(l[i][3], CultureInfo.InvariantCulture.NumberFormat); ;
            }
            if (l.Count != 0)
            {
                moyenne /= l.Count;
                moyenneTxt.Text = moyenne.ToString();
            }
        }
    }
}
