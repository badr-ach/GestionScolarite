using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;
namespace GestionScolarite
{
    public partial class Bilan_Annuel : Form
    {
        public Bilan_Annuel()
        {
            InitializeComponent();
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(FiliereCb.Text) && !string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(EtudiantCb.Text))
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void Bilan_Annuel_Load(object sender, EventArgs e)
        {
            Filiere fil = new Filiere();
            List<dynamic> lf = fil.All();

            foreach(Filiere f in lf)
            {
                FiliereCb.Items.Add(f.code);
            }
            BilanGrid.ColumnCount = 4;
            BilanGrid.Columns[0].Name = "Code Matiere";
            BilanGrid.Columns[1].Name = "Designation";
            BilanGrid.Columns[2].Name = "Semestre";
            BilanGrid.Columns[3].Name = "Note";

        }

        private void FiliereCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiliereCb.Text == "")
            {

            }
            else if(FiliereCb.Text == "AP")
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
            LoadEleve();
            
        }
        public void LoadEleve()
        {
            if (!string.IsNullOrWhiteSpace(FiliereCb.Text) && !string.IsNullOrWhiteSpace(NiveauCb.Text))
            {
                Dictionary<string, Object> dico = new Dictionary<string, Object>();
                dico.Add("code_fil", FiliereCb.Text);
                dico.Add("niveau", NiveauCb.Text);
                List<dynamic> le = Eleve.select<Eleve>(dico);
                EtudiantCb.Items.Clear();
                foreach (Eleve e in le)
                {
                    EtudiantCb.Items.Add(e.code);
                }
            }
        }

        private void NiveauCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEleve();
        }
        public void LoadData()
        {
            BilanGrid.Rows.Clear();
            Dictionary<string, Object> dico = new Dictionary<string, Object>();
            dico.Add("code_eleve", EtudiantCb.Text);
            List<dynamic> ln = Note.select<Note>(dico);
            List<List<string>> data = new List<List<string>>();
            if(ln.Count != 0)
            {
                double moyenne = 0;
                foreach(Note note in ln)
                {
                    dico.Clear();
                    dico.Add("code", note.code_mat);
                    List<dynamic> matiere = Matiere.select<Matiere>(dico);
                    dico.Clear();
                    dico.Add("code", matiere[0].code_module);
                    List<dynamic> module = Module.select<Module>(dico);
                    List<string> row = new List<string>();
                    row.Add(matiere[0].code);
                    row.Add(matiere[0].designation);
                    row.Add(module[0].semestre);
                    row.Add(note.note.ToString());
                    data.Add(row);
                    moyenne += note.note;
                }
                for (int i = 0; i < data.Count; i++)
                {
                    BilanGrid.Rows.Add();
                    BilanGrid.Rows[i].Cells[0].Value = data[i][0];
                    BilanGrid.Rows[i].Cells[1].Value = data[i][1];
                    BilanGrid.Rows[i].Cells[2].Value = data[i][2];
                    BilanGrid.Rows[i].Cells[3].Value = data[i][3];
                }
                moyenne /= data.Count;
                MoyenneAnuelleTxt.Text = moyenne.ToString();
            }
           
        }
    }
}
