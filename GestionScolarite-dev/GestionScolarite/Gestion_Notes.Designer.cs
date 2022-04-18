
namespace GestionScolarite
{
    partial class Gestion_Notes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeEleveTxt = new System.Windows.Forms.TextBox();
            this.NoteTxt = new System.Windows.Forms.TextBox();
            this.MatiereCb = new System.Windows.Forms.ComboBox();
            this.NouveauBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code élève";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matière";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // CodeEleveTxt
            // 
            this.CodeEleveTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeEleveTxt.Location = new System.Drawing.Point(176, 37);
            this.CodeEleveTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeEleveTxt.Name = "CodeEleveTxt";
            this.CodeEleveTxt.ReadOnly = true;
            this.CodeEleveTxt.Size = new System.Drawing.Size(161, 21);
            this.CodeEleveTxt.TabIndex = 3;
            // 
            // NoteTxt
            // 
            this.NoteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoteTxt.Location = new System.Drawing.Point(176, 134);
            this.NoteTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(161, 23);
            this.NoteTxt.TabIndex = 4;
            this.NoteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoteTxt_KeyPress);
            // 
            // MatiereCb
            // 
            this.MatiereCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatiereCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MatiereCb.FormattingEnabled = true;
            this.MatiereCb.Location = new System.Drawing.Point(176, 83);
            this.MatiereCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatiereCb.Name = "MatiereCb";
            this.MatiereCb.Size = new System.Drawing.Size(161, 24);
            this.MatiereCb.TabIndex = 5;
            // 
            // NouveauBtn
            // 
            this.NouveauBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NouveauBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NouveauBtn.Location = new System.Drawing.Point(377, 35);
            this.NouveauBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NouveauBtn.Name = "NouveauBtn";
            this.NouveauBtn.Size = new System.Drawing.Size(125, 29);
            this.NouveauBtn.TabIndex = 6;
            this.NouveauBtn.Text = "Nouveau";
            this.NouveauBtn.UseVisualStyleBackColor = false;
            this.NouveauBtn.Click += new System.EventHandler(this.NouveauBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AjouterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AjouterBtn.Location = new System.Drawing.Point(377, 85);
            this.AjouterBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(125, 29);
            this.AjouterBtn.TabIndex = 7;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ModifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModifierBtn.Location = new System.Drawing.Point(377, 134);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(125, 29);
            this.ModifierBtn.TabIndex = 8;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SupprimerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupprimerBtn.Location = new System.Drawing.Point(571, 35);
            this.SupprimerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(125, 29);
            this.SupprimerBtn.TabIndex = 9;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RechercherBtn.Location = new System.Drawing.Point(571, 85);
            this.RechercherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(125, 29);
            this.RechercherBtn.TabIndex = 10;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // Gestion_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 193);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.NouveauBtn);
            this.Controls.Add(this.MatiereCb);
            this.Controls.Add(this.NoteTxt);
            this.Controls.Add(this.CodeEleveTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gestion_Notes";
            this.Text = "Gestion des notes";
            this.Load += new System.EventHandler(this.Gestion_Notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodeEleveTxt;
        private System.Windows.Forms.TextBox NoteTxt;
        private System.Windows.Forms.ComboBox MatiereCb;
        private System.Windows.Forms.Button NouveauBtn;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button RechercherBtn;
    }
}

