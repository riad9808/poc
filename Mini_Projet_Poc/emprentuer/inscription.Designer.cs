namespace emprentuer
{
	partial class inscription
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
			this.etudiant = new System.Windows.Forms.RadioButton();
			this.enseignant = new System.Windows.Forms.RadioButton();
			this.L1 = new System.Windows.Forms.RadioButton();
			this.L2 = new System.Windows.Forms.RadioButton();
			this.L3 = new System.Windows.Forms.RadioButton();
			this.M1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.niveau = new System.Windows.Forms.GroupBox();
			this.M2 = new System.Windows.Forms.RadioButton();
			this.grade = new System.Windows.Forms.GroupBox();
			this.conference = new System.Windows.Forms.RadioButton();
			this.assistant = new System.Windows.Forms.RadioButton();
			this.specialite = new System.Windows.Forms.GroupBox();
			this.RSD = new System.Windows.Forms.RadioButton();
			this.STIC = new System.Windows.Forms.RadioButton();
			this.SI = new System.Windows.Forms.RadioButton();
			this.GL = new System.Windows.Forms.RadioButton();
			this.MI = new System.Windows.Forms.RadioButton();
			this.stud = new System.Windows.Forms.GroupBox();
			this.id = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.prenom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pwd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pwd2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.retour = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.niveau.SuspendLayout();
			this.grade.SuspendLayout();
			this.specialite.SuspendLayout();
			this.stud.SuspendLayout();
			this.SuspendLayout();
			// 
			// etudiant
			// 
			this.etudiant.AutoSize = true;
			this.etudiant.Location = new System.Drawing.Point(18, 33);
			this.etudiant.Name = "etudiant";
			this.etudiant.Size = new System.Drawing.Size(64, 17);
			this.etudiant.TabIndex = 2;
			this.etudiant.TabStop = true;
			this.etudiant.Text = "Etudiant";
			this.etudiant.UseVisualStyleBackColor = true;
			// 
			// enseignant
			// 
			this.enseignant.AutoSize = true;
			this.enseignant.Location = new System.Drawing.Point(101, 33);
			this.enseignant.Name = "enseignant";
			this.enseignant.Size = new System.Drawing.Size(78, 17);
			this.enseignant.TabIndex = 3;
			this.enseignant.TabStop = true;
			this.enseignant.Text = "Enseignant";
			this.enseignant.UseVisualStyleBackColor = true;
			// 
			// L1
			// 
			this.L1.AutoSize = true;
			this.L1.Location = new System.Drawing.Point(31, 31);
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(37, 17);
			this.L1.TabIndex = 4;
			this.L1.TabStop = true;
			this.L1.Text = "L1";
			this.L1.UseVisualStyleBackColor = true;
			// 
			// L2
			// 
			this.L2.AutoSize = true;
			this.L2.Location = new System.Drawing.Point(31, 54);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(37, 17);
			this.L2.TabIndex = 5;
			this.L2.TabStop = true;
			this.L2.Text = "L2";
			this.L2.UseVisualStyleBackColor = true;
			// 
			// L3
			// 
			this.L3.AutoSize = true;
			this.L3.Location = new System.Drawing.Point(31, 77);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(37, 17);
			this.L3.TabIndex = 6;
			this.L3.TabStop = true;
			this.L3.Text = "L3";
			this.L3.UseVisualStyleBackColor = true;
			// 
			// M1
			// 
			this.M1.AutoSize = true;
			this.M1.Location = new System.Drawing.Point(31, 100);
			this.M1.Name = "M1";
			this.M1.Size = new System.Drawing.Size(40, 17);
			this.M1.TabIndex = 7;
			this.M1.TabStop = true;
			this.M1.Text = "M1";
			this.M1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.etudiant);
			this.groupBox1.Controls.Add(this.enseignant);
			this.groupBox1.Location = new System.Drawing.Point(51, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "vous etes";
			// 
			// niveau
			// 
			this.niveau.Controls.Add(this.M2);
			this.niveau.Controls.Add(this.L1);
			this.niveau.Controls.Add(this.L2);
			this.niveau.Controls.Add(this.M1);
			this.niveau.Controls.Add(this.L3);
			this.niveau.Location = new System.Drawing.Point(33, 19);
			this.niveau.Name = "niveau";
			this.niveau.Size = new System.Drawing.Size(200, 143);
			this.niveau.TabIndex = 9;
			this.niveau.TabStop = false;
			this.niveau.Text = "niveau";
			// 
			// M2
			// 
			this.M2.AutoSize = true;
			this.M2.Location = new System.Drawing.Point(31, 123);
			this.M2.Name = "M2";
			this.M2.Size = new System.Drawing.Size(40, 17);
			this.M2.TabIndex = 8;
			this.M2.TabStop = true;
			this.M2.Text = "M2";
			this.M2.UseVisualStyleBackColor = true;
			// 
			// grade
			// 
			this.grade.Controls.Add(this.conference);
			this.grade.Controls.Add(this.assistant);
			this.grade.Location = new System.Drawing.Point(289, 12);
			this.grade.Name = "grade";
			this.grade.Size = new System.Drawing.Size(200, 100);
			this.grade.TabIndex = 10;
			this.grade.TabStop = false;
			this.grade.Text = "grade";
			// 
			// conference
			// 
			this.conference.AutoSize = true;
			this.conference.Location = new System.Drawing.Point(18, 66);
			this.conference.Name = "conference";
			this.conference.Size = new System.Drawing.Size(110, 17);
			this.conference.TabIndex = 1;
			this.conference.TabStop = true;
			this.conference.Text = "maitre conference";
			this.conference.UseVisualStyleBackColor = true;
			// 
			// assistant
			// 
			this.assistant.AutoSize = true;
			this.assistant.Location = new System.Drawing.Point(18, 35);
			this.assistant.Name = "assistant";
			this.assistant.Size = new System.Drawing.Size(92, 17);
			this.assistant.TabIndex = 0;
			this.assistant.TabStop = true;
			this.assistant.Text = "maitre assitant";
			this.assistant.UseVisualStyleBackColor = true;
			// 
			// specialite
			// 
			this.specialite.Controls.Add(this.RSD);
			this.specialite.Controls.Add(this.STIC);
			this.specialite.Controls.Add(this.SI);
			this.specialite.Controls.Add(this.GL);
			this.specialite.Controls.Add(this.MI);
			this.specialite.Location = new System.Drawing.Point(286, 18);
			this.specialite.Name = "specialite";
			this.specialite.Size = new System.Drawing.Size(200, 144);
			this.specialite.TabIndex = 11;
			this.specialite.TabStop = false;
			this.specialite.Text = "specialite";
			// 
			// RSD
			// 
			this.RSD.AutoSize = true;
			this.RSD.Location = new System.Drawing.Point(15, 114);
			this.RSD.Name = "RSD";
			this.RSD.Size = new System.Drawing.Size(48, 17);
			this.RSD.TabIndex = 4;
			this.RSD.TabStop = true;
			this.RSD.Text = "RSD";
			this.RSD.UseVisualStyleBackColor = true;
			// 
			// STIC
			// 
			this.STIC.AutoSize = true;
			this.STIC.Location = new System.Drawing.Point(15, 90);
			this.STIC.Name = "STIC";
			this.STIC.Size = new System.Drawing.Size(49, 17);
			this.STIC.TabIndex = 3;
			this.STIC.TabStop = true;
			this.STIC.Text = "STIC";
			this.STIC.UseVisualStyleBackColor = true;
			// 
			// SI
			// 
			this.SI.AutoSize = true;
			this.SI.Location = new System.Drawing.Point(15, 67);
			this.SI.Name = "SI";
			this.SI.Size = new System.Drawing.Size(35, 17);
			this.SI.TabIndex = 2;
			this.SI.TabStop = true;
			this.SI.Text = "SI";
			this.SI.UseVisualStyleBackColor = true;
			// 
			// GL
			// 
			this.GL.AutoSize = true;
			this.GL.Location = new System.Drawing.Point(15, 43);
			this.GL.Name = "GL";
			this.GL.Size = new System.Drawing.Size(39, 17);
			this.GL.TabIndex = 1;
			this.GL.TabStop = true;
			this.GL.Text = "GL";
			this.GL.UseVisualStyleBackColor = true;
			// 
			// MI
			// 
			this.MI.AutoSize = true;
			this.MI.Location = new System.Drawing.Point(15, 19);
			this.MI.Name = "MI";
			this.MI.Size = new System.Drawing.Size(37, 17);
			this.MI.TabIndex = 0;
			this.MI.TabStop = true;
			this.MI.Text = "MI";
			this.MI.UseVisualStyleBackColor = true;
			// 
			// stud
			// 
			this.stud.Controls.Add(this.specialite);
			this.stud.Controls.Add(this.niveau);
			this.stud.Location = new System.Drawing.Point(51, 118);
			this.stud.Name = "stud";
			this.stud.Size = new System.Drawing.Size(506, 184);
			this.stud.TabIndex = 12;
			this.stud.TabStop = false;
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(69, 329);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(100, 20);
			this.id.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 309);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Matricule";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(321, 309);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "prenom";
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(195, 329);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(100, 20);
			this.nom.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(195, 313);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "nom";
			// 
			// prenom
			// 
			this.prenom.Location = new System.Drawing.Point(324, 329);
			this.prenom.Name = "prenom";
			this.prenom.Size = new System.Drawing.Size(100, 20);
			this.prenom.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 368);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "mot de passe";
			// 
			// pwd
			// 
			this.pwd.Location = new System.Drawing.Point(69, 388);
			this.pwd.Name = "pwd";
			this.pwd.PasswordChar = '*';
			this.pwd.Size = new System.Drawing.Size(100, 20);
			this.pwd.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(192, 368);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "confirmer le mot de passe";
			// 
			// pwd2
			// 
			this.pwd2.Location = new System.Drawing.Point(195, 388);
			this.pwd2.Name = "pwd2";
			this.pwd2.PasswordChar = '*';
			this.pwd2.Size = new System.Drawing.Size(100, 20);
			this.pwd2.TabIndex = 21;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(349, 388);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 23;
			this.button1.Text = "valider";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(223, 425);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 24;
			// 
			// retour
			// 
			this.retour.Location = new System.Drawing.Point(561, 33);
			this.retour.Name = "retour";
			this.retour.Size = new System.Drawing.Size(75, 23);
			this.retour.TabIndex = 25;
			this.retour.Text = "retour";
			this.retour.UseVisualStyleBackColor = true;
			this.retour.Click += new System.EventHandler(this.retour_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(461, 313);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 26;
			this.label6.Text = "email";
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(464, 328);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(100, 20);
			this.email.TabIndex = 27;
			// 
			// inscription
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.email);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.retour);
			this.Controls.Add(this.result);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pwd2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.prenom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.id);
			this.Controls.Add(this.stud);
			this.Controls.Add(this.grade);
			this.Controls.Add(this.groupBox1);
			this.Name = "inscription";
			this.Text = "inscription";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.niveau.ResumeLayout(false);
			this.niveau.PerformLayout();
			this.grade.ResumeLayout(false);
			this.grade.PerformLayout();
			this.specialite.ResumeLayout(false);
			this.specialite.PerformLayout();
			this.stud.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton etudiant;
		private System.Windows.Forms.RadioButton enseignant;
		private System.Windows.Forms.RadioButton L1;
		private System.Windows.Forms.RadioButton L2;
		private System.Windows.Forms.RadioButton L3;
		private System.Windows.Forms.RadioButton M1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox niveau;
		private System.Windows.Forms.RadioButton M2;
		private System.Windows.Forms.GroupBox grade;
		private System.Windows.Forms.RadioButton conference;
		private System.Windows.Forms.RadioButton assistant;
		private System.Windows.Forms.GroupBox specialite;
		private System.Windows.Forms.RadioButton RSD;
		private System.Windows.Forms.RadioButton STIC;
		private System.Windows.Forms.RadioButton SI;
		private System.Windows.Forms.RadioButton GL;
		private System.Windows.Forms.RadioButton MI;
		private System.Windows.Forms.GroupBox stud;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox prenom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox pwd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox pwd2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Button retour;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox email;
	}
}