using emprentuer.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emprentuer
{
	public partial class rechercherForm : Form
	{
		public rechercherForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Ouvrage ouvrage = new Ouvrage();

			if (vide.Checked)
			{
				ouvrage.Type = null;
			}
			
			if (livre.Checked)
			{
				ouvrage.Type = "livre";
			}
				
			if (these.Checked)
			{
				ouvrage.Type = "these";
			}
					
			if (memoire.Checked)
			{
				ouvrage.Type = "memoire";
			}

			
			if (titre.Text == "")
			{
				ouvrage.Titre = null;
			}
			else
			{
				ouvrage.Titre = titre.Text;
			}
			if (theme.Text == "")
			{
				ouvrage.Theme = null;
			}
			else
			{
				ouvrage.Theme = theme.Text;
			}
			if (auteur.Text == "")
			{
				ouvrage.Auteur = null;
			}
			else
			{
				ouvrage.Auteur = auteur.Text;
			}

			ChannelFactory<IService1> channelFactory =
					   new ChannelFactory<IService1>("BasicHttpBinding_IService1");
			IService1 operation = channelFactory.CreateChannel();
			var bindingList = new BindingList<Ouvrage>(operation.Recherche(ouvrage));
			Console.WriteLine(operation.Recherche(ouvrage).Count);
			var source = new BindingSource(bindingList, null);
			dataGridView1.Rows.Clear();
			dataGridView1.DataSource = source;
		}

		private void loue_Click(object sender, EventArgs e)
		{
			var codebare = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
			string id = conexionForm.identite;
			OuvrageEmprent oe = new OuvrageEmprent();
			oe.CodeBarre = Convert.ToInt32(codebare);

			oe.Id = id;
			Console.WriteLine(oe.CodeBarre);
			Console.WriteLine(oe.Id);
			DateTime dateTime = DateTime.Today;
			oe.DateEmprent = dateTime.Date;
			Console.WriteLine(oe.DateEmprent);
			ChannelFactory<IService1> channelFactory =
						   new ChannelFactory<IService1>("BasicHttpBinding_IService1");
			IService1 operation = channelFactory.CreateChannel();
			bool b = operation.Reserver(oe);
			if (b)
			{
				result.Text = "reservation effectuer ";
				result.ForeColor = Color.Green;
			}
			else
			{
				result.Text = "vous avez étè ajouter a la liste d'attente ";
				result.ForeColor = Color.Blue;
			}
		}
	}
}
