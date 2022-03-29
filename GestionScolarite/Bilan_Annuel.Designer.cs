
namespace GestionScolarite
{
    partial class Bilan_Annuel
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
            this.BilanGrid = new System.Windows.Forms.DataGridView();
            this.MoyenneAnuelleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.NiveauCb = new System.Windows.Forms.ComboBox();
            this.EtudiantCb = new System.Windows.Forms.ComboBox();
            this.FiliereCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BilanGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BilanGrid
            // 
            this.BilanGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BilanGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.BilanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilanGrid.Location = new System.Drawing.Point(76, 158);
            this.BilanGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BilanGrid.Name = "BilanGrid";
            this.BilanGrid.RowHeadersWidth = 62;
            this.BilanGrid.RowTemplate.Height = 28;
            this.BilanGrid.Size = new System.Drawing.Size(589, 138);
            this.BilanGrid.TabIndex = 29;
            this.BilanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BilanGrid_CellContentClick);
            // 
            // MoyenneAnuelleTxt
            // 
            this.MoyenneAnuelleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoyenneAnuelleTxt.Location = new System.Drawing.Point(234, 332);
            this.MoyenneAnuelleTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoyenneAnuelleTxt.Name = "MoyenneAnuelleTxt";
            this.MoyenneAnuelleTxt.Size = new System.Drawing.Size(207, 23);
            this.MoyenneAnuelleTxt.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Moyenne annuelle";
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.SystemColors.Info;
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RechercherBtn.Location = new System.Drawing.Point(489, 106);
            this.RechercherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(142, 32);
            this.RechercherBtn.TabIndex = 26;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // NiveauCb
            // 
            this.NiveauCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NiveauCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NiveauCb.FormattingEnabled = true;
            this.NiveauCb.Location = new System.Drawing.Point(489, 43);
            this.NiveauCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NiveauCb.Name = "NiveauCb";
            this.NiveauCb.Size = new System.Drawing.Size(143, 24);
            this.NiveauCb.TabIndex = 25;
            this.NiveauCb.SelectedIndexChanged += new System.EventHandler(this.NiveauCb_SelectedIndexChanged);
            // 
            // EtudiantCb
            // 
            this.EtudiantCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EtudiantCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EtudiantCb.FormattingEnabled = true;
            this.EtudiantCb.Location = new System.Drawing.Point(176, 106);
            this.EtudiantCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EtudiantCb.Name = "EtudiantCb";
            this.EtudiantCb.Size = new System.Drawing.Size(171, 24);
            this.EtudiantCb.TabIndex = 24;
            // 
            // FiliereCb
            // 
            this.FiliereCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiliereCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FiliereCb.FormattingEnabled = true;
            this.FiliereCb.Location = new System.Drawing.Point(176, 43);
            this.FiliereCb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FiliereCb.Name = "FiliereCb";
            this.FiliereCb.Size = new System.Drawing.Size(171, 24);
            this.FiliereCb.TabIndex = 23;
            this.FiliereCb.SelectedIndexChanged += new System.EventHandler(this.FiliereCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(385, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Etudiant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filière";
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(489, 332);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(143, 23);
            this.ExcelBtn.TabIndex = 30;
            this.ExcelBtn.Text = "button1";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // Bilan_Annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 396);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.BilanGrid);
            this.Controls.Add(this.MoyenneAnuelleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCb);
            this.Controls.Add(this.EtudiantCb);
            this.Controls.Add(this.FiliereCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bilan_Annuel";
            this.Text = "Bilan_Annuel";
            this.Load += new System.EventHandler(this.Bilan_Annuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BilanGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BilanGrid;
        private System.Windows.Forms.TextBox MoyenneAnuelleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.ComboBox NiveauCb;
        private System.Windows.Forms.ComboBox EtudiantCb;
        private System.Windows.Forms.ComboBox FiliereCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExcelBtn;
    }
}