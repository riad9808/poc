﻿using MySql.Data.MySqlClient;
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
	// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
	public class Service1 : IService1
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





		public bool Connexionn(Etudiant e)
		{
			Console.WriteLine("from hosted");
			bool res = false;
			List<Etudiant> test = ListEtudiant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].NumCarte.Equals(e.NumCarte))
				{
					if (test[i].Password.Equals(e.Password))
					{
						
						if (test[i].EtatCompte == false)
						{
							return false;
						}
						else
						{
							return true;
						}

					}
					else
					{
						return false;
					}
				}
			}


			return false;
		}

		public bool Connexion(Ensignant e)
		{
			bool res = false;
			List<Ensignant> test = ListEnsignant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].Matricule.Equals(e.Matricule))
				{
					if (test[i].Password.Equals(e.Password))
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}


			return res;
		}



		public List<Ouvrage> Consulter()
		{
			List<Ouvrage> ouvrages = ListOuvrage();
			return ouvrages;
		}

		public List<Ouvrage> Recherche(Ouvrage o)
		{
			List<Ouvrage> ouvrages = ListOuvrage();

			List<Ouvrage> resultat = new List<Ouvrage>();
			if(o.Titre==null && o.Type==null && o.Theme==null && o.Auteur == null)
			{
				resultat = ouvrages;
			}
			if (o.Type != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Type.Equals( o.Type))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			if (o.Auteur != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Auteur.Equals( o.Auteur))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			if (o.Theme != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Theme.Equals( o.Theme))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			if (o.Titre != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Titre.Equals(o.Titre))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			return resultat;
		}



		public bool CreeComptee(Etudiant e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			bool res = false;
			List<Etudiant> test = ListEtudiant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].NumCarte.Equals(e.NumCarte))
				{
					return false;
				}
			}
			DateTime d = DateTime.Now;
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into emprenteur (matricule,type,nom,prenom,password,specialite,niveau,sanction,email) values('" + e.NumCarte + "','etudiant','" + e.Nom + "','" + e.Prenom + "','" + e.Password + "','" + e.Specialite + "','" + e.Niveau + "','" + d.Year + "-" + d.Month + "-" + d.Day + "','" + e.Email + "')", connexion); MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				res = true;

			}
			catch
			{
				Console.WriteLine("erreuer");
			}


			return res;
		}






		public bool CreeCompte(Ensignant e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			bool res = false;
			List<Ensignant> test = ListEnsignant();
			for (int i = 0; i < test.Count; i++)
			{
				if (test[i].Matricule.Equals(e.Matricule))
				{
					return false;
				}
			}
			DateTime d = DateTime.Now;
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into emprenteur (matricule,type,nom,prenom,password,grade,sanction,email) values('" + e.Matricule + "','ensignant','" + e.Nom + "','" + e.Prenom + "','" + e.Password + "','" + e.Grade + "','" + d.Year + "-" + d.Month + "-" + d.Day + "','" + e.Email + "')", connexion); MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				res = true;

			}
			catch
			{
				Console.WriteLine("erreuer");
			}


			return res;
		}




		public bool ModifierMotPass(Etudiant e)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");
			bool res = false;
			List<Etudiant> test = ListEtudiant();
			for (int i = 0; i < test.Count; i++)
			{
				if ((test[i].NumCarte.Equals(e.NumCarte)))
				{
					res =true;
				}
			}
			if (res == false)
			{
				return false;
			}
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("update emprenteur set password='" + e.Password + "' where matricule='" + e.NumCarte + "'  ", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				return true;

			}
			catch
			{
				Console.WriteLine("erreuer");
			}
			return res;
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
				Console.WriteLine("erreuer");
			}
			var Service1 = new Service2();
			var s1 = new Service1();
			Console.WriteLine("avant inscription");
			Service2.RendreEvent += s1.onRendre;
			Console.WriteLine();
			Console.WriteLine("apres inscription");
			return res;
		}

		public void onRendre(object source, ListeAttenteEventArgs args)
		{
			Console.WriteLine("on rendre");
			
			Console.WriteLine("code "+args.ListeAttente.CodeBarre);
			Notifier(args.ListeAttente);
		}

		public int Reserver(OuvrageEmprent o)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			int res = 8;
			List<Ouvrage> ouvrage = ListOuvrage();
			List<Etudiant> etudian = ListEtudiant();
			List<Ensignant> ens = ListEnsignant();
			for (int i = 0; i < etudian.Count; i++)
			{
				if (etudian[i].NumCarte.Equals(o.Id))
				{
					if ((etudian[i].EtatCompte == false) || (etudian[i].EtatSanction == true))
					{
						return -1;
					}
				}
			}
			for (int i = 0; i < ens.Count; i++)
			{
				if (ens[i].Matricule.Equals(o.Id))
				{
					if ((ens[i].EtatCompte == false) || (ens[i].EtatSanction == true))
					{
						return -1;
					}
				}
			}
			for (int i = 0; i < ouvrage.Count; i++)
			{
				if (ouvrage[i].CodeBarre.Equals(o.CodeBarre))
				{
					if (ouvrage[i].Etat == true)
					{
						ListeAttente l = new ListeAttente();
						l.CodeBarre = o.CodeBarre;
						l.Id = o.Id;
						InscrireAttente(l);
						return 0;
					}
				}
			}
			DateTime d = DateTime.Now;

			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into ouvrageemprent (codebare,id,date) values('" + o.CodeBarre + "','" + o.Id + "','" + d.Year + "-" + d.Month + "-" + d.Day + "')", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				

			}
			catch
			{
				Console.WriteLine("erreuer");
			}
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("update ouvrage set etat=1 where codebare='" + o.CodeBarre + "'", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				

			}
			catch
			{
				Console.WriteLine("erreur");
			}
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("select numemprent from ouvrageemprent where codebare="+ o.CodeBarre +" and id='"+o.Id+"' and date='"+d.Year+"-"+d.Month+"-"+d.Day+"'", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				while (rd1.Read())
				{
					res = int.Parse(rd1["numemprent"].ToString());
				}
					connexion.Close();
			

			}
			catch
			{
				Console.WriteLine("erreur");
			}






			return res;
		}







		public void Sanctionner()
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			List<OuvrageEmprent> ouvemp = ListOuvrageEmprent();
			List<Etudiant> etudiant = ListEtudiant();
			List<Ensignant> ensignant = ListEnsignant();
			DateTimeOffset d = DateTimeOffset.Now;

			for (int i = 0; i < ouvemp.Count; i++)
			{
				if (ouvemp[i].Etat == false)
				{
					TimeSpan t = d - ouvemp[i].DateEmprent;
					if (t.Days > 1)
					{
						for (int j = 0; j < etudiant.Count; j++)
						{
							if (ouvemp[i].Id.Equals(etudiant[j].NumCarte))
							{
								if (etudiant[j].NbNonReserve == 2)
								{
									d = d.AddDays(30);
									try
									{
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set etatsanction=1,sanction='" + d.Year + "-" + d.Month + "-" + d.Day + "' where matricule='" + etudiant[j].NumCarte + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreur SANCTIONNER 1");
									}
								}
								else
								{
									try
									{
										int las = etudiant[j].NbNonReserve + 1;
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set nonConfirme=" +las + " where matricule='" + etudiant[j].NumCarte + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreur sanctionner 2");
									}
								}
							}
						}


						for (int h = 0; h < ensignant.Count; h++)
						{
							if (ouvemp[i].Id.Equals(ensignant[h].Matricule))
							{
								if (ensignant[h].NbNonReserve == 2)
								{
									d = d.AddDays(30);
									try
									{
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set nonConfirme=0,etatsanction=1,sanction='" + d.Year + "-" + d.Month + "-" + d.Day + "' where matricule='" + ensignant[h].Matricule + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreur sanctionner 3");
									}
								}
								else
								{
									try
									{
										int last = ensignant[h].NbNonReserve + 1;
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set nonConfirme=" + last  + " where matricule='" + ensignant[h].Matricule + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreur sanctionner  4");
									}
								}
							}
						}


						try
						{
							connexion.Open();
							Console.WriteLine(ouvemp[i].CodeBarre);
							MySqlCommand sql1 = new MySqlCommand("update ouvrage set etat=0 where codebare=" + ouvemp[i].CodeBarre + " ", connexion);
							MySqlDataReader rd1;
							rd1 = sql1.ExecuteReader();
							connexion.Close();


						}
						catch
						{
							Console.WriteLine("erreur sanctionner 5");
						}
                        ListeAttente a = new ListeAttente();
                        a.CodeBarre = ouvemp[i].CodeBarre;
                        try
                        {
                            connexion.Open();
							Console.WriteLine(ouvemp[i].Numemprent);

							MySqlCommand sql1 = new MySqlCommand("delete from ouvrageemprent where numemprent="+ouvemp[i].Numemprent +" ", connexion);
                            MySqlDataReader rd1;
                            rd1 = sql1.ExecuteReader();
                            connexion.Close();


                        }
                        catch
                        {
                            Console.WriteLine("erreur sanctionner  6");
                        }

                        Notifier(a);

                     }
				}
			}
		}


        public void sendmail(string adresse, Ouvrage o)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("companyvpro@gmail.com");
                message.To.Add(new MailAddress(adresse));
                message.Subject = " Bibliotheque ";
                message.IsBodyHtml = true; //to make message body as html 
                message.Body = "votre " + o.Type + " avec le code barre " + o.CodeBarre + " est désormais disponible veuillez acceder à la platforme pour le reserver";
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
            for (int i = 0; i < ouvrages.Count; i++)
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
                    Console.WriteLine("erreur");
                }
            }
            return lis;
        }




        public void Notifier(ListeAttente a)
        {

			try { 
			Console.WriteLine(a.CodeBarre);
			ListeAttente lis = new ListeAttente();
			List<Etudiant> etu = ListEtudiant();
			List<Ensignant> ens = ListEnsignant();
			string mail = "";
			lis = getPrioritaire(a);
			//Console.WriteLine("hahaha" + lis.Id);
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
