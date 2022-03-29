using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using Models;

namespace GestionScolarite
{
   
    public partial class Gestion_Etudiants : Form
    {
        public static string CodeEleve = "";
        public Gestion_Etudiants()
        {
            InitializeComponent();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CodeCB.Checked == true)
            {
                NomCB.Checked = false;
                PrenomCB.Checked = false;
                NiveauCB.Checked = false;
                FiliereCB.Checked = false;
            }
        }


        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {
            //Loading filieres 
            Code_fil.Items.Clear();
            Filiere filiere = new Filiere();
            List<dynamic> Filieres = filiere.All();
            foreach (Filiere f in Filieres)
            {
                Code_fil.Items.Add(f.code);
            }
            //End of loading filieres


            //Loading table
            LoadData();
            //end of loading table
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(Code.Text))
                {
                    Dictionary<string, object> dico = new Dictionary<string, Object>();
                    dico.Add("code", Code.Text);
                    List<dynamic> le = Eleve.select<Eleve>(dico);
                    if(le.Count == 0)
                    {
                        MessageBox.Show("code eleve invalide");
                    }
                    else
                    {
                        CodeEleve = Code.Text;
                        new Gestion_Notes().ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Veuillez saisir le code de l'étudiant !");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Code.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Nom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Prenom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Code_fil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Niveau.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            Code.Text = "";
            Nom.Text = "";
            Prenom.Text = "";
            Code_fil.SelectedIndex = -1;
            Niveau.SelectedItem = -1;
            Niveau.Text = "";
            CodeCB.Checked = false;
            NomCB.Checked = false;
            PrenomCB.Checked = false;
            FiliereCB.Checked = false;
            NiveauCB.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RechercherCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            Eleve etd = new Eleve();
            try
            {
                if ( isChampsNotNull() )
                {
                    Dictionary<string, object> dico = new Dictionary<string, object>();
                    dico.Add("code_fil", Code.Text);
                    List<dynamic> codeExist = etd.Select(dico);
                    if (codeExist.Count == 0)
                    {
                        etd.nom = Nom.Text;
                        etd.prenom = Prenom.Text;
                        etd.code = Code.Text;
                        etd.code_fil = Code_fil.SelectedItem.ToString();
                        etd.niveau = Niveau.SelectedItem.ToString();
                        etd.Save();
                        MessageBox.Show("Eudiant : " + etd.code + " inséré avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Un étudiant avec ce code existe déjà!");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tout les champs!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            LoadData();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            Eleve etd = new Eleve();
            try { 
                if( isChampsNotNull())
                {
                    Dictionary<string, object> dico = new Dictionary<string, object>();
                    dico.Add("code", Code.Text);
                    List<dynamic> etudiant = etd.Select(dico);
                    if (etudiant.Count != 0)
                    {
                        etd = etudiant[0];
                        etd.nom = Nom.Text;
                        etd.prenom = Prenom.Text;
                        etd.code = Code.Text;
                        etd.code_fil = Code_fil.SelectedItem.ToString();
                        etd.niveau = Niveau.SelectedItem.ToString();
                        etd.Save();
                        MessageBox.Show("Eudiant : " + etd.code + " modifié avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Cette étudiant n'existe pas");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tout les champs!");
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Error : " + ex.Message); 
            }
            LoadData();
        }

        private void FiliereCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = Code_fil.Text;
            Niveau.Items.Clear();
            switch (choice)
            {
                case "":
                    break;
                case "AP":
                    Niveau.Items.Add(1);
                    Niveau.Items.Add(2);
                    break;
                default:
                    Niveau.Items.Add(1);
                    Niveau.Items.Add(2);
                    Niveau.Items.Add(3);
                    break;
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            Eleve etd = new Eleve();
            try
            {
                if (!String.IsNullOrWhiteSpace(Code.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Confirmer la suppresion de l'étudiant", "Suppression", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        Dictionary<string, object> dico = new Dictionary<string, object>();
                        dico.Add("code", Code.Text);
                        List<dynamic> etudiant = etd.Select(dico);
                        if (etudiant.Count != 0)
                        {
                            etd = etudiant[0];
                            etd.Delete();
                            MessageBox.Show("Etudiant supprimé avec succès");

                        }
                        else
                        {
                            MessageBox.Show("Etudiant n'existe pas");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuiller saisir le code de l'étudiant à supprimer!!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            LoadData();

        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            Eleve etd = new Eleve();
            try
            {
                Dictionary<string,Control> criteria = GetChecked();
                if(criteria.Count > 0) {
                    List<Control> list = new List<Control>(criteria.Values);
                    if (isChampsNotNull(list)) {
                        Dictionary<string, object> dico = new Dictionary<string, object>();
                        foreach(Control c in list)
                        {
                            dico.Add(c.Name, c.Text);
                        }
                        List<dynamic> res = etd.Select(dico);
                        dataGridView1.Rows.Clear();
                        for (int i = 0; i < res.Count; i++)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = res[i].code;
                            dataGridView1.Rows[i].Cells[1].Value = res[i].nom;
                            dataGridView1.Rows[i].Cells[2].Value = res[i].prenom;
                            dataGridView1.Rows[i].Cells[4].Value = res[i].niveau;
                            dataGridView1.Rows[i].Cells[3].Value = res[i].code_fil;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Remplissez toutes les cases des critères de selection choisis!");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun critère de recherche n'est selectionné!!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        // Utils

        private Dictionary<string,Control> GetChecked()
        {
            Dictionary<string,Control> checkedBoxes = new Dictionary<string,Control>();
            if (CodeCB.Checked == true) checkedBoxes.Add(CodeCB.Name,Code);
            return checkedBoxes;

            if (NomCB.Checked == true) checkedBoxes.Add(NomCB.Name,Nom);
            if (PrenomCB.Checked == true) checkedBoxes.Add(PrenomCB.Name,Prenom);
            if (NiveauCB.Checked == true) checkedBoxes.Add(NiveauCB.Name,Niveau);
            if (FiliereCB.Checked == true) checkedBoxes.Add(FiliereCB.Name,Code_fil);
            return checkedBoxes;
        }

        private Boolean isChampsNotNull(List<Control> controls) {
            foreach(Control c in controls)
            {
                if (String.IsNullOrWhiteSpace(c.Text) == true)
                    return false;
            }
            return true;
        }

        private Boolean isChampsNotNull()
        {
            return !String.IsNullOrWhiteSpace(Nom.Text) && !String.IsNullOrWhiteSpace(Prenom.Text) && !String.IsNullOrWhiteSpace(Code.Text)
                    && !String.IsNullOrWhiteSpace(Code_fil.Text) && !String.IsNullOrWhiteSpace(Niveau.Text);
        }

        private void LoadData()
        {
            List<dynamic> LE = new Eleve().All();

            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // set column names from model types 
            dataGridView1.Columns[0].Name = "Code";
            dataGridView1.Columns[1].Name = "Nom";
            dataGridView1.Columns[2].Name = "Prenom";
            dataGridView1.Columns[4].Name = "Niveau";
            dataGridView1.Columns[3].Name = "Filiere";
            // populate rows with rows from BD.
            dataGridView1.Rows.Clear();
            for (int i = 0; i < LE.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = LE[i].code;
                dataGridView1.Rows[i].Cells[1].Value = LE[i].nom;
                dataGridView1.Rows[i].Cells[2].Value = LE[i].prenom;
                dataGridView1.Rows[i].Cells[4].Value = LE[i].niveau;
                dataGridView1.Rows[i].Cells[3].Value = LE[i].code_fil;
            }

        }
    }
}
