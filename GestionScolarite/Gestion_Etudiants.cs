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
        public Gestion_Etudiants()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {
            /*dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;*//*dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;*/
            // set column names from model types 
            /*dataGridView1.Columns[0].Name = "Recipe";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Main Ingredients";
            dataGridView1.Columns[3].Name = "Rating";*/
            // populate rows with rows from BD.
            /*DataEtudiants.Rows.Clear();
            List<Etudiant> LE = edao.Select();
            for (int i = 0; i < LE.Count; i++)
            {
                DataEtudiants.Rows.Add();
                DataEtudiants.Rows[i].Cells[0].Value = LE[i].Code + "";
                DataEtudiants.Rows[i].Cells[1].Value = LE[i].Nom;
                DataEtudiants.Rows[i].Cells[2].Value = LE[i].Prenom;
                DataEtudiants.Rows[i].Cells[3].Value = LE[i].Groupe + "";

            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NouveauBtn_Click(object sender, EventArgs e)
        {
            CodeTxt.Text = "";
            NomTxt.Text = "";
            PrenomTxt.Text = "";
            FiliereCBB.SelectedIndex = -1;
            NiveauCBB.Items.Clear();
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
                if ( !String.IsNullOrWhiteSpace(NomTxt.Text) && !String.IsNullOrWhiteSpace(PrenomTxt.Text) && !String.IsNullOrWhiteSpace(CodeTxt.Text)
                    && !String.IsNullOrWhiteSpace(FiliereCBB.Text) && !String.IsNullOrWhiteSpace(NiveauCBB.Text))
                {
                    etd.nom = NomTxt.Text;
                    etd.prenom = PrenomTxt.Text;
                    etd.code = CodeTxt.Text;
                    etd.code_fil = FiliereCBB.SelectedItem.ToString();
                    etd.niveau = NiveauCBB.SelectedItem.ToString();
/*                    etd.Save();*/
                    MessageBox.Show("Inserted :" + etd.Save());
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
