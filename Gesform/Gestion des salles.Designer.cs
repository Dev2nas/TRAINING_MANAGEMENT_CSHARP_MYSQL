namespace Gesform
{
    partial class Gestion_des_salles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.input_formateur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_salle = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update_salle = new System.Windows.Forms.Button();
            this.btn_delete_salle = new System.Windows.Forms.Button();
            this.btn_vider = new System.Windows.Forms.Button();
            this.input_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // input_formateur
            // 
            this.input_formateur.FormattingEnabled = true;
            this.input_formateur.Location = new System.Drawing.Point(184, 82);
            this.input_formateur.Name = "input_formateur";
            this.input_formateur.Size = new System.Drawing.Size(121, 21);
            this.input_formateur.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Formateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de salle *";
            // 
            // input_salle
            // 
            this.input_salle.Location = new System.Drawing.Point(184, 49);
            this.input_salle.Name = "input_salle";
            this.input_salle.Size = new System.Drawing.Size(100, 20);
            this.input_salle.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(678, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update_salle
            // 
            this.btn_update_salle.Location = new System.Drawing.Point(678, 91);
            this.btn_update_salle.Name = "btn_update_salle";
            this.btn_update_salle.Size = new System.Drawing.Size(75, 23);
            this.btn_update_salle.TabIndex = 12;
            this.btn_update_salle.Text = "Modifier";
            this.btn_update_salle.UseVisualStyleBackColor = true;
            this.btn_update_salle.Click += new System.EventHandler(this.Btn_update_salle_Click_1);
            // 
            // btn_delete_salle
            // 
            this.btn_delete_salle.Location = new System.Drawing.Point(678, 141);
            this.btn_delete_salle.Name = "btn_delete_salle";
            this.btn_delete_salle.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_salle.TabIndex = 13;
            this.btn_delete_salle.Text = "Supprimer";
            this.btn_delete_salle.UseVisualStyleBackColor = true;
            this.btn_delete_salle.Click += new System.EventHandler(this.Btn_delete_salle_Click);
            // 
            // btn_vider
            // 
            this.btn_vider.Location = new System.Drawing.Point(678, 185);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(75, 23);
            this.btn_vider.TabIndex = 14;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = true;
            this.btn_vider.Click += new System.EventHandler(this.Btn_vider_Click);
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(184, 201);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(100, 20);
            this.input_id.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "N°";
            // 
            // Gestion_des_salles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.btn_vider);
            this.Controls.Add(this.btn_delete_salle);
            this.Controls.Add(this.btn_update_salle);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.input_formateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_salle);
            this.Name = "Gestion_des_salles";
            this.Text = "Gestion des salles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox input_formateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_salle;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update_salle;
        private System.Windows.Forms.Button btn_delete_salle;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.Label label3;
    }
}