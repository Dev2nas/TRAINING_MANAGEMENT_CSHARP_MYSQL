namespace Gesform
{
    partial class Form_modules
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
            this.Gestion_module = new System.Windows.Forms.Button();
            this.input_formateur = new System.Windows.Forms.ComboBox();
            this.vider = new System.Windows.Forms.Button();
            this.addModule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.input_module = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_horaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gestion_module
            // 
            this.Gestion_module.Location = new System.Drawing.Point(577, 115);
            this.Gestion_module.Name = "Gestion_module";
            this.Gestion_module.Size = new System.Drawing.Size(139, 23);
            this.Gestion_module.TabIndex = 0;
            this.Gestion_module.Tag = "Modifier";
            this.Gestion_module.Text = "Gestion des modules";
            this.Gestion_module.UseVisualStyleBackColor = true;
            this.Gestion_module.Click += new System.EventHandler(this.Gestion_module_Click);
            // 
            // input_formateur
            // 
            this.input_formateur.FormattingEnabled = true;
            this.input_formateur.Location = new System.Drawing.Point(151, 136);
            this.input_formateur.Name = "input_formateur";
            this.input_formateur.Size = new System.Drawing.Size(121, 21);
            this.input_formateur.TabIndex = 1;
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(610, 165);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(75, 23);
            this.vider.TabIndex = 2;
            this.vider.Text = "Vider";
            this.vider.UseVisualStyleBackColor = true;
            // 
            // addModule
            // 
            this.addModule.Location = new System.Drawing.Point(610, 58);
            this.addModule.Name = "addModule";
            this.addModule.Size = new System.Drawing.Size(75, 23);
            this.addModule.TabIndex = 3;
            this.addModule.Text = "Ajouter";
            this.addModule.UseVisualStyleBackColor = true;
            this.addModule.Click += new System.EventHandler(this.AddModule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // input_module
            // 
            this.input_module.Location = new System.Drawing.Point(151, 58);
            this.input_module.Name = "input_module";
            this.input_module.Size = new System.Drawing.Size(100, 20);
            this.input_module.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Module *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre d\'heure";
            // 
            // input_horaire
            // 
            this.input_horaire.Location = new System.Drawing.Point(151, 96);
            this.input_horaire.Name = "input_horaire";
            this.input_horaire.Size = new System.Drawing.Size(100, 20);
            this.input_horaire.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Formateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liste des Modules disponible";
            // 
            // Form_modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_horaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_module);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addModule);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.input_formateur);
            this.Controls.Add(this.Gestion_module);
            this.Name = "Form_modules";
            this.Text = "Module";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gestion_module;
        private System.Windows.Forms.ComboBox input_formateur;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.Button addModule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox input_module;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_horaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}