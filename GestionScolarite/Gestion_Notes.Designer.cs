
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
            this.label1.Location = new System.Drawing.Point(93, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code élève";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matière";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // CodeEleveTxt
            // 
            this.CodeEleveTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeEleveTxt.Location = new System.Drawing.Point(252, 62);
            this.CodeEleveTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodeEleveTxt.Name = "CodeEleveTxt";
            this.CodeEleveTxt.ReadOnly = true;
            this.CodeEleveTxt.Size = new System.Drawing.Size(228, 28);
            this.CodeEleveTxt.TabIndex = 3;
            // 
            // NoteTxt
            // 
            this.NoteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoteTxt.Location = new System.Drawing.Point(252, 224);
            this.NoteTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(228, 30);
            this.NoteTxt.TabIndex = 4;
            this.NoteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoteTxt_KeyPress);
            // 
            // MatiereCb
            // 
            this.MatiereCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatiereCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MatiereCb.FormattingEnabled = true;
            this.MatiereCb.Location = new System.Drawing.Point(252, 138);
            this.MatiereCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MatiereCb.Name = "MatiereCb";
            this.MatiereCb.Size = new System.Drawing.Size(228, 33);
            this.MatiereCb.TabIndex = 5;
            // 
            // NouveauBtn
            // 
            this.NouveauBtn.BackColor = System.Drawing.SystemColors.Info;
            this.NouveauBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NouveauBtn.Location = new System.Drawing.Point(538, 58);
            this.NouveauBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NouveauBtn.Name = "NouveauBtn";
            this.NouveauBtn.Size = new System.Drawing.Size(178, 48);
            this.NouveauBtn.TabIndex = 6;
            this.NouveauBtn.Text = "Nouveau";
            this.NouveauBtn.UseVisualStyleBackColor = false;
            this.NouveauBtn.Click += new System.EventHandler(this.NouveauBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.SystemColors.Info;
            this.AjouterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AjouterBtn.Location = new System.Drawing.Point(538, 141);
            this.AjouterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(178, 48);
            this.AjouterBtn.TabIndex = 7;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ModifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModifierBtn.Location = new System.Drawing.Point(538, 224);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(178, 48);
            this.ModifierBtn.TabIndex = 8;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SupprimerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupprimerBtn.Location = new System.Drawing.Point(816, 58);
            this.SupprimerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(178, 48);
            this.SupprimerBtn.TabIndex = 9;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.SystemColors.Info;
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RechercherBtn.Location = new System.Drawing.Point(816, 141);
            this.RechercherBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(178, 48);
            this.RechercherBtn.TabIndex = 10;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // Gestion_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 322);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

