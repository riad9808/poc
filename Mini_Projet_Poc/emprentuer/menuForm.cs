using emprentuer.ServiceReference1;

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
	public partial class menuForm : Form
	{
		//static IOpEmprenteur operation;

		public menuForm()
		{
			InitializeComponent();
			/*try
			{
				TcpChannel chl = new TcpChannel();
				ChannelServices.RegisterChannel(chl, false);
				Console.WriteLine("Client: Canal enregistré");

				operation = (IOpEmprenteur)Activator.GetObject(typeof(IOpEmprenteur), "tcp://localhost:1234/objEmprenteur");

				//CurrencyManager currencyManager = null;

				//currencyManager = (CurrencyManager) dataGridView1.BindingContext[operation.Consulter()];
			}
			catch (Exception exec) { }*/
		}

		private void changemdp_Click(object sender, EventArgs e)
		{
			string pd1 = pass1.Text.ToString();
			string pd2 = pass2.Text.ToString();
			if (!pd1.Equals(pd2))
			{
				result.Text = "verifier votre mot de passe ";
				result.ForeColor = Color.Red;
			}
			else
			{
				Etudiant etudiant_1 = new Etudiant();
				etudiant_1.NumCarte = conexionForm.identite;
				etudiant_1.Password = pd1;
				ChannelFactory<IService1> channelFactory =
						   new ChannelFactory<IService1>("BasicHttpBinding_IService1");
				IService1 operation = channelFactory.CreateChannel();
				bool b = operation.ModifierMotPass(etudiant_1);
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				ChannelFactory<IService1> channelFactory =
						   new ChannelFactory<IService1>("BasicHttpBinding_IService1");
				IService1 operation = channelFactory.CreateChannel();
				
				Console.WriteLine(operation.Consulter().Count);
				var bindingList = new BindingList<Ouvrage>(operation.Consulter());
				var source = new BindingSource(bindingList, null);
				dataGridView1.DataSource = source;
				
				

			}
			catch (Exception x)
			{ }
			
		}
	

		

		private void louer_Click(object sender, EventArgs e)
		{
			//var a=dataGridView1.SelectedRows[0].Index;
			var codebare=dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
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
			int b = operation.Reserver(oe);
			Console.WriteLine(b);
			if (b==0)
			{
				result.Text = "vous avez étè ajouter a la liste d'attente ";
				result.ForeColor = Color.Blue;
				
			}
			else
			{
				result.Text = "reservation effectuer votre numero d'emprent est : "+b;
				result.ForeColor = Color.Green;
			}
			
		}

		private void logout_Click(object sender, EventArgs e)
		{
			homeForm h = new homeForm();
			h.Show();
			this.Hide();
			this.Refresh();
		}

		private void recherche_Click(object sender, EventArgs e)
		{
			rechercherForm r = new rechercherForm();
			r.Show();
		}
	}
}
