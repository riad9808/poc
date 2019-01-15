using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf
{
	// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
	[ServiceContract]
	public interface IService1
	{
		
		[OperationContract]
		bool CreeComptee(Etudiant e);
		[OperationContract]
		bool CreeCompte(Ensignant e);
		[OperationContract]
		List<Ouvrage> Consulter();
		[OperationContract]
		List<Ouvrage> Recherche(Ouvrage o);
		[OperationContract]
		bool Connexionn(Etudiant e);
		[OperationContract]
		bool Connexion(Ensignant e);
		[OperationContract]
		bool ModifierMotPass(Etudiant e);
		[OperationContract]
		int Reserver(OuvrageEmprent o);
		[OperationContract]
		bool InscrireAttente(ListeAttente l);
		[OperationContract]
		void Sanctionner();


		// TODO: ajoutez vos opérations de service ici
	}
	
	
	// Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
	// Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "serverwcf.ContractType".
	[DataContract]
	public class Ensignant
	{

		
		[DataMember]
		public string Matricule { get; set; }
		[DataMember]
		public string Nom { get; set; }
		[DataMember]
		public string Prenom { get; set; }
		[DataMember]
		public string Grade { get; set; }
		[DataMember]
		public string Password { get; set; }
		[DataMember]
		public bool EtatSanction { get; set; }
		[DataMember]
		public DateTime Sanction { get; set; }
		[DataMember]
		public bool EtatCompte { get; set; }
		[DataMember]
		public int NbNonReserve { get; set; }
		[DataMember]
		public string Email { get; set; }
	}

	
	[DataContract]
	public class Etudiant
	{
		[DataMember]
		public string NumCarte { get; set; }
		[DataMember]
		public string Password { get; set; }
		[DataMember]
		public string Nom { get; set; }
		[DataMember]
		public string Prenom { get; set; }
		[DataMember]
		public string Specialite { get; set; }
		[DataMember]
		public string Niveau { get; set; }
		[DataMember]
		public bool EtatCompte { get; set; }
		[DataMember]
		public int NbNonReserve { get; set; }
		[DataMember]
		public bool EtatSanction { get; set; }
		[DataMember]
		public DateTime Sanction { get; set; }
		[DataMember]
		public string Email { get; set; }
	}
	[DataContract]
	public class ListeAttente
	{
		[DataMember]
		public int CodeBarre { get; set; }
		[DataMember]
		public string Id { get; set; }
		[DataMember]
		public int Priorite { get; set; }
	}
	[DataContract]
	public class Ouvrage
	{
		[DataMember]
		public int CodeBarre { get; set; }
		[DataMember]
		public string Type { get; set; }
		[DataMember]
		public string Theme { get; set; }
		[DataMember]
		public string Auteur { get; set; }
		[DataMember]
		public string Titre { get; set; }
		[DataMember]
		public bool Etat { get; set; }
		[DataMember]
		public ArrayList MotCle { get; set; }
	}
	[DataContract]
	public class OuvrageEmprent
	{
		[DataMember]
		public int Numemprent { get; set; }
		[DataMember]
		public int CodeBarre { get; set; }
		[DataMember]
		public String Id { get; set; }
		[DataMember]
		public bool Etat { get; set; }
		[DataMember]
		public DateTime DateEmprent { get; set; }
	}
}
