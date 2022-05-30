namespace Gesform
{
    partial class Form_salles
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
            this.input_salle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_formateur = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addSalle = new System.Windows.Forms.Button();
            this.Gestion_salle = new System.Windows.Forms.Button();
            this.btn_deleteSalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // input_salle
            // 
            this.input_salle.Location = new System.Drawing.Point(178, 38);
            this.input_salle.Name = "input_salle";
            this.input_salle.Size = new System.Drawing.Size(100, 20);
            this.input_salle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de salle *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formateur";
            // 
            // input_formateur
            // 
            this.input_formateur.FormattingEnabled = true;
            this.input_formateur.Location = new System.Drawing.Point(178, 71);
            this.input_formateur.Name = "input_formateur";
            this.input_formateur.Size = new System.Drawing.Size(121, 21);
            this.input_formateur.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_addSalle
            // 
            this.btn_addSalle.Location = new System.Drawing.Point(617, 38);
            this.btn_addSalle.Name = "btn_addSalle";
            this.btn_addSalle.Size = new System.Drawing.Size(75, 23);
            this.btn_addSalle.TabIndex = 6;
            this.btn_addSalle.Text = "Ajouter";
            this.btn_addSalle.UseVisualStyleBackColor = true;
            this.btn_addSalle.Click += new System.EventHandler(this.Btn_addSalle_Click);
            // 
            // Gestion_salle
            // 
            this.Gestion_salle.Location = new System.Drawing.Point(589, 80);
            this.Gestion_salle.Name = "Gestion_salle";
            this.Gestion_salle.Size = new System.Drawing.Size(134, 23);
            this.Gestion_salle.TabIndex = 7;
            this.Gestion_salle.Text = "Gestion des salles";
            this.Gestion_salle.UseVisualStyleBackColor = true;
            this.Gestion_salle.Click += new System.EventHandler(this.Gestion_salle_Click);
            // 
            // btn_deleteSalle
            // 
            this.btn_deleteSalle.Location = new System.Drawing.Point(617, 133);
            this.btn_deleteSalle.Name = "btn_deleteSalle";
            this.btn_deleteSalle.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteSalle.TabIndex = 8;
            this.btn_deleteSalle.Text = "Supprimer";
            this.btn_deleteSalle.UseVisualStyleBackColor = true;
            // 
            // Form_salles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deleteSalle);
            this.Controls.Add(this.Gestion_salle);
            this.Controls.Add(this.btn_addSalle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.input_formateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_salle);
            this.Name = "Form_salles";
            this.Text = "Salles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_salle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox input_formateur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addSalle;
        private System.Windows.Forms.Button Gestion_salle;
        private System.Windows.Forms.Button btn_deleteSalle;
    }
}