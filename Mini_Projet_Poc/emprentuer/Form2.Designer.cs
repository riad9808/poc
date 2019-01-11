namespace emprentuer
{
	partial class conexionForm
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
			this.validerConexion = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.retour = new System.Windows.Forms.Button();
			this.etudiant = new System.Windows.Forms.RadioButton();
			this.ensignant = new System.Windows.Forms.RadioButton();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// validerConexion
			// 
			this.validerConexion.Location = new System.Drawing.Point(46, 273);
			this.validerConexion.Name = "validerConexion";
			this.validerConexion.Size = new System.Drawing.Size(178, 23);
			this.validerConexion.TabIndex = 0;
			this.validerConexion.Text = "conexion";
			this.validerConexion.UseVisualStyleBackColor = true;
			this.validerConexion.Click += new System.EventHandler(this.validerConexion_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(46, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(178, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(46, 182);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(178, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mot de passe";
			// 
			// retour
			// 
			this.retour.Location = new System.Drawing.Point(12, 12);
			this.retour.Name = "retour";
			this.retour.Size = new System.Drawing.Size(75, 23);
			this.retour.TabIndex = 5;
			this.retour.Text = "retour";
			this.retour.UseVisualStyleBackColor = true;
			this.retour.Click += new System.EventHandler(this.retour_Click);
			// 
			// etudiant
			// 
			this.etudiant.AutoSize = true;
			this.etudiant.Location = new System.Drawing.Point(46, 69);
			this.etudiant.Name = "etudiant";
			this.etudiant.Size = new System.Drawing.Size(63, 17);
			this.etudiant.TabIndex = 6;
			this.etudiant.TabStop = true;
			this.etudiant.Text = "etudiant";
			this.etudiant.UseVisualStyleBackColor = true;
			// 
			// ensignant
			// 
			this.ensignant.AutoSize = true;
			this.ensignant.Location = new System.Drawing.Point(138, 69);
			this.ensignant.Name = "ensignant";
			this.ensignant.Size = new System.Drawing.Size(77, 17);
			this.ensignant.TabIndex = 7;
			this.ensignant.TabStop = true;
			this.ensignant.Text = "enseignant";
			this.ensignant.UseVisualStyleBackColor = true;
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(46, 229);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 8;
			// 
			// conexionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 342);
			this.Controls.Add(this.result);
			this.Controls.Add(this.ensignant);
			this.Controls.Add(this.etudiant);
			this.Controls.Add(this.retour);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.validerConexion);
			this.Name = "conexionForm";
			this.Text = "conexion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button validerConexion;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button retour;
		private System.Windows.Forms.RadioButton etudiant;
		private System.Windows.Forms.RadioButton ensignant;
		private System.Windows.Forms.Label result;
	}
}