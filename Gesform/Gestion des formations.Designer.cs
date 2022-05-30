namespace Gesform
{
    partial class Gestion_des_formations
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
            this.label10 = new System.Windows.Forms.Label();
            this.input_prix = new System.Windows.Forms.TextBox();
            this.input_theme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.input_dateFin = new System.Windows.Forms.DateTimePicker();
            this.input_dateDebut = new System.Windows.Forms.DateTimePicker();
            this.btn_AddFormation = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.input_salle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_module = new System.Windows.Forms.ComboBox();
            this.input_formateur = new System.Windows.Forms.ComboBox();
            this.input_niveau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_place = new System.Windows.Forms.TextBox();
            this.input_lieu = new System.Windows.Forms.TextBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.btn_deleteFormateur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Prix de la formation *";
            // 
            // input_prix
            // 
            this.input_prix.Location = new System.Drawing.Point(175, 369);
            this.input_prix.Name = "input_prix";
            this.input_prix.Size = new System.Drawing.Size(121, 20);
            this.input_prix.TabIndex = 52;
            // 
            // input_theme
            // 
            this.input_theme.Location = new System.Drawing.Point(175, 38);
            this.input_theme.Name = "input_theme";
            this.input_theme.Size = new System.Drawing.Size(100, 20);
            this.input_theme.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Date de fin de formation *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Date de formation *";
            // 
            // input_dateFin
            // 
            this.input_dateFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_dateFin.Location = new System.Drawing.Point(175, 465);
            this.input_dateFin.Name = "input_dateFin";
            this.input_dateFin.Size = new System.Drawing.Size(291, 20);
            this.input_dateFin.TabIndex = 49;
            // 
            // input_dateDebut
            // 
            this.input_dateDebut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_dateDebut.Location = new System.Drawing.Point(175, 418);
            this.input_dateDebut.Name = "input_dateDebut";
            this.input_dateDebut.Size = new System.Drawing.Size(291, 20);
            this.input_dateDebut.TabIndex = 48;
            // 
            // btn_AddFormation
            // 
            this.btn_AddFormation.Location = new System.Drawing.Point(648, 70);
            this.btn_AddFormation.Name = "btn_AddFormation";
            this.btn_AddFormation.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFormation.TabIndex = 47;
            this.btn_AddFormation.Text = "Ajouter";
            this.btn_AddFormation.UseVisualStyleBackColor = true;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(619, 173);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(140, 23);
            this.btn_Modifier.TabIndex = 46;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(648, 116);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(75, 23);
            this.vider.TabIndex = 45;
            this.vider.Text = "Vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 529);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 150);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Salle";
            // 
            // input_salle
            // 
            this.input_salle.FormattingEnabled = true;
            this.input_salle.Location = new System.Drawing.Point(175, 316);
            this.input_salle.Name = "input_salle";
            this.input_salle.Size = new System.Drawing.Size(121, 21);
            this.input_salle.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Formateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Niveau *";
            // 
            // input_module
            // 
            this.input_module.FormattingEnabled = true;
            this.input_module.Location = new System.Drawing.Point(175, 275);
            this.input_module.Name = "input_module";
            this.input_module.Size = new System.Drawing.Size(121, 21);
            this.input_module.TabIndex = 38;
            // 
            // input_formateur
            // 
            this.input_formateur.FormattingEnabled = true;
            this.input_formateur.Location = new System.Drawing.Point(175, 224);
            this.input_formateur.Name = "input_formateur";
            this.input_formateur.Size = new System.Drawing.Size(121, 21);
            this.input_formateur.TabIndex = 37;
            // 
            // input_niveau
            // 
            this.input_niveau.FormattingEnabled = true;
            this.input_niveau.Items.AddRange(new object[] {
            "Debutant",
            "Moyen",
            "Avancer"});
            this.input_niveau.Location = new System.Drawing.Point(175, 176);
            this.input_niveau.Name = "input_niveau";
            this.input_niveau.Size = new System.Drawing.Size(121, 21);
            this.input_niveau.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Place Limité *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lieu de formation *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Théme *";
            // 
            // input_place
            // 
            this.input_place.Location = new System.Drawing.Point(175, 130);
            this.input_place.Name = "input_place";
            this.input_place.Size = new System.Drawing.Size(100, 20);
            this.input_place.TabIndex = 32;
            // 
            // input_lieu
            // 
            this.input_lieu.Location = new System.Drawing.Point(175, 88);
            this.input_lieu.Name = "input_lieu";
            this.input_lieu.Size = new System.Drawing.Size(100, 20);
            this.input_lieu.TabIndex = 31;
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(398, 38);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(100, 20);
            this.input_id.TabIndex = 54;
            this.input_id.Visible = false;
            // 
            // btn_deleteFormateur
            // 
            this.btn_deleteFormateur.Location = new System.Drawing.Point(619, 224);
            this.btn_deleteFormateur.Name = "btn_deleteFormateur";
            this.btn_deleteFormateur.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteFormateur.TabIndex = 55;
            this.btn_deleteFormateur.Text = "Supprimer";
            this.btn_deleteFormateur.UseVisualStyleBackColor = true;
            this.btn_deleteFormateur.Click += new System.EventHandler(this.Btn_deleteFormateur_Click_1);
            // 
            // Gestion_des_formations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.btn_deleteFormateur);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.input_prix);
            this.Controls.Add(this.input_theme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_dateFin);
            this.Controls.Add(this.input_dateDebut);
            this.Controls.Add(this.btn_AddFormation);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_salle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_module);
            this.Controls.Add(this.input_formateur);
            this.Controls.Add(this.input_niveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_place);
            this.Controls.Add(this.input_lieu);
            this.Name = "Gestion_des_formations";
            this.Text = "Gestion des formations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input_prix;
        private System.Windows.Forms.TextBox input_theme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker input_dateFin;
        private System.Windows.Forms.DateTimePicker input_dateDebut;
        private System.Windows.Forms.Button btn_AddFormation;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox input_salle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox input_module;
        private System.Windows.Forms.ComboBox input_formateur;
        private System.Windows.Forms.ComboBox input_niveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_place;
        private System.Windows.Forms.TextBox input_lieu;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Button btn_deleteFormateur;
    }
}