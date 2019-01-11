using emprentuer.ServiceReference2;

namespace emprentuer
{
	partial class menuForm
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
			this.components = new System.ComponentModel.Container();
			this.changemdp = new System.Windows.Forms.Button();
			this.pass1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pass2 = new System.Windows.Forms.TextBox();
			this.logout = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codeBarreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.auteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.etatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.louer = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.recherche = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuFormBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// changemdp
			// 
			this.changemdp.Location = new System.Drawing.Point(283, 30);
			this.changemdp.Name = "changemdp";
			this.changemdp.Size = new System.Drawing.Size(138, 23);
			this.changemdp.TabIndex = 0;
			this.changemdp.Text = "modifier le mot de passe";
			this.changemdp.UseVisualStyleBackColor = true;
			this.changemdp.Click += new System.EventHandler(this.changemdp_Click);
			// 
			// pass1
			// 
			this.pass1.Location = new System.Drawing.Point(30, 33);
			this.pass1.Name = "pass1";
			this.pass1.Size = new System.Drawing.Size(100, 20);
			this.pass1.TabIndex = 2;
			this.pass1.PasswordChar = '*';
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pass2);
			this.groupBox1.Controls.Add(this.pass1);
			this.groupBox1.Controls.Add(this.changemdp);
			this.groupBox1.Location = new System.Drawing.Point(72, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(427, 71);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modifier le mot de passe";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "confirmer le mot de passe";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Entrez le mot de passe";
			// 
			// pass2
			// 
			this.pass2.Location = new System.Drawing.Point(168, 32);
			this.pass2.Name = "pass2";
			this.pass2.Size = new System.Drawing.Size(100, 20);
			this.pass2.TabIndex = 3;
			this.pass2.PasswordChar = '*';

			// 
			// logout
			// 
			this.logout.Location = new System.Drawing.Point(713, 41);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(75, 23);
			this.logout.TabIndex = 4;
			this.logout.Text = "Deconexion";
			this.logout.UseVisualStyleBackColor = true;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "cosnulter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn,
            this.codeBarreDataGridViewTextBoxColumn,
            this.auteurDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.etatDataGridViewCheckBoxColumn});
			this.dataGridView1.DataSource = this.ouvrageBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(72, 119);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(641, 273);
			this.dataGridView1.TabIndex = 1;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// themeDataGridViewTextBoxColumn
			// 
			this.themeDataGridViewTextBoxColumn.DataPropertyName = "Theme";
			this.themeDataGridViewTextBoxColumn.HeaderText = "Theme";
			this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
			// 
			// codeBarreDataGridViewTextBoxColumn
			// 
			this.codeBarreDataGridViewTextBoxColumn.DataPropertyName = "CodeBarre";
			this.codeBarreDataGridViewTextBoxColumn.HeaderText = "CodeBarre";
			this.codeBarreDataGridViewTextBoxColumn.Name = "codeBarreDataGridViewTextBoxColumn";
			// 
			// auteurDataGridViewTextBoxColumn
			// 
			this.auteurDataGridViewTextBoxColumn.DataPropertyName = "Auteur";
			this.auteurDataGridViewTextBoxColumn.HeaderText = "Auteur";
			this.auteurDataGridViewTextBoxColumn.Name = "auteurDataGridViewTextBoxColumn";
			// 
			// titreDataGridViewTextBoxColumn
			// 
			this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
			this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
			this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
			// 
			// etatDataGridViewCheckBoxColumn
			// 
			this.etatDataGridViewCheckBoxColumn.DataPropertyName = "Etat";
			this.etatDataGridViewCheckBoxColumn.HeaderText = "Etat";
			this.etatDataGridViewCheckBoxColumn.Name = "etatDataGridViewCheckBoxColumn";
			// 
			// ouvrageBindingSource
			// 
			this.ouvrageBindingSource.DataSource = typeof(emprentuer.ServiceReference2.Ouvrage);
			// 
			// menuFormBindingSource
			// 
			this.menuFormBindingSource.DataSource = typeof(emprentuer.menuForm);
			// 
			// louer
			// 
			this.louer.Location = new System.Drawing.Point(719, 155);
			this.louer.Name = "louer";
			this.louer.Size = new System.Drawing.Size(75, 23);
			this.louer.TabIndex = 6;
			this.louer.Text = "reserver";
			this.louer.UseVisualStyleBackColor = true;
			this.louer.Click += new System.EventHandler(this.louer_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(304, 90);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 13);
			this.result.TabIndex = 7;
			// 
			// recherche
			// 
			this.recherche.Location = new System.Drawing.Point(719, 200);
			this.recherche.Name = "recherche";
			this.recherche.Size = new System.Drawing.Size(75, 23);
			this.recherche.TabIndex = 8;
			this.recherche.Text = "rechercher";
			this.recherche.UseVisualStyleBackColor = true;
			this.recherche.Click += new System.EventHandler(this.recherche_Click);
			// 
			// menuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.recherche);
			this.Controls.Add(this.result);
			this.Controls.Add(this.louer);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.logout);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "menuForm";
			this.Text = "Menu";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuFormBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button changemdp;
		private System.Windows.Forms.TextBox pass1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox pass2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button logout;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource menuFormBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeBarreDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn etatDataGridViewCheckBoxColumn;
		private System.Windows.Forms.BindingSource ouvrageBindingSource;
		private System.Windows.Forms.Button louer;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Button recherche;
	}
}