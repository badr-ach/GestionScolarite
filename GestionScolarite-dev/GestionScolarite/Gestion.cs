﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionScolarite
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void billanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bilan_Annuel().ShowDialog();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Gestion_Etudiants().ShowDialog();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consultation_Notes().ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}