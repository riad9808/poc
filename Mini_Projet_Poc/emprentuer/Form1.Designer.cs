namespace emprentuer
{
	partial class homeForm
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
			this.conexion = new System.Windows.Forms.Button();
			this.inscription = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// conexion
			// 
			this.conexion.Location = new System.Drawing.Point(299, 71);
			this.conexion.Name = "conexion";
			this.conexion.Size = new System.Drawing.Size(146, 73);
			this.conexion.TabIndex = 0;
			this.conexion.Text = "conexion";
			this.conexion.UseVisualStyleBackColor = true;
			this.conexion.Click += new System.EventHandler(this.conexion_Click);
			// 
			// inscription
			// 
			this.inscription.Location = new System.Drawing.Point(299, 179);
			this.inscription.Name = "inscription";
			this.inscription.Size = new System.Drawing.Size(146, 73);
			this.inscription.TabIndex = 1;
			this.inscription.Text = "inscription";
			this.inscription.UseVisualStyleBackColor = true;
			this.inscription.Click += new System.EventHandler(this.inscription_Click);
			// 
			// homeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inscription);
			this.Controls.Add(this.conexion);
			this.Name = "homeForm";
			this.Text = "Acceuil";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button conexion;
		private System.Windows.Forms.Button inscription;
	}
}

