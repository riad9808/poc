



using emprentuer.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace emprentuer
{
	public partial class conexionForm : Form
	{
		
		public static string  identite;
		public conexionForm()
		{
			InitializeComponent();
			
			/*	try
				{
					TcpChannel chl = new TcpChannel();
					ChannelServices.RegisterChannel(chl, false);
					Console.WriteLine("Client: Canal enregistré");

					 operation = (IOpEmprenteur)Activator.GetObject(typeof(IOpEmprenteur), "tcp://localhost:1234/objEmprenteur");
				}
				catch (Exception x)
				{ }*/
		}

		private void retour_Click(object sender, EventArgs e)
		{
			homeForm h = new homeForm();
			h.Show();
			this.Hide();
			this.Refresh();
		}

		private void validerConexion_Click(object sender, EventArgs e)
		{
			string id=textBox1.Text;
			string pass = textBox2.Text.ToString();
			if (id == "" || pass == "")
			{
				result.Text = "entrez l'id et le mot de passe ";
				result.ForeColor = Color.Red;
			}
			else
			{
				bool b=false;
				if (etudiant.Checked)
				{
					Etudiant etudiantt = new Etudiant();
					etudiantt.NumCarte = id;
					etudiantt.Password = pass;
				
					try
					{
						ChannelFactory<IService1> channelFactory =
						new ChannelFactory<IService1>("BasicHttpBinding_IService1");
						IService1 operation = channelFactory.CreateChannel();
						operation.sanctionner();
						b = operation.Connexionn(etudiantt);

					}
					catch (Exception ex)
					{

					}
				}
				else
				{
					Ensignant ensi = new Ensignant();
					ensi.Matricule = id;
					ensi.Password = pass;
					try
					{
						ChannelFactory<IService1> channelFactory =
					new ChannelFactory<IService1>("BasicHttpBinding_IService1");
						IService1 operation = channelFactory.CreateChannel();
						operation.sanctionner();
						b = operation.Connexion(ensi);

					}
					catch (Exception ex)
					{

					}
					
				}

			
				Console.WriteLine(b);
				Console.WriteLine("conec");
				if (b)
				{
					identite = id;
					menuForm h = new menuForm();
					h.Show();
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
