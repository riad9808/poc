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
	public partial class Ajout : Form
	{
		public Ajout()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string codeb = code.Text;
			string otheme = theme.Text;
			string otitre = titre.Text;
			string oauteur = auteur.Text;
			string type = "";
			if (these.Checked)
			{
				type = "these";
			}else if (livre.Checked)
			{
				type = "livre";
			}else if (memoire.Checked)
			{
				type = "memoire";
			}
			if (codeb == "" || otheme == "" || otitre == "" || oauteur == "")
			{
				result.Text = "remplissez tous le formulaire ";
				result.ForeColor = Color.Red;
			}
			else
			{
				Ouvrage o = new Ouvrage();
				o.Auteur = oauteur;
				o.Theme = otheme;
				o.Titre = otitre;
				o.Type = type;
				o.CodeBarre = Convert.ToInt32(codeb);
				ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
				IService2 operation = channelFactory.CreateChannel();
				bool b = operation.AjouterOuvrage(o);
				if (b)
				{
					result.Text = "succes";
					result.ForeColor = Color.Green;
				}
				else
				{
					result.Text = "Erreur";
					result.ForeColor = Color.Red;
				}
			}

		}
	}
}
