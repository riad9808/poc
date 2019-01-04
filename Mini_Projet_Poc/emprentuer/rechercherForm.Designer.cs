namespace emprentuer
{
	partial class rechercherForm
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
			this.livre = new System.Windows.Forms.RadioButton();
			this.memoire = new System.Windows.Forms.RadioButton();
			this.these = new System.Windows.Forms.RadioButton();
			this.vide = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.titre = new System.Windows.Forms.TextBox();
			this.auteur = new System.Windows.Forms.TextBox();
			this.theme = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.loue = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// livre
			// 
			this.livre.AutoSize = true;
			this.livre.Location = new System.Drawing.Point(23, 42);
			this.livre.Name = "livre";
			this.livre.Size = new System.Drawing.Size(44, 17);
			this.livre.TabIndex = 0;
			this.livre.TabStop = true;
			this.livre.Text = "livre";
			this.livre.UseVisualStyleBackColor = true;
			// 
			// memoire
			// 
			this.memoire.AutoSize = true;
			this.memoire.Location = new System.Drawing.Point(23, 66);
			this.memoire.Name = "memoire";
			this.memoire.Size = new System.Drawing.Size(64, 17);
			this.memoire.TabIndex = 1;
			this.memoire.TabStop = true;
			this.memoire.Text = "memoire";
			this.memoire.UseVisualStyleBackColor = true;
			// 
			// these
			// 
			this.these.AutoSize = true;
			this.these.Location = new System.Drawing.Point(23, 90);
			this.these.Name = "these";
			this.these.Size = new System.Drawing.Size(51, 17);
			this.these.TabIndex = 2;
			this.these.TabStop = true;
			this.these.Text = "these";
			this.these.UseVisualStyleBackColor = true;
			// 
			// vide
			// 
			this.vide.AutoSize = true;
			this.vide.Location = new System.Drawing.Point(23, 19);
			this.vide.Name = "vide";
			this.vide.Size = new System.Drawing.Size(85, 17);
			this.vide.TabIndex = 3;
			this.vide.TabStop = true;
			this.vide.Text = "non specifier";
			this.vide.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.vide);
			this.groupBox1.Controls.Add(this.livre);
			this.groupBox1.Controls.Add(this.these);
			this.groupBox1.Controls.Add(this.memoire);
			this.groupBox1.Location = new System.Drawing.Point(59, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 116);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "type";
			// 
			// titre
			// 
			this.titre.Location = new System.Drawing.Point(309, 65);
			this.titre.Name = "titre";
			this.titre.Size = new System.Drawing.Size(100, 20);
			this.titre.TabIndex = 5;
			// 
			// auteur
			// 
			this.auteur.Location = new System.Drawing.Point(462, 65);
			this.auteur.Name = "auteur";
			this.auteur.Size = new System.Drawing.Size(100, 20);
			this.auteur.TabIndex = 6;
			// 
			// theme
			// 
			this.theme.Location = new System.Drawing.Point(604, 65);
			this.theme.Name = "theme";
			this.theme.Size = new System.Drawing.Size(100, 20);
			this.theme.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(309, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "titre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(462, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "auteur";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(604, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "theme";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(607, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "rechercher";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(59, 180);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(645, 150);
			this.dataGridView1.TabIndex = 12;
			// 
			// loue
			// 
			this.loue.Location = new System.Drawing.Point(711, 208);
			this.loue.Name = "loue";
			this.loue.Size = new System.Drawing.Size(75, 23);
			this.loue.TabIndex = 13;
			this.loue.Text = "reserver";
			this.loue.UseVisualStyleBackColor = true;
			this.loue.Click += new System.EventHandler(this.loue_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(343, 145);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 14;
			// 
			// rechercherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.result);
			this.Controls.Add(this.loue);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.theme);
			this.Controls.Add(this.auteur);
			this.Controls.Add(this.titre);
			this.Controls.Add(this.groupBox1);
			this.Name = "rechercherForm";
			this.Text = "rechercherForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton livre;
		private System.Windows.Forms.RadioButton memoire;
		private System.Windows.Forms.RadioButton these;
		private System.Windows.Forms.RadioButton vide;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox titre;
		private System.Windows.Forms.TextBox auteur;
		private System.Windows.Forms.TextBox theme;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button loue;
		private System.Windows.Forms.Label result;
	}
}