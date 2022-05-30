namespace Gesform
{
    partial class Form_participant
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
            this.btn_addParticipant = new System.Windows.Forms.Button();
            this.btn_gestionParticipant = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_typeParticipant = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.input_formation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addParticipant
            // 
            this.btn_addParticipant.Location = new System.Drawing.Point(691, 69);
            this.btn_addParticipant.Name = "btn_addParticipant";
            this.btn_addParticipant.Size = new System.Drawing.Size(75, 23);
            this.btn_addParticipant.TabIndex = 0;
            this.btn_addParticipant.Text = "Ajouter";
            this.btn_addParticipant.UseVisualStyleBackColor = true;
            this.btn_addParticipant.Click += new System.EventHandler(this.Btn_addParticipant_Click);
            // 
            // btn_gestionParticipant
            // 
            this.btn_gestionParticipant.Location = new System.Drawing.Point(587, 111);
            this.btn_gestionParticipant.Name = "btn_gestionParticipant";
            this.btn_gestionParticipant.Size = new System.Drawing.Size(201, 23);
            this.btn_gestionParticipant.TabIndex = 1;
            this.btn_gestionParticipant.Text = "Gestion des pariticipants";
            this.btn_gestionParticipant.UseVisualStyleBackColor = true;
            this.btn_gestionParticipant.Click += new System.EventHandler(this.Btn_gestionParticipant_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // input_nom
            // 
            this.input_nom.Location = new System.Drawing.Point(137, 52);
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(168, 20);
            this.input_nom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Participant *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom *";
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(137, 97);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(168, 20);
            this.input_prenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type de participant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Téléphone";
            // 
            // input_telephone
            // 
            this.input_telephone.Location = new System.Drawing.Point(137, 183);
            this.input_telephone.Name = "input_telephone";
            this.input_telephone.Size = new System.Drawing.Size(168, 20);
            this.input_telephone.TabIndex = 9;
            this.input_telephone.Text = "+227";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 232);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(137, 229);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(168, 20);
            this.input_email.TabIndex = 11;
            this.input_email.Text = "@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nom *";
            // 
            // input_typeParticipant
            // 
            this.input_typeParticipant.FormattingEnabled = true;
            this.input_typeParticipant.Items.AddRange(new object[] {
            "Etudiant",
            "Professionnel"});
            this.input_typeParticipant.Location = new System.Drawing.Point(137, 133);
            this.input_typeParticipant.Name = "input_typeParticipant";
            this.input_typeParticipant.Size = new System.Drawing.Size(168, 21);
            this.input_typeParticipant.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date d\'inscription";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 468);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // input_date
            // 
            this.input_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_date.Location = new System.Drawing.Point(137, 269);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(291, 20);
            this.input_date.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Formation";
            // 
            // input_formation
            // 
            this.input_formation.FormattingEnabled = true;
            this.input_formation.Location = new System.Drawing.Point(137, 309);
            this.input_formation.Name = "input_formation";
            this.input_formation.Size = new System.Drawing.Size(121, 21);
            this.input_formation.TabIndex = 25;
            // 
            // Form_participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.input_formation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_typeParticipant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_gestionParticipant);
            this.Controls.Add(this.btn_addParticipant);
            this.Name = "Form_participant";
            this.Text = "Participant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addParticipant;
        private System.Windows.Forms.Button btn_gestionParticipant;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox input_typeParticipant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox input_formation;
    }
}