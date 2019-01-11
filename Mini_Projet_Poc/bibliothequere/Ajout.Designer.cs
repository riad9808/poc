namespace bibliothequere
{
	partial class Ajout
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.code = new System.Windows.Forms.TextBox();
			this.titre = new System.Windows.Forms.TextBox();
			this.auteur = new System.Windows.Forms.TextBox();
			this.theme = new System.Windows.Forms.TextBox();
			this.these = new System.Windows.Forms.RadioButton();
			this.memoire = new System.Windows.Forms.RadioButton();
			this.livre = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "codes-barres";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "titre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "auteur";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "theme";
			// 
			// code
			// 
			this.code.Location = new System.Drawing.Point(55, 68);
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(100, 20);
			this.code.TabIndex = 5;
			// 
			// titre
			// 
			this.titre.Location = new System.Drawing.Point(55, 166);
			this.titre.Name = "titre";
			this.titre.Size = new System.Drawing.Size(100, 20);
			this.titre.TabIndex = 6;
			// 
			// auteur
			// 
			this.auteur.Location = new System.Drawing.Point(55, 216);
			this.auteur.Name = "auteur";
			this.auteur.Size = new System.Drawing.Size(100, 20);
			this.auteur.TabIndex = 7;
			// 
			// theme
			// 
			this.theme.Location = new System.Drawing.Point(55, 267);
			this.theme.Name = "theme";
			this.theme.Size = new System.Drawing.Size(100, 20);
			this.theme.TabIndex = 8;
			// 
			// these
			// 
			this.these.AutoSize = true;
			this.these.Location = new System.Drawing.Point(55, 119);
			this.these.Name = "these";
			this.these.Size = new System.Drawing.Size(51, 17);
			this.these.TabIndex = 9;
			this.these.TabStop = true;
			this.these.Text = "these";
			this.these.UseVisualStyleBackColor = true;
			// 
			// memoire
			// 
			this.memoire.AutoSize = true;
			this.memoire.Location = new System.Drawing.Point(146, 119);
			this.memoire.Name = "memoire";
			this.memoire.Size = new System.Drawing.Size(64, 17);
			this.memoire.TabIndex = 10;
			this.memoire.TabStop = true;
			this.memoire.Text = "memoire";
			this.memoire.UseVisualStyleBackColor = true;
			// 
			// livre
			// 
			this.livre.AutoSize = true;
			this.livre.Location = new System.Drawing.Point(237, 119);
			this.livre.Name = "livre";
			this.livre.Size = new System.Drawing.Size(44, 17);
			this.livre.TabIndex = 11;
			this.livre.TabStop = true;
			this.livre.Text = "livre";
			this.livre.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(55, 312);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "valider";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Ajout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 384);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.livre);
			this.Controls.Add(this.memoire);
			this.Controls.Add(this.these);
			this.Controls.Add(this.theme);
			this.Controls.Add(this.auteur);
			this.Controls.Add(this.titre);
			this.Controls.Add(this.code);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Ajout";
			this.Text = "Ajout";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox code;
		private System.Windows.Forms.TextBox titre;
		private System.Windows.Forms.TextBox auteur;
		private System.Windows.Forms.TextBox theme;
		private System.Windows.Forms.RadioButton these;
		private System.Windows.Forms.RadioButton memoire;
		private System.Windows.Forms.RadioButton livre;
		private System.Windows.Forms.Button button1;
	}
}