using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
				MySqlCommand sql1 = new MySqlCommand("insert into ouvrage(codebare,type,theme,titre,auteur) values(" + o.CodeBarre + ",'+" + o.Type + "','" + o.Theme + "','" + o.Titre + "','" + o.Auteur + "')", connexion); MySqlDataReader rd1;
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
			bool res = false;

			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("update ouvrageemprent set etat=1 where matricule='" + e.Id + "'  ", connexion);
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



		public bool Connexionn(Etudiant e)
		{
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

		public List<Ouvrage> Recherche(Ouvrage o)
		{
			List<Ouvrage> ouvrages = ListOuvrage();

			List<Ouvrage> resultat = new List<Ouvrage>();
			if (o.Titre == null && o.Type == null && o.Theme == null && o.Auteur == null)
			{
				resultat = ouvrages;
			}
			if (o.Type != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Type.Equals(o.Type))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			if (o.Auteur != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Auteur.Equals(o.Auteur))
					{
						resultat.Add(ouvrages[i]);
					}

				}
			}
			if (o.Theme != null)
			{
				for (int i = 0; i < ouvrages.Count; i++)
				{
					if (ouvrages[i].Theme.Equals(o.Theme))
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
			try
			{
				connexion.Open();
				MySqlCommand sql1 = new MySqlCommand("insert into emprenteur (matricule,type,nom,prenom,password,specialite,niveau,sanction) values('" + e.NumCarte + "','etudiant','" + e.Nom + "','" + e.Prenom + "','" + e.Password + "','" + e.Specialite + "','" + e.Niveau + "','0000-00-00')", connexion);
				MySqlDataReader rd1;
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
				MySqlCommand sql1 = new MySqlCommand("insert into emprenteur (matricule,type,nom,prenom,password,grade,sanction) values('" + e.Matricule + "','ensignant','" + e.Nom + "','" + e.Prenom + "','" + e.Password + "','" + e.Grade + "','" + d.Year + "-" + d.Month + "-" + d.Day + "')", connexion);
				MySqlDataReader rd1;
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
					res = true;
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
			return res;
		}

		public bool Reserver(OuvrageEmprent o)
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			bool res = false;
			List<Ouvrage> ouvrage = ListOuvrage();
			List<Etudiant> etudian = ListEtudiant();
			List<Ensignant> ens = ListEnsignant();
			for (int i = 0; i < etudian.Count; i++)
			{
				if (etudian[i].NumCarte.Equals(o.Id))
				{
					if ((etudian[i].EtatCompte == false) || (etudian[i].EtatSanction == true))
					{
						return false;
					}
				}
			}
			for (int i = 0; i < ens.Count; i++)
			{
				if (ens[i].Matricule.Equals(o.Id))
				{
					if ((ens[i].EtatCompte == false) || (ens[i].EtatSanction == true))
					{
						return false;
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
						return false;
					}
				}
			}
			try
			{
				connexion.Open();
				DateTime d = DateTime.Now;
				MySqlCommand sql1 = new MySqlCommand("insert into ouvrageemprent (codebare,id,date) values('" + o.CodeBarre + "','" + o.Id + "','" + d.Year + "-" + d.Month + "-" + d.Day + "')", connexion);
				MySqlDataReader rd1;
				rd1 = sql1.ExecuteReader();
				connexion.Close();
				res = true;

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
				res = true;

			}
			catch
			{
				Console.WriteLine("erreuer");
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
					
				}
			}
			return res;
		}

		public void Sanctionner()
		{
			MySqlConnection connexion = new MySqlConnection("database=bibliotheque; server=localhost; user id=root; pwd=1898;");

			List<OuvrageEmprent> ouvemp = ListOuvrageEmprent();
			List<Etudiant> etudiant = ListEtudiant();
			List<Ensignant> ensignant = ListEnsignant();
			List<ListeAttente> attente = ListAttente();
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
										Console.WriteLine("erreuer");
									}
								}
								else
								{
									try
									{
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set nonConfirme=" + etudiant[j].NbNonReserve + 1 + " where matricule='" + etudiant[j].NumCarte + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreuer");
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
										Console.WriteLine("erreuer");
									}
								}
								else
								{
									try
									{
										connexion.Open();
										MySqlCommand sql1 = new MySqlCommand("update emprenteur set nonConfirme=" + ensignant[h].NbNonReserve + 1 + " where matricule='" + ensignant[h].Matricule + "'  ", connexion);
										MySqlDataReader rd1;
										rd1 = sql1.ExecuteReader();
										connexion.Close();


									}
									catch
									{
										Console.WriteLine("erreuer");
									}
								}
							}
						}

						int vartest = 0;
						for (int m = 0; m < attente.Count; m++)
						{
							if (attente[m].CodeBarre.Equals(ouvemp[i].CodeBarre) && vartest == 0)
							{
								ListeAttente aajouter = attente[m];
								for (int n = 0; n < attente.Count; n++)
								{
									if (aajouter.CodeBarre.Equals(attente[n].CodeBarre) && aajouter.Priorite < attente[n].Priorite)
									{
										aajouter = attente[n];
									}

								}
								vartest = 1;
								OuvrageEmprent e = new OuvrageEmprent();
								e.CodeBarre = aajouter.CodeBarre;
								e.Id = aajouter.Id;
								Reserver(e);
								try
								{
									connexion.Open();
									MySqlCommand sql1 = new MySqlCommand("delete from listeattente where codebare=" + aajouter.CodeBarre + "and priorite=" + aajouter.Priorite + " ", connexion);
									MySqlDataReader rd1;
									rd1 = sql1.ExecuteReader();
									connexion.Close();


								}
								catch
								{
									Console.WriteLine("erreuer");
								}
							}
						}
						if (vartest == 0)
						{
							try
							{
								connexion.Open();
								MySqlCommand sql1 = new MySqlCommand("update ouvrage set etat=0 where codebarre=" + ouvemp[i].CodeBarre + " ", connexion);
								MySqlDataReader rd1;
								rd1 = sql1.ExecuteReader();
								connexion.Close();


							}
							catch
							{
								Console.WriteLine("erreuer");
							}
						}
						try
						{
							connexion.Open();
							MySqlCommand sql1 = new MySqlCommand("delete from ouvrageemprent where numemprent=" + ouvemp[i].Numemprent + " ", connexion);
							MySqlDataReader rd1;
							rd1 = sql1.ExecuteReader();
							connexion.Close();


						}
						catch
						{
							Console.WriteLine("erreuer");
						}

					}
				}
			}
		}

	}
}
