
namespace GestionScolarite
{
    partial class Consultation_Notes
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
            this.filiereCb = new System.Windows.Forms.ComboBox();
            this.MatiereCb = new System.Windows.Forms.ComboBox();
            this.NiveauCb = new System.Windows.Forms.ComboBox();
            this.RechercherBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.moyenneTxt = new System.Windows.Forms.TextBox();
            this.NoteGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filière";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(531, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Niveau";
            // 
            // filiereCb
            // 
            this.filiereCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiereCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filiereCb.FormattingEnabled = true;
            this.filiereCb.Location = new System.Drawing.Point(233, 57);
            this.filiereCb.Name = "filiereCb";
            this.filiereCb.Size = new System.Drawing.Size(243, 33);
            this.filiereCb.TabIndex = 3;
            this.filiereCb.SelectedIndexChanged += new System.EventHandler(this.filiereCb_SelectedIndexChanged);
            // 
            // MatiereCb
            // 
            this.MatiereCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatiereCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MatiereCb.FormattingEnabled = true;
            this.MatiereCb.Location = new System.Drawing.Point(233, 162);
            this.MatiereCb.Name = "MatiereCb";
            this.MatiereCb.Size = new System.Drawing.Size(243, 33);
            this.MatiereCb.TabIndex = 4;
            this.MatiereCb.SelectedIndexChanged += new System.EventHandler(this.MatiereCb_SelectedIndexChanged);
            // 
            // NiveauCb
            // 
            this.NiveauCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NiveauCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NiveauCb.FormattingEnabled = true;
            this.NiveauCb.Location = new System.Drawing.Point(680, 57);
            this.NiveauCb.Name = "NiveauCb";
            this.NiveauCb.Size = new System.Drawing.Size(203, 33);
            this.NiveauCb.TabIndex = 5;
            this.NiveauCb.SelectedIndexChanged += new System.EventHandler(this.NiveauCb_SelectedIndexChanged);
            // 
            // RechercherBtn
            // 
            this.RechercherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RechercherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RechercherBtn.Location = new System.Drawing.Point(680, 162);
            this.RechercherBtn.Name = "RechercherBtn";
            this.RechercherBtn.Size = new System.Drawing.Size(203, 53);
            this.RechercherBtn.TabIndex = 6;
            this.RechercherBtn.Text = "Rechercher";
            this.RechercherBtn.UseVisualStyleBackColor = false;
            this.RechercherBtn.Click += new System.EventHandler(this.RechercherBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moyenne de la classe";
            // 
            // moyenneTxt
            // 
            this.moyenneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moyenneTxt.Location = new System.Drawing.Point(497, 537);
            this.moyenneTxt.Name = "moyenneTxt";
            this.moyenneTxt.Size = new System.Drawing.Size(294, 30);
            this.moyenneTxt.TabIndex = 8;
            // 
            // NoteGrid
            // 
            this.NoteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NoteGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.NoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteGrid.Location = new System.Drawing.Point(89, 248);
            this.NoteGrid.Name = "NoteGrid";
            this.NoteGrid.RowHeadersWidth = 62;
            this.NoteGrid.RowTemplate.Height = 28;
            this.NoteGrid.Size = new System.Drawing.Size(841, 230);
            this.NoteGrid.TabIndex = 9;
            // 
            // Consultation_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 622);
            this.Controls.Add(this.NoteGrid);
            this.Controls.Add(this.moyenneTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RechercherBtn);
            this.Controls.Add(this.NiveauCb);
            this.Controls.Add(this.MatiereCb);
            this.Controls.Add(this.filiereCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultation_Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation_Notes";
            this.Load += new System.EventHandler(this.Consultation_Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filiereCb;
        private System.Windows.Forms.ComboBox MatiereCb;
        private System.Windows.Forms.ComboBox NiveauCb;
        private System.Windows.Forms.Button RechercherBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox moyenneTxt;
        private System.Windows.Forms.DataGridView NoteGrid;
    }
}