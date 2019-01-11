using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf
{
	// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService2" à la fois dans le code et le fichier de configuration.
	[ServiceContract]
	public interface IService2
	{
		[OperationContract]
		bool AjouterOuvrage(Ouvrage o);
		[OperationContract]
		bool ConfirmerEmprent(OuvrageEmprent e);
		[OperationContract]
		List<Ouvrage> Consulter();
		[OperationContract]
		bool Connexion(Bibliothequer b);
		[OperationContract]
		bool ConfirmerCompte(Ensignant e);
		[OperationContract]
		bool ConfirmerComptee(Etudiant e);
		[OperationContract]
		bool RendreEmprent(OuvrageEmprent o);
		[OperationContract]
		List<Bibliothequer> ListBibliothequeur();

	}

	[DataContract]
	public class Bibliothequer
	{

		[DataMember]
		public string Password { get; set; }

		[DataMember]
		public string Id { get; set; }
	}
}
