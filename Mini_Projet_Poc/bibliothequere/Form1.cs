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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string i = id.Text;
			string pwd = pass.Text.ToString();

			if (i == "" || pwd == "")
			{
				result.Text = "remplissez tous le formulaire ";
				result.ForeColor = Color.Red;
			}
			else
			{
				ChannelFactory<IService2> channelFactory =
					   new ChannelFactory<IService2>("BasicHttpBinding_IService2");
				IService2 operation = channelFactory.CreateChannel();
				Bibliothequer b = new Bibliothequer();
				b.Id = i;
				b.Password = pwd;
				
				bool bo = operation.Connexion(b);
				Console.WriteLine(b.Id);
				Console.WriteLine(b.Password);


				if (bo)
				{
					Menu ins = new Menu();
					ins.Show();
					this.Hide();
				}
				else
				{
					
					result.Text = "erreur ";
					result.ForeColor = Color.Red;
				}

			}
			
		}
	}
}
