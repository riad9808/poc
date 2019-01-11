using bibliothequere.ServiceReference1;
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

namespace bibliothequere
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void emprent_Click(object sender, EventArgs e)
		{
			if (codeBarreRendre.Text == "")
			{
				result.Text = "Remplissez le formulaire ";
				result.ForeColor = Color.Red;
			}
			else
			{
				string a = codeBarreRendre.Text;
				ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
				IService2 operation = channelFactory.CreateChannel();
				OuvrageEmprent o = new OuvrageEmprent();
				o.CodeBarre = Convert.ToInt32(a);
				bool b = operation.RendreEmprent(o);
				if (b)
				{
					result.Text = "succes ";
					result.ForeColor = Color.Green;
				}
				else
				{
					result.Text = "erreur ";
					result.ForeColor = Color.Red;
				}
			}
		}
		private void inscription_Click(object sender, EventArgs e)
		{
			if (idInscription.Text == "")
			{
				result.Text = "Remplissez le formulaire ";
				result.ForeColor = Color.Red;
			}
			else
			{
				string type = "";
				if (etudiant.Checked)
				{
					type = "etudiant";
				}
				if (enseignant.Checked)
				{
					type = "ensignant";
				}
				string matri = idInscription.Text;
				if (type == "etudiant")
				{
					Etudiant etud = new Etudiant();
					etud.NumCarte = matri;
					ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
					IService2 operation = channelFactory.CreateChannel();
					bool b = operation.ConfirmerComptee(etud);
					if (b)
					{
						result.Text = "succes ";
						result.ForeColor = Color.Green;
					}
					else
					{
						result.Text = "erreur ";
						result.ForeColor = Color.Red;
					}
				}
				else
				{
					Ensignant ens = new Ensignant();
					ens.Matricule = matri;
					ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
					IService2 operation = channelFactory.CreateChannel();
					bool b = operation.ConfirmerCompte(ens);
					if (b)
					{
						result.Text = "succes ";
						result.ForeColor = Color.Green;
					}
					else
					{
						result.Text = "erreur ";
						result.ForeColor = Color.Red;
					}
				}
			}
		}

		private void Rendre_Click(object sender, EventArgs e)
		{
			if (idConfirmerEmrent.Text == "")
			{
				result.Text = "Remplissez le formulaire ";
				result.ForeColor = Color.Red;
			}
			else
			{


				string i = idConfirmerEmrent.Text;
				ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
				IService2 operation = channelFactory.CreateChannel();
				OuvrageEmprent o = new OuvrageEmprent();
				o.Id = i;
				bool b=operation.RendreEmprent(o);
				if (b)
				{
					result.Text = "succes ";
					result.ForeColor = Color.Green;
				}
				else
				{
					result.Text = "erreur ";
					result.ForeColor = Color.Red;
				}
			}
		}

		private void logout_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			this.Hide();
		}

		private void consulter_Click(object sender, EventArgs e)
		{
			try
			{
				ChannelFactory<IService2> channelFactory =
						   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
				IService2 operation = channelFactory.CreateChannel();

				Console.WriteLine(operation.Consulter().Count);
				var bindingList = new BindingList<Ouvrage>(operation.Consulter());
				var source = new BindingSource(bindingList, null);
				dataGridView1.DataSource = source;



			}
			catch (Exception x)
			{ }
		}

		private void ajouter_Click(object sender, EventArgs e)
		{
			Ajout a = new Ajout();
			a.Show();
			
		}
	}
}
