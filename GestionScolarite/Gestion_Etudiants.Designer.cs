﻿
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
            this.Code = new System.Windows.Forms.TextBox();
            this.CodeCB = new System.Windows.Forms.CheckBox();
            this.NouveauBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.NomCB = new System.Windows.Forms.CheckBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.FiliereCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.PrenomCB = new System.Windows.Forms.CheckBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.NiveauCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Code_fil = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.GestionDesNotesBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(164, 52);
            this.Code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(224, 31);
            this.Code.TabIndex = 1;
            // 
            // CodeCB
            // 
            this.CodeCB.AutoSize = true;
            this.CodeCB.Location = new System.Drawing.Point(411, 58);
            this.CodeCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeCB.Name = "CodeCB";
            this.CodeCB.Size = new System.Drawing.Size(22, 21);
            this.CodeCB.TabIndex = 2;
            this.CodeCB.UseVisualStyleBackColor = true;
            this.CodeCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NouveauBtn
            // 
            this.NouveauBtn.BackColor = System.Drawing.SystemColors.Info;
            this.NouveauBtn.Location = new System.Drawing.Point(567, 52);
            this.NouveauBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NouveauBtn.Name = "NouveauBtn";
            this.NouveauBtn.Size = new System.Drawing.Size(187, 38);
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
            this.AjouterBtn.Location = new System.Drawing.Point(567, 115);
            this.AjouterBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(187, 38);
            this.AjouterBtn.TabIndex = 7;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // NomCB
            // 
            this.NomCB.AutoSize = true;
            this.NomCB.Location = new System.Drawing.Point(411, 122);
            this.NomCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomCB.Name = "NomCB";
            this.NomCB.Size = new System.Drawing.Size(22, 21);
            this.NomCB.TabIndex = 6;
            this.NomCB.UseVisualStyleBackColor = true;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(164, 115);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(224, 31);
            this.Nom.TabIndex = 5;
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SupprimerBtn.Location = new System.Drawing.Point(567, 242);
            this.SupprimerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(187, 38);
            this.SupprimerBtn.TabIndex = 15;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // FiliereCB
            // 
            this.FiliereCB.AutoSize = true;
            this.FiliereCB.Location = new System.Drawing.Point(411, 248);
            this.FiliereCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiliereCB.Name = "FiliereCB";
            this.FiliereCB.Size = new System.Drawing.Size(22, 21);
            this.FiliereCB.TabIndex = 14;
            this.FiliereCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filière";
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ModifierBtn.Location = new System.Drawing.Point(567, 178);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(187, 38);
            this.ModifierBtn.TabIndex = 11;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // PrenomCB
            // 
            this.PrenomCB.AutoSize = true;
            this.PrenomCB.Location = new System.Drawing.Point(411, 185);
            this.PrenomCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrenomCB.Name = "PrenomCB";
            this.PrenomCB.Size = new System.Drawing.Size(22, 21);
            this.PrenomCB.TabIndex = 10;
            this.PrenomCB.UseVisualStyleBackColor = true;
            this.PrenomCB.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(164, 178);
            this.Prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(224, 31);
            this.Prenom.TabIndex = 9;
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.SystemColors.Info;
            this.RechercherBtn.Location = new System.Drawing.Point(567, 310);
            this.RechercherBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(187, 38);
            this.RechercherBtn.TabIndex = 19;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // NiveauCB
            // 
            this.NiveauCB.AutoSize = true;
            this.NiveauCB.Location = new System.Drawing.Point(411, 317);
            this.NiveauCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NiveauCB.Name = "NiveauCB";
            this.NiveauCB.Size = new System.Drawing.Size(22, 21);
            this.NiveauCB.TabIndex = 18;
            this.NiveauCB.UseVisualStyleBackColor = true;
            this.NiveauCB.CheckedChanged += new System.EventHandler(this.RechercherCB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Niveau";
            // 
            // Code_fil
            // 
            this.Code_fil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Code_fil.FormattingEnabled = true;
            this.Code_fil.Location = new System.Drawing.Point(164, 242);
            this.Code_fil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Code_fil.Name = "Code_fil";
            this.Code_fil.Size = new System.Drawing.Size(224, 33);
            this.Code_fil.TabIndex = 20;
            this.Code_fil.SelectedIndexChanged += new System.EventHandler(this.FiliereCBB_SelectedIndexChanged);
            // 
            // Niveau
            // 
            this.Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Location = new System.Drawing.Point(164, 312);
            this.Niveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(224, 33);
            this.Niveau.TabIndex = 21;
            // 
            // GestionDesNotesBtn
            // 
            this.GestionDesNotesBtn.BackColor = System.Drawing.SystemColors.Info;
            this.GestionDesNotesBtn.Location = new System.Drawing.Point(567, 385);
            this.GestionDesNotesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GestionDesNotesBtn.Name = "GestionDesNotesBtn";
            this.GestionDesNotesBtn.Size = new System.Drawing.Size(187, 38);
            this.GestionDesNotesBtn.TabIndex = 22;
            this.GestionDesNotesBtn.Text = "Gestion des notes";
            this.GestionDesNotesBtn.UseVisualStyleBackColor = false;
            this.GestionDesNotesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 460);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(780, 250);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prénom";
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GestionDesNotesBtn);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Code_fil);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.FiliereCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.PrenomCB);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.NomCB);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.NouveauBtn);
            this.Controls.Add(this.CodeCB);
            this.Controls.Add(this.Code);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gestion_Etudiants";
            this.Text = "Gestion_Etudiants";
            this.Load += new System.EventHandler(this.Gestion_Etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.CheckBox CodeCB;
        private System.Windows.Forms.Button NouveauBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.CheckBox NomCB;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.CheckBox FiliereCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.CheckBox PrenomCB;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Button GestionDesNotesBtn;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.ComboBox Code_fil;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.CheckBox NiveauCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}