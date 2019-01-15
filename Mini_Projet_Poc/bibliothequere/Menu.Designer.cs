namespace bibliothequere
{
	partial class Menu
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.codeBarreRendre = new System.Windows.Forms.TextBox();
			this.emprent = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.idInscription = new System.Windows.Forms.TextBox();
			this.enseignant = new System.Windows.Forms.RadioButton();
			this.etudiant = new System.Windows.Forms.RadioButton();
			this.inscription = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.idConfirmerEmrent = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ajouter = new System.Windows.Forms.Button();
			this.logout = new System.Windows.Forms.Button();
			this.consulter = new System.Windows.Forms.Button();
			this.confirmerEmprent = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.codeBarreRendre);
			this.groupBox1.Controls.Add(this.emprent);
			this.groupBox1.Location = new System.Drawing.Point(43, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rendre un emprent";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "numero d\'emprent";
			// 
			// codeBarreRendre
			// 
			this.codeBarreRendre.Location = new System.Drawing.Point(26, 58);
			this.codeBarreRendre.Name = "codeBarreRendre";
			this.codeBarreRendre.Size = new System.Drawing.Size(100, 20);
			this.codeBarreRendre.TabIndex = 1;
			// 
			// emprent
			// 
			this.emprent.Location = new System.Drawing.Point(119, 85);
			this.emprent.Name = "emprent";
			this.emprent.Size = new System.Drawing.Size(75, 23);
			this.emprent.TabIndex = 0;
			this.emprent.Text = "confirmer";
			this.emprent.UseVisualStyleBackColor = true;
			this.emprent.Click += new System.EventHandler(this.emprent_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.idInscription);
			this.groupBox2.Controls.Add(this.enseignant);
			this.groupBox2.Controls.Add(this.etudiant);
			this.groupBox2.Controls.Add(this.inscription);
			this.groupBox2.Location = new System.Drawing.Point(285, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 114);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Confirmer une inscription";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Matricule/Numero de la carte";
			// 
			// idInscription
			// 
			this.idInscription.Location = new System.Drawing.Point(7, 59);
			this.idInscription.Name = "idInscription";
			this.idInscription.Size = new System.Drawing.Size(100, 20);
			this.idInscription.TabIndex = 3;
			// 
			// enseignant
			// 
			this.enseignant.AutoSize = true;
			this.enseignant.Location = new System.Drawing.Point(99, 20);
			this.enseignant.Name = "enseignant";
			this.enseignant.Size = new System.Drawing.Size(77, 17);
			this.enseignant.TabIndex = 2;
			this.enseignant.TabStop = true;
			this.enseignant.Text = "enseignant";
			this.enseignant.UseVisualStyleBackColor = true;
			// 
			// etudiant
			// 
			this.etudiant.AutoSize = true;
			this.etudiant.Location = new System.Drawing.Point(7, 20);
			this.etudiant.Name = "etudiant";
			this.etudiant.Size = new System.Drawing.Size(63, 17);
			this.etudiant.TabIndex = 1;
			this.etudiant.TabStop = true;
			this.etudiant.Text = "etudiant";
			this.etudiant.UseVisualStyleBackColor = true;
			// 
			// inscription
			// 
			this.inscription.Location = new System.Drawing.Point(119, 85);
			this.inscription.Name = "inscription";
			this.inscription.Size = new System.Drawing.Size(75, 23);
			this.inscription.TabIndex = 0;
			this.inscription.Text = "confirmer";
			this.inscription.UseVisualStyleBackColor = true;
			this.inscription.Click += new System.EventHandler(this.inscription_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.confirmerEmprent);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.idConfirmerEmrent);
			this.groupBox3.Location = new System.Drawing.Point(527, 23);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 114);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Confirmer un emprent";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "numero d\'emprent";
			// 
			// idConfirmerEmrent
			// 
			this.idConfirmerEmrent.Location = new System.Drawing.Point(30, 58);
			this.idConfirmerEmrent.Name = "idConfirmerEmrent";
			this.idConfirmerEmrent.Size = new System.Drawing.Size(100, 20);
			this.idConfirmerEmrent.TabIndex = 1;
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(381, 144);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 186);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(684, 191);
			this.dataGridView1.TabIndex = 4;
			// 
			// ajouter
			// 
			this.ajouter.Location = new System.Drawing.Point(43, 400);
			this.ajouter.Name = "ajouter";
			this.ajouter.Size = new System.Drawing.Size(124, 23);
			this.ajouter.TabIndex = 5;
			this.ajouter.Text = "ajouter un ouvrage";
			this.ajouter.UseVisualStyleBackColor = true;
			this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
			// 
			// logout
			// 
			this.logout.Location = new System.Drawing.Point(646, 400);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(75, 23);
			this.logout.TabIndex = 6;
			this.logout.Text = "Deconexion";
			this.logout.UseVisualStyleBackColor = true;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// consulter
			// 
			this.consulter.Location = new System.Drawing.Point(43, 157);
			this.consulter.Name = "consulter";
			this.consulter.Size = new System.Drawing.Size(75, 23);
			this.consulter.TabIndex = 7;
			this.consulter.Text = "consulter";
			this.consulter.UseVisualStyleBackColor = true;
			this.consulter.Click += new System.EventHandler(this.consulter_Click);
			// 
			// confirmerEmprent
			// 
			this.confirmerEmprent.Location = new System.Drawing.Point(118, 85);
			this.confirmerEmprent.Name = "confirmerEmprent";
			this.confirmerEmprent.Size = new System.Drawing.Size(75, 23);
			this.confirmerEmprent.TabIndex = 3;
			this.confirmerEmprent.Text = "confirmer";
			this.confirmerEmprent.UseVisualStyleBackColor = true;
			this.confirmerEmprent.Click += new System.EventHandler(this.confirmerEmprent_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.consulter);
			this.Controls.Add(this.logout);
			this.Controls.Add(this.ajouter);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.result);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Menu";
			this.Text = "Menu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Button emprent;
		private System.Windows.Forms.Button inscription;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button ajouter;
		private System.Windows.Forms.Button logout;
		private System.Windows.Forms.Button consulter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox idInscription;
		private System.Windows.Forms.RadioButton enseignant;
		private System.Windows.Forms.RadioButton etudiant;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox idConfirmerEmrent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox codeBarreRendre;
		private System.Windows.Forms.Button confirmerEmprent;
	}
}