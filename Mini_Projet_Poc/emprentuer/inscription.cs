using emprentuer.ServiceReference1;

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
	public partial class inscription : Form
	{
	//	public static IOpEmprenteur operation;
		public inscription()
		{

			InitializeComponent();
		/*	try
			{
				System.Runtime.Remoting.Channels.Tcp.TcpChannel chl = new System.Runtime.Remoting.Channels.Tcp.TcpChannel();
				System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(chl, false);
				Console.WriteLine("Client: Canal enregistré");

				 operation = (IOpEmprenteur)Activator.GetObject(typeof(IOpEmprenteur), "tcp://localhost:1234/objEmprenteur");
			}
			catch (Exception exec) { }*/

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool b = false;
			int x = 1;
			string type = "";
			string niveau = "";
			string specialite = "";
			string grade="";
			if (etudiant.Checked)
			{
				
				type = "etudiant";
				if (L1.Checked)
					niveau = "L1";
				else if (L2.Checked)
					niveau = "L2";
				else if (L3.Checked)
					niveau = "L3";
				else if (M1.Checked)
					niveau = "M1";
				else if (M2.Checked)
					niveau = "M2";
				if (MI.Checked)
					specialite = "MI";
				else if (GL.Checked)
					specialite = "GL";
				else if (SI.Checked)
					specialite = "SI";
				else if (STIC.Checked)
					specialite = "STIC";
				else if (RSD.Checked)
					specialite = "RSD";

				if (specialite == "" || niveau == "")
				{
					x = 0;
				}

			}
			else
			{
				type = "enseignant";

				if (assistant.Checked)
					grade = "maitre assistant";
				else if (conference.Checked)
					grade = "maitre conference";
				if (grade == "" )
				{
					x = 0;
				}


			}
			string name = nom.Text;
			string iden = id.Text;
			string pren = prenom.Text;
			string mail = email.Text;
			string pass = pwd.Text.ToString();
			string pass2 = pwd2.Text.ToString();

			if(name ==""|| iden == "" || pren == "" || pass == "" || pass2 =="" || mail == "" )
			{
				x = 0;	
			}
			if (!pass.Equals(pass2))
			{
				x = 3;
			}
			if (x == 0)
			{
				result.Text = "Remplissez le formualire ";
				result.ForeColor = Color.Red;
			}
			else
			{
				if(x==3)
				{
					result.Text = "verifier le mot de passe ";
					result.ForeColor = Color.Red;
				}
				else
				{
					


						Ensignant ensignant = new Ensignant();
						Etudiant etudiant = new Etudiant();
						if (type == "etudiant")
						{
							etudiant.Nom = name;
							etudiant.Prenom = pren;
							etudiant.NumCarte = iden;
							etudiant.Specialite = specialite;
							etudiant.Niveau = niveau;
							etudiant.Password = pass;
							etudiant.Email = mail;

						ChannelFactory<IService1> channelFactory =
						new ChannelFactory<IService1>("BasicHttpBinding_IService1");
						IService1 operation = channelFactory.CreateChannel();
						b =operation.CreeComptee(etudiant);
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
							ensignant.Nom = name;
							ensignant.Prenom = pren;
							ensignant.Matricule = iden;
							ensignant.Grade = grade;
							ensignant.Password = pass;
							ensignant.Email = mail;

						ChannelFactory<IService1> channelFactory =
						new ChannelFactory<IService1>("BasicHttpBinding_IService1");
						IService1 operation = channelFactory.CreateChannel();
						b =operation.CreeCompte(ensignant);
							if (b)
							{
								result.Text = "succes ";
								result.ForeColor = Color.Green;
								inscription ii = new inscription();
								ii.Show();
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

			

			
			//Console.WriteLine(type + specialite + niveau + name + pren + iden + pwd + pwd2);

		}

		private void retour_Click(object sender, EventArgs e)
		{
			homeForm h = new homeForm();
			h.Show();
			
			this.Hide();

		}
	}
}
