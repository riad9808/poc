namespace bibliothequere
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.id = new System.Windows.Forms.TextBox();
			this.pass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(98, 99);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(162, 20);
			this.id.TabIndex = 0;
			// 
			// pass
			// 
			this.pass.Location = new System.Drawing.Point(98, 189);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '*';
			this.pass.Size = new System.Drawing.Size(162, 20);
			this.pass.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(98, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "valider";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(157, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(140, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mot de passe";
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(157, 234);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 358);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.id);
			this.Name = "Form1";
			this.Text = "bibliotheque";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label result;
	}
}

