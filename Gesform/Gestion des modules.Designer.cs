namespace Gesform
{
    partial class Gestion_modules
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_updateModule = new System.Windows.Forms.Button();
            this.btn_deleteFormateur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.input_horaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_module = new System.Windows.Forms.TextBox();
            this.input_formateur = new System.Windows.Forms.ComboBox();
            this.input_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addFormateur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_updateModule
            // 
            this.Btn_updateModule.Location = new System.Drawing.Point(623, 126);
            this.Btn_updateModule.Name = "Btn_updateModule";
            this.Btn_updateModule.Size = new System.Drawing.Size(75, 23);
            this.Btn_updateModule.TabIndex = 1;
            this.Btn_updateModule.Text = "Modifier";
            this.Btn_updateModule.UseVisualStyleBackColor = true;
            this.Btn_updateModule.Click += new System.EventHandler(this.Btn_updateModule_Click);
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
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
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
            // input_horaire
            // 
            this.input_horaire.Location = new System.Drawing.Point(150, 89);
            this.input_horaire.Name = "input_horaire";
            this.input_horaire.Size = new System.Drawing.Size(100, 20);
            this.input_horaire.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre d\'heure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Module *";
            // 
            // input_module
            // 
            this.input_module.Location = new System.Drawing.Point(150, 51);
            this.input_module.Name = "input_module";
            this.input_module.Size = new System.Drawing.Size(100, 20);
            this.input_module.TabIndex = 14;
            // 
            // input_formateur
            // 
            this.input_formateur.FormattingEnabled = true;
            this.input_formateur.Location = new System.Drawing.Point(150, 129);
            this.input_formateur.Name = "input_formateur";
            this.input_formateur.Size = new System.Drawing.Size(121, 21);
            this.input_formateur.TabIndex = 13;
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(150, 226);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(100, 20);
            this.input_id.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Formateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "N°";
            // 
            // btn_addFormateur
            // 
            this.btn_addFormateur.Location = new System.Drawing.Point(623, 85);
            this.btn_addFormateur.Name = "btn_addFormateur";
            this.btn_addFormateur.Size = new System.Drawing.Size(75, 23);
            this.btn_addFormateur.TabIndex = 0;
            this.btn_addFormateur.Text = "Ajouter";
            this.btn_addFormateur.UseVisualStyleBackColor = true;
            // 
            // Gestion_modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.input_horaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_module);
            this.Controls.Add(this.input_formateur);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_deleteFormateur);
            this.Controls.Add(this.Btn_updateModule);
            this.Controls.Add(this.btn_addFormateur);
            this.Name = "Gestion_modules";
            this.Text = "Gestion des modules";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_updateModule;
        private System.Windows.Forms.Button btn_deleteFormateur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox input_horaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_module;
        private System.Windows.Forms.ComboBox input_formateur;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addFormateur;
    }
}