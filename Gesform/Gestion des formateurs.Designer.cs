namespace Gesform
{
    partial class Form_formateurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_addFormateur = new System.Windows.Forms.Button();
            this.btn_updateFormateur = new System.Windows.Forms.Button();
            this.btn_deleteFormateur = new System.Windows.Forms.Button();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.input_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addFormateur
            // 
            this.btn_addFormateur.Location = new System.Drawing.Point(623, 85);
            this.btn_addFormateur.Name = "btn_addFormateur";
            this.btn_addFormateur.Size = new System.Drawing.Size(75, 23);
            this.btn_addFormateur.TabIndex = 0;
            this.btn_addFormateur.Text = "Ajouter";
            this.btn_addFormateur.UseVisualStyleBackColor = true;
            this.btn_addFormateur.Click += new System.EventHandler(this.AddFormateur_Click);
            // 
            // btn_updateFormateur
            // 
            this.btn_updateFormateur.Location = new System.Drawing.Point(623, 126);
            this.btn_updateFormateur.Name = "btn_updateFormateur";
            this.btn_updateFormateur.Size = new System.Drawing.Size(75, 23);
            this.btn_updateFormateur.TabIndex = 1;
            this.btn_updateFormateur.Text = "Modifier";
            this.btn_updateFormateur.UseVisualStyleBackColor = true;
            this.btn_updateFormateur.Click += new System.EventHandler(this.Btn_updateFormateur_Click);
            // 
            // btn_deleteFormateur
            // 
            this.btn_deleteFormateur.Location = new System.Drawing.Point(623, 165);
            this.btn_deleteFormateur.Name = "btn_deleteFormateur";
            this.btn_deleteFormateur.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteFormateur.TabIndex = 2;
            this.btn_deleteFormateur.Text = "Supprimer";
            this.btn_deleteFormateur.UseVisualStyleBackColor = true;
            this.btn_deleteFormateur.Click += new System.EventHandler(this.Btn_deleteFormateur_Click);
            // 
            // input_nom
            // 
            this.input_nom.Location = new System.Drawing.Point(130, 59);
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(100, 20);
            this.input_nom.TabIndex = 3;
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(130, 116);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(100, 20);
            this.input_prenom.TabIndex = 4;
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(130, 153);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(100, 20);
            this.input_email.TabIndex = 5;
            // 
            // input_tel
            // 
            this.input_tel.Location = new System.Drawing.Point(130, 196);
            this.input_tel.Name = "input_tel";
            this.input_tel.Size = new System.Drawing.Size(100, 20);
            this.input_tel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Téléphone *";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(13, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(623, 202);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(138, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Vider";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(130, 239);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(100, 20);
            this.input_id.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "N°";
            // 
            // Form_formateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_tel);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.btn_deleteFormateur);
            this.Controls.Add(this.btn_updateFormateur);
            this.Controls.Add(this.btn_addFormateur);
            this.Name = "Form_formateurs";
            this.Text = "Gestion des formateurs";
            this.Load += new System.EventHandler(this.Form_formateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addFormateur;
        private System.Windows.Forms.Button btn_updateFormateur;
        private System.Windows.Forms.Button btn_deleteFormateur;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Label label5;
    }
}