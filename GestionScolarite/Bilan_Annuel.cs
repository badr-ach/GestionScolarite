using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Models;

namespace GestionScolarite
{
    public partial class Bilan_Annuel : Form
    {
        public bool DataLoaded = false;
        public Bilan_Annuel()
        {
            InitializeComponent();
        }

        private void RechercherBtn_Click(object sender, EventArgs e)
        {
            DataLoaded = LoadData();
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
            if(!string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(FiliereCb.Text))
            {
                LoadEleve();
            }
            else
            {
                EtudiantCb.Items.Clear();
            }
            
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
        public bool LoadData()
        {
            if (!string.IsNullOrWhiteSpace(FiliereCb.Text) && !string.IsNullOrWhiteSpace(NiveauCb.Text) && !string.IsNullOrWhiteSpace(EtudiantCb.Text))
            {
                MoyenneAnuelleTxt.Text = "";
                BilanGrid.Rows.Clear();
                Dictionary<string, Object> dico = new Dictionary<string, Object>();
                dico.Add("code_eleve", EtudiantCb.Text);
                List<dynamic> ln = Note.select<Note>(dico);
                List<List<string>> data = new List<List<string>>();
                if (ln.Count != 0)
                {
                    foreach (Note note in ln)
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
                    }
                    for (int i = 0; i < data.Count; i++)
                    {
                        BilanGrid.Rows.Add();
                        BilanGrid.Rows[i].Cells[0].Value = data[i][0];
                        BilanGrid.Rows[i].Cells[1].Value = data[i][1];
                        BilanGrid.Rows[i].Cells[2].Value = data[i][2];
                        BilanGrid.Rows[i].Cells[3].Value = data[i][3];
                    }
                    Dictionary<string, Object> dictio = new Dictionary<string, object>();
                    dictio.Add("code_eleve", EtudiantCb.Text);
                    dictio.Add("code_fil", FiliereCb.Text);
                    dictio.Add("niveau", NiveauCb.Text);
                    List<dynamic> moy = Moyenne.select<Moyenne>(dictio);
                    if(moy.Count != 0)
                    {
                        MoyenneAnuelleTxt.Text = moy[0].moyenne.ToString();
                    }
                    return true;
                }
                return false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return false;
            }
        }

        private void BilanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            if (BilanGrid.Rows.Count > 1)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = FiliereCb.Text+"_"+NiveauCb.Text+".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = BilanGrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[BilanGrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += BilanGrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < BilanGrid.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += BilanGrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void MoyenneAnuelleTxt_TextChanged(object sender, EventArgs e)
        {

        }



        /*private void ExcelBtn_Click(object sender, EventArgs e)
        {
            DataLoaded = LoadData();
            if (DataLoaded)
            {
                Excel.Application myexcelApplication = new Excel.Application();
                if (myexcelApplication != null)
                {
                    Excel.Workbook myexcelWorkbook = myexcelApplication.Workbooks.Add();
                    Excel.Worksheet myexcelWorksheet = (Excel.Worksheet)myexcelWorkbook.Sheets.Add();
                    myexcelWorksheet.Cells[1, 1] = "Code Matiere";
                    myexcelWorksheet.Cells[1, 2] = "Designation";
                    myexcelWorksheet.Cells[1, 3] = "Semestre";
                    myexcelWorksheet.Cells[1, 4] = "Note";
                    for (int i = 0; i < BilanGrid.RowCount; i++)
                    {
                        myexcelWorksheet.Cells[i + 2, 1] = BilanGrid.Rows[i].Cells[0].Value;
                        myexcelWorksheet.Cells[i + 2, 2] = BilanGrid.Rows[i].Cells[1].Value;
                        myexcelWorksheet.Cells[i + 2, 3] = BilanGrid.Rows[i].Cells[2].Value;
                        myexcelWorksheet.Cells[i + 2, 4] = BilanGrid.Rows[i].Cells[3].Value;
                    }


                    string path = "C:\\Computer Science\\GINF2\\" + FiliereCb.Text + "_" + NiveauCb.Text+".xls";
                    myexcelApplication.ActiveWorkbook.SaveAs(@path, Excel.XlFileFormat.xlWorkbookNormal);

                    myexcelWorkbook.Close();
                    myexcelApplication.Quit();
                }
            }
        }*/
    }
}
