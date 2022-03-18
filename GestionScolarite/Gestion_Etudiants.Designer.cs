
namespace GestionScolarite
{
    partial class Gestion_Etudiants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.CodeCB = new System.Windows.Forms.CheckBox();
            this.NouveauBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.NomCB = new System.Windows.Forms.CheckBox();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.FiliereCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.PrenomCB = new System.Windows.Forms.CheckBox();
            this.PrenomTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.NiveauCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FiliereCBB = new System.Windows.Forms.ComboBox();
            this.NiveauCBB = new System.Windows.Forms.ComboBox();
            this.GestionDesNotesBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CodeTxt
            // 
            this.CodeTxt.Location = new System.Drawing.Point(115, 31);
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(158, 23);
            this.CodeTxt.TabIndex = 1;
            // 
            // CodeCB
            // 
            this.CodeCB.AutoSize = true;
            this.CodeCB.Location = new System.Drawing.Point(288, 35);
            this.CodeCB.Name = "CodeCB";
            this.CodeCB.Size = new System.Drawing.Size(15, 14);
            this.CodeCB.TabIndex = 2;
            this.CodeCB.UseVisualStyleBackColor = true;
            this.CodeCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NouveauBtn
            // 
            this.NouveauBtn.BackColor = System.Drawing.SystemColors.Info;
            this.NouveauBtn.Location = new System.Drawing.Point(397, 31);
            this.NouveauBtn.Name = "NouveauBtn";
            this.NouveauBtn.Size = new System.Drawing.Size(131, 23);
            this.NouveauBtn.TabIndex = 3;
            this.NouveauBtn.Text = "Nouveau";
            this.NouveauBtn.UseVisualStyleBackColor = false;
            this.NouveauBtn.Click += new System.EventHandler(this.NouveauBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.SystemColors.Info;
            this.AjouterBtn.Location = new System.Drawing.Point(397, 69);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(131, 23);
            this.AjouterBtn.TabIndex = 7;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // NomCB
            // 
            this.NomCB.AutoSize = true;
            this.NomCB.Location = new System.Drawing.Point(288, 73);
            this.NomCB.Name = "NomCB";
            this.NomCB.Size = new System.Drawing.Size(15, 14);
            this.NomCB.TabIndex = 6;
            this.NomCB.UseVisualStyleBackColor = true;
            // 
            // NomTxt
            // 
            this.NomTxt.Location = new System.Drawing.Point(115, 69);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(158, 23);
            this.NomTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SupprimerBtn.Location = new System.Drawing.Point(397, 145);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(131, 23);
            this.SupprimerBtn.TabIndex = 15;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            // 
            // FiliereCB
            // 
            this.FiliereCB.AutoSize = true;
            this.FiliereCB.Location = new System.Drawing.Point(288, 149);
            this.FiliereCB.Name = "FiliereCB";
            this.FiliereCB.Size = new System.Drawing.Size(15, 14);
            this.FiliereCB.TabIndex = 14;
            this.FiliereCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filière";
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ModifierBtn.Location = new System.Drawing.Point(397, 107);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(131, 23);
            this.ModifierBtn.TabIndex = 11;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            // 
            // PrenomCB
            // 
            this.PrenomCB.AutoSize = true;
            this.PrenomCB.Location = new System.Drawing.Point(288, 111);
            this.PrenomCB.Name = "PrenomCB";
            this.PrenomCB.Size = new System.Drawing.Size(15, 14);
            this.PrenomCB.TabIndex = 10;
            this.PrenomCB.UseVisualStyleBackColor = true;
            this.PrenomCB.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PrenomTxt
            // 
            this.PrenomTxt.Location = new System.Drawing.Point(115, 107);
            this.PrenomTxt.Name = "PrenomTxt";
            this.PrenomTxt.Size = new System.Drawing.Size(158, 23);
            this.PrenomTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prénom";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.SystemColors.Info;
            this.RechercherBtn.Location = new System.Drawing.Point(397, 186);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(131, 23);
            this.RechercherBtn.TabIndex = 19;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            // 
            // NiveauCB
            // 
            this.NiveauCB.AutoSize = true;
            this.NiveauCB.Location = new System.Drawing.Point(288, 190);
            this.NiveauCB.Name = "NiveauCB";
            this.NiveauCB.Size = new System.Drawing.Size(15, 14);
            this.NiveauCB.TabIndex = 18;
            this.NiveauCB.UseVisualStyleBackColor = true;
            this.NiveauCB.CheckedChanged += new System.EventHandler(this.RechercherCB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Niveau";
            // 
            // FiliereCBB
            // 
            this.FiliereCBB.FormattingEnabled = true;
            this.FiliereCBB.Items.AddRange(new object[] {
            "AP",
            "GINF",
            "GSTR",
            "GSEA",
            "GIND",
            "G3EI"});
            this.FiliereCBB.Location = new System.Drawing.Point(115, 145);
            this.FiliereCBB.Name = "FiliereCBB";
            this.FiliereCBB.Size = new System.Drawing.Size(158, 23);
            this.FiliereCBB.TabIndex = 20;
            // 
            // NiveauCBB
            // 
            this.NiveauCBB.FormattingEnabled = true;
            this.NiveauCBB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.NiveauCBB.Location = new System.Drawing.Point(115, 187);
            this.NiveauCBB.Name = "NiveauCBB";
            this.NiveauCBB.Size = new System.Drawing.Size(158, 23);
            this.NiveauCBB.TabIndex = 21;
            // 
            // GestionDesNotesBtn
            // 
            this.GestionDesNotesBtn.BackColor = System.Drawing.SystemColors.Info;
            this.GestionDesNotesBtn.Location = new System.Drawing.Point(397, 231);
            this.GestionDesNotesBtn.Name = "GestionDesNotesBtn";
            this.GestionDesNotesBtn.Size = new System.Drawing.Size(131, 23);
            this.GestionDesNotesBtn.TabIndex = 22;
            this.GestionDesNotesBtn.Text = "Gestion des notes";
            this.GestionDesNotesBtn.UseVisualStyleBackColor = false;
            this.GestionDesNotesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GestionDesNotesBtn);
            this.Controls.Add(this.NiveauCBB);
            this.Controls.Add(this.FiliereCBB);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.FiliereCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.PrenomCB);
            this.Controls.Add(this.PrenomTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.NomCB);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NouveauBtn);
            this.Controls.Add(this.CodeCB);
            this.Controls.Add(this.CodeTxt);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_Etudiants";
            this.Text = "Gestion_Etudiants";
            this.Load += new System.EventHandler(this.Gestion_Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.CheckBox CodeCB;
        private System.Windows.Forms.Button NouveauBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.CheckBox NomCB;
        private System.Windows.Forms.TextBox NomTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.CheckBox FiliereCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.CheckBox PrenomCB;
        private System.Windows.Forms.TextBox PrenomTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GestionDesNotesBtn;
        private System.Windows.Forms.ComboBox NiveauCBB;
        private System.Windows.Forms.ComboBox FiliereCBB;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.CheckBox NiveauCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}