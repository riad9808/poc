using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf
{
	// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service2" à la fois dans le code, le fichier svc et le fichier de configuration.
	// REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service2.svc ou Service2.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
	public class Service2 : IService2
	{
		public List<Etudiant> ListEtudiant()
		{
			List<Etudiant> etudiant = new List<Etudiant>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from emprenteur where type='etudiant' ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					Etudiant e = new Etudiant();
					e.NumCarte = rd["matricule"].ToString();
					e.Nom = rd["nom"].ToString();
					e.Prenom = rd["prenom"].ToString();
					e.Password = rd["password"].ToString();
					e.Sanction = Convert.ToDateTime(rd["sanction"]);
					e.EtatSanction = Convert.ToBoolean(rd["etatsanction"]);
					e.EtatCompte = Convert.ToBoolean(rd["etatcompte"]);
					e.NbNonReserve = int.Parse(rd["nonConfirme"].ToString());
					e.Specialite = rd["specialite"].ToString();
					e.Niveau = rd["niveau"].ToString();
					e.Email = rd["email"].ToString();
					etudiant.Add(e);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return etudiant;
		}




		public List<Ensignant> ListEnsignant()
		{
			List<Ensignant> ensignant = new List<Ensignant>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from emprenteur where type='ensignant' ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					Ensignant e = new Ensignant();
					e.Matricule = rd["matricule"].ToString();
					e.Nom = rd["nom"].ToString();
					e.Prenom = rd["prenom"].ToString();
					e.Password = rd["password"].ToString();
					e.Sanction = Convert.ToDateTime(rd["sanction"]);
					e.EtatSanction = Convert.ToBoolean(rd["etatsanction"]);
					e.EtatCompte = Convert.ToBoolean(rd["etatcompte"]);
					e.NbNonReserve = int.Parse(rd["nonConfirme"].ToString());
					e.Grade = rd["grade"].ToString();
					e.Email = rd["email"].ToString();
					ensignant.Add(e);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return ensignant;
		}




		public List<Bibliothequer> ListBibliothequeur()
		{
			List<Bibliothequer> bibliothequeur = new List<Bibliothequer>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from bibliothequeur ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					Bibliothequer b = new Bibliothequer();
					b.Id = rd["id"].ToString();
					b.Password = rd["password"].ToString();

					bibliothequeur.Add(b);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return bibliothequeur;
		}




		public List<Ouvrage> ListOuvrage()
		{
			List<Ouvrage> ouvrage = new List<Ouvrage>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from ouvrage ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					Ouvrage o = new Ouvrage();
					o.CodeBarre = int.Parse(rd["codebare"].ToString());
					o.Type = rd["type"].ToString();
					o.Theme = rd["theme"].ToString();
					o.Titre = rd["titre"].ToString();
					o.Auteur = rd["auteur"].ToString();
					o.Etat = Convert.ToBoolean(rd["etat"]);

					ouvrage.Add(o);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return ouvrage;
		}



		public List<OuvrageEmprent> ListOuvrageEmprent()
		{
			List<OuvrageEmprent> ouvrageEmprent = new List<OuvrageEmprent>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from ouvrageemprent ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					OuvrageEmprent oe = new OuvrageEmprent();
					oe.Numemprent = int.Parse(rd["numemprent"].ToString());
					oe.CodeBarre = int.Parse(rd["codebare"].ToString());
					oe.Id = rd["id"].ToString();
					oe.DateEmprent = Convert.ToDateTime(rd["date"]);
					oe.Etat = Convert.ToBoolean(rd["etat"]);

					ouvrageEmprent.Add(oe);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return ouvrageEmprent;
		}




		public List<ListeAttente> ListAttente()
		{
			List<ListeAttente> attente = new List<ListeAttente>();
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			try
			{
				connexion.Open();
				MySqlCommand sqlet = new MySqlCommand("select * from listeattente ", connexion);
				MySqlDataReader rd;
				rd = sqlet.ExecuteReader();
				while (rd.Read())
				{
					ListeAttente la = new ListeAttente();
					la.CodeBarre = int.Parse(rd["codebare"].ToString());
					la.Id = rd["id"].ToString();
					la.Priorite = int.Parse(rd["priorite"].ToString());

					attente.Add(la);
				}
				connexion.Close();
			}
			catch (MySqlException e)
			{

			}
			return attente;
		}




		public bool AjouterOuvrage(Ouvrage o)
		{
			bool result = false;
			List<Ouvrage> test = ListOuvrage();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].CodeBarre == o.CodeBarre)
				{
					return false;
				}
			}

			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into ouvrage(codebare,type,theme,titre,auteur) values(" + o.CodeBarre + ",'" + o.Type + "','" + o.Theme + "','" + o.Titre + "','" + o.Auteur + "')", connexion); MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				result = true;

			}
			catch
			{
				Console.WriteLine("erreuer1");
			}
			return result;
		}


		public bool ConfirmerCompte(Ensignant e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			bool res = false;
			List<Ensignant> test = ListEnsignant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].Matricule.Equals(e.Matricule))
				{
					if (test[i].EtatCompte == false)
					{
						try
						{
							connexion.Open();
							MySqlCommand sql1 = new MySqlCommand("update emprenteur set etatcompte=1 where matricule='" + e.Matricule + "'  ", connexion);
							MySqlDataReader rd1;
							rd1 = sql1.ExecuteReader();
							connexion.Close();
							return true;

						}
						catch
						{
							Console.WriteLine("erreuer");
						}
					}
					else
					{
						return false;
					}
				}
			}


			return res;
		}


		public bool ConfirmerComptee(Etudiant e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			bool res = false;
			List<Etudiant> test = ListEtudiant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].NumCarte.Equals(e.NumCarte))
				{
					if (test[i].EtatCompte == false)
					{
						try
						{
							connexion.Open();
							MySqlCommand sql1 = new MySqlCommand("update emprenteur set etatcompte=1 where matricule='" + e.NumCarte + "'  ", connexion);
							MySqlDataReader rd1;
							rd1 = sql1.ExecuteReader();
							connexion.Close();
							return true;

						}
						catch
						{
							Console.WriteLine("erreuer");
						}
					}
					else
					{
						return false;
					}
				}
			}


			return res;
		}



		public bool ConfirmerEmprent(OuvrageEmprent e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			

			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("update ouvrageemprent set etat=1 where numemprent=" + e.Numemprent + "  ", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				return true;

			}
			catch
			{
				Console.WriteLine("erreuer");
				return false;
			}
			
		}



		
		

		public bool Connexion(Bibliothequer b)
		{
			Console.WriteLine("access");
			bool res = false;
			List<Bibliothequer> test = ListBibliothequeur();
			
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].Id.Equals(b.Id))
				{
					if (test[i].Password.Equals(b.Password))
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}

						Console.WriteLine("access");

			return res;
		}

		public List<Ouvrage> Consulter()
		{
			List<Ouvrage> ouvrages = ListOuvrage();
			return ouvrages;
		}

		


		

		public bool InscrireAttente(ListeAttente l)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			bool res = false;
			int priorite = 0;
			List<ListeAttente> test = ListAttente();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].CodeBarre.Equals(l.CodeBarre))
				{
					if (test[i].Priorite >= priorite)
					{
						priorite = test[i].Priorite + 1;
					}
				}
			}
			l.Priorite = priorite;
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into listeattente values('" + l.CodeBarre + "','" + l.Id + "'," + l.Priorite + ")", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				res = true;

			}
			catch
			{
				Console.WriteLine("erreur");
			}
			return res;
		}

		





		public bool RendreEmprent(OuvrageEmprent o)

		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			bool res = false;
			List<OuvrageEmprent> test = ListOuvrageEmprent();
			int codebare;
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].Numemprent.Equals(o.Numemprent))
				{
					codebare = test[i].CodeBarre;


					try
					{
						connexion.Open();
						MySqlCommand sql1 = new MySqlCommand("update ouvrage set etat=0 where codebare=" + codebare + " ", connexion);
						MySqlDataReader rd1;
						rd1 = sql1.ExecuteReader();
						connexion.Close();
						res = true;

					}
					catch
					{
						Console.WriteLine("erreuer");
					}
                    ListeAttente a = new ListeAttente();
                    a.CodeBarre = codebare;
                    Notifier(a);
                        }
			}
			return res;
		}


        public void sendmail(string adresse,Ouvrage o)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("companyvpro@gmail.com");
                message.To.Add(new MailAddress(adresse));
                message.Subject = " Bibliotheque ";
                message.IsBodyHtml = true; //to make message body as html 
                message.Body = "votre "+o.Type+" avec le code barre "+o.CodeBarre+" est désormais disponible veuillez acceder à la platforme pour le reserver ";
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("companyvpro@gmail.com", "licencegl");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public Ouvrage GetOuvrage(Ouvrage o)
        {
            List<Ouvrage> ouvrages = ListOuvrage();
            for(int i = 0; i < ouvrages.Count; i++)
            {
                if (ouvrages[i].CodeBarre.Equals(o.CodeBarre))
                {
                    return ouvrages[i];
                }
            }
            return null;
        }


        public ListeAttente getPrioritaire(ListeAttente att)
        {
            MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

            List<ListeAttente> test = ListAttente();
            ListeAttente lis = new ListeAttente();
			lis = null;
            for (int i = 0; i < test.Count; i++)
            {
                if (test[i].CodeBarre.Equals(att.CodeBarre))
                {
                    if (lis == null)
                    {
                        lis = test[i];
                    }
                    else
                    {
                        if (test[i].Priorite < lis.Priorite)
                        {
                            lis = test[i];
                        }
                    }

                }
            }
            if (lis != null)
            {
                try
                {
                    connexion.Open();
                    MySqlCommand sql1 = new MySqlCommand("delete from listeattente where codebare=" + lis.CodeBarre + " and id='" + lis.Id + "' and priorite =" + lis.Priorite + " ", connexion);
                    MySqlDataReader rd1;
                    rd1 = sql1.ExecuteReader();
                    connexion.Close();
                }
                catch
                {
                    Console.WriteLine("erreuer");
                }
            }
            return lis;
        }

       
       

        public void Notifier(ListeAttente a)
        {
			try
			{


				Console.WriteLine(a.CodeBarre);
				ListeAttente lis = new ListeAttente();
				List<Etudiant> etu = ListEtudiant();
				List<Ensignant> ens = ListEnsignant();
				string mail = "";
				lis = getPrioritaire(a);
				Console.WriteLine("hahaha" + lis.Id);
				if (lis != null)
				{
					Ouvrage oe = new Ouvrage();
					oe.CodeBarre = lis.CodeBarre;
					oe = GetOuvrage(oe);

					for (int i = 0; i < etu.Count; i++)
					{
						if (etu[i].NumCarte.Equals(lis.Id))
						{
							mail = etu[i].Email;
						}
					}
					if (mail == "")
					{
						for (int j = 0; j < ens.Count; j++)
						{
							if (ens[j].Matricule.Equals(lis.Id))
							{
								mail = ens[j].Email;
							}
						}
					}

					sendmail(mail, oe);
				}

			}catch(Exception e) { }
        }

    }
}
