﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emprentuer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Etudiant", Namespace="http://schemas.datacontract.org/2004/07/wcf")]
    [System.SerializableAttribute()]
    public partial class Etudiant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatCompteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatSanctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbNonReserveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NiveauField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumCarteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SanctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialiteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EtatCompte {
            get {
                return this.EtatCompteField;
            }
            set {
                if ((this.EtatCompteField.Equals(value) != true)) {
                    this.EtatCompteField = value;
                    this.RaisePropertyChanged("EtatCompte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EtatSanction {
            get {
                return this.EtatSanctionField;
            }
            set {
                if ((this.EtatSanctionField.Equals(value) != true)) {
                    this.EtatSanctionField = value;
                    this.RaisePropertyChanged("EtatSanction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbNonReserve {
            get {
                return this.NbNonReserveField;
            }
            set {
                if ((this.NbNonReserveField.Equals(value) != true)) {
                    this.NbNonReserveField = value;
                    this.RaisePropertyChanged("NbNonReserve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Niveau {
            get {
                return this.NiveauField;
            }
            set {
                if ((object.ReferenceEquals(this.NiveauField, value) != true)) {
                    this.NiveauField = value;
                    this.RaisePropertyChanged("Niveau");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumCarte {
            get {
                return this.NumCarteField;
            }
            set {
                if ((object.ReferenceEquals(this.NumCarteField, value) != true)) {
                    this.NumCarteField = value;
                    this.RaisePropertyChanged("NumCarte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Sanction {
            get {
                return this.SanctionField;
            }
            set {
                if ((this.SanctionField.Equals(value) != true)) {
                    this.SanctionField = value;
                    this.RaisePropertyChanged("Sanction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialite {
            get {
                return this.SpecialiteField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialiteField, value) != true)) {
                    this.SpecialiteField = value;
                    this.RaisePropertyChanged("Specialite");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ensignant", Namespace="http://schemas.datacontract.org/2004/07/wcf")]
    [System.SerializableAttribute()]
    public partial class Ensignant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatCompteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatSanctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbNonReserveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SanctionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EtatCompte {
            get {
                return this.EtatCompteField;
            }
            set {
                if ((this.EtatCompteField.Equals(value) != true)) {
                    this.EtatCompteField = value;
                    this.RaisePropertyChanged("EtatCompte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EtatSanction {
            get {
                return this.EtatSanctionField;
            }
            set {
                if ((this.EtatSanctionField.Equals(value) != true)) {
                    this.EtatSanctionField = value;
                    this.RaisePropertyChanged("EtatSanction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((object.ReferenceEquals(this.GradeField, value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Matricule {
            get {
                return this.MatriculeField;
            }
            set {
                if ((object.ReferenceEquals(this.MatriculeField, value) != true)) {
                    this.MatriculeField = value;
                    this.RaisePropertyChanged("Matricule");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbNonReserve {
            get {
                return this.NbNonReserveField;
            }
            set {
                if ((this.NbNonReserveField.Equals(value) != true)) {
                    this.NbNonReserveField = value;
                    this.RaisePropertyChanged("NbNonReserve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Sanction {
            get {
                return this.SanctionField;
            }
            set {
                if ((this.SanctionField.Equals(value) != true)) {
                    this.SanctionField = value;
                    this.RaisePropertyChanged("Sanction");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ouvrage", Namespace="http://schemas.datacontract.org/2004/07/wcf")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(emprentuer.ServiceReference1.Etudiant))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(emprentuer.ServiceReference1.Ensignant))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(emprentuer.ServiceReference1.OuvrageEmprent))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(emprentuer.ServiceReference1.ListeAttente))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<object>))]
    public partial class Ouvrage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuteurField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeBarreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<object> MotCleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThemeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Auteur {
            get {
                return this.AuteurField;
            }
            set {
                if ((object.ReferenceEquals(this.AuteurField, value) != true)) {
                    this.AuteurField = value;
                    this.RaisePropertyChanged("Auteur");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodeBarre {
            get {
                return this.CodeBarreField;
            }
            set {
                if ((this.CodeBarreField.Equals(value) != true)) {
                    this.CodeBarreField = value;
                    this.RaisePropertyChanged("CodeBarre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Etat {
            get {
                return this.EtatField;
            }
            set {
                if ((this.EtatField.Equals(value) != true)) {
                    this.EtatField = value;
                    this.RaisePropertyChanged("Etat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<object> MotCle {
            get {
                return this.MotCleField;
            }
            set {
                if ((object.ReferenceEquals(this.MotCleField, value) != true)) {
                    this.MotCleField = value;
                    this.RaisePropertyChanged("MotCle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Theme {
            get {
                return this.ThemeField;
            }
            set {
                if ((object.ReferenceEquals(this.ThemeField, value) != true)) {
                    this.ThemeField = value;
                    this.RaisePropertyChanged("Theme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titre {
            get {
                return this.TitreField;
            }
            set {
                if ((object.ReferenceEquals(this.TitreField, value) != true)) {
                    this.TitreField = value;
                    this.RaisePropertyChanged("Titre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OuvrageEmprent", Namespace="http://schemas.datacontract.org/2004/07/wcf")]
    [System.SerializableAttribute()]
    public partial class OuvrageEmprent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeBarreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateEmprentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EtatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumemprentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodeBarre {
            get {
                return this.CodeBarreField;
            }
            set {
                if ((this.CodeBarreField.Equals(value) != true)) {
                    this.CodeBarreField = value;
                    this.RaisePropertyChanged("CodeBarre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateEmprent {
            get {
                return this.DateEmprentField;
            }
            set {
                if ((this.DateEmprentField.Equals(value) != true)) {
                    this.DateEmprentField = value;
                    this.RaisePropertyChanged("DateEmprent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Etat {
            get {
                return this.EtatField;
            }
            set {
                if ((this.EtatField.Equals(value) != true)) {
                    this.EtatField = value;
                    this.RaisePropertyChanged("Etat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numemprent {
            get {
                return this.NumemprentField;
            }
            set {
                if ((this.NumemprentField.Equals(value) != true)) {
                    this.NumemprentField = value;
                    this.RaisePropertyChanged("Numemprent");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListeAttente", Namespace="http://schemas.datacontract.org/2004/07/wcf")]
    [System.SerializableAttribute()]
    public partial class ListeAttente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodeBarreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PrioriteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodeBarre {
            get {
                return this.CodeBarreField;
            }
            set {
                if ((this.CodeBarreField.Equals(value) != true)) {
                    this.CodeBarreField = value;
                    this.RaisePropertyChanged("CodeBarre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Priorite {
            get {
                return this.PrioriteField;
            }
            set {
                if ((this.PrioriteField.Equals(value) != true)) {
                    this.PrioriteField = value;
                    this.RaisePropertyChanged("Priorite");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreeComptee", ReplyAction="http://tempuri.org/IService1/CreeCompteeResponse")]
        bool CreeComptee(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreeComptee", ReplyAction="http://tempuri.org/IService1/CreeCompteeResponse")]
        System.Threading.Tasks.Task<bool> CreeCompteeAsync(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreeCompte", ReplyAction="http://tempuri.org/IService1/CreeCompteResponse")]
        bool CreeCompte(emprentuer.ServiceReference1.Ensignant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreeCompte", ReplyAction="http://tempuri.org/IService1/CreeCompteResponse")]
        System.Threading.Tasks.Task<bool> CreeCompteAsync(emprentuer.ServiceReference1.Ensignant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulter", ReplyAction="http://tempuri.org/IService1/ConsulterResponse")]
        System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage> Consulter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Consulter", ReplyAction="http://tempuri.org/IService1/ConsulterResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage>> ConsulterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Recherche", ReplyAction="http://tempuri.org/IService1/RechercheResponse")]
        System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage> Recherche(emprentuer.ServiceReference1.Ouvrage o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Recherche", ReplyAction="http://tempuri.org/IService1/RechercheResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage>> RechercheAsync(emprentuer.ServiceReference1.Ouvrage o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connexionn", ReplyAction="http://tempuri.org/IService1/ConnexionnResponse")]
        bool Connexionn(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connexionn", ReplyAction="http://tempuri.org/IService1/ConnexionnResponse")]
        System.Threading.Tasks.Task<bool> ConnexionnAsync(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connexion", ReplyAction="http://tempuri.org/IService1/ConnexionResponse")]
        bool Connexion(emprentuer.ServiceReference1.Ensignant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Connexion", ReplyAction="http://tempuri.org/IService1/ConnexionResponse")]
        System.Threading.Tasks.Task<bool> ConnexionAsync(emprentuer.ServiceReference1.Ensignant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifierMotPass", ReplyAction="http://tempuri.org/IService1/ModifierMotPassResponse")]
        bool ModifierMotPass(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifierMotPass", ReplyAction="http://tempuri.org/IService1/ModifierMotPassResponse")]
        System.Threading.Tasks.Task<bool> ModifierMotPassAsync(emprentuer.ServiceReference1.Etudiant e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Reserver", ReplyAction="http://tempuri.org/IService1/ReserverResponse")]
        int Reserver(emprentuer.ServiceReference1.OuvrageEmprent o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Reserver", ReplyAction="http://tempuri.org/IService1/ReserverResponse")]
        System.Threading.Tasks.Task<int> ReserverAsync(emprentuer.ServiceReference1.OuvrageEmprent o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InscrireAttente", ReplyAction="http://tempuri.org/IService1/InscrireAttenteResponse")]
        bool InscrireAttente(emprentuer.ServiceReference1.ListeAttente l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InscrireAttente", ReplyAction="http://tempuri.org/IService1/InscrireAttenteResponse")]
        System.Threading.Tasks.Task<bool> InscrireAttenteAsync(emprentuer.ServiceReference1.ListeAttente l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sanctionner", ReplyAction="http://tempuri.org/IService1/SanctionnerResponse")]
        void Sanctionner();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sanctionner", ReplyAction="http://tempuri.org/IService1/SanctionnerResponse")]
        System.Threading.Tasks.Task SanctionnerAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : emprentuer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<emprentuer.ServiceReference1.IService1>, emprentuer.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreeComptee(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.CreeComptee(e);
        }
        
        public System.Threading.Tasks.Task<bool> CreeCompteeAsync(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.CreeCompteeAsync(e);
        }
        
        public bool CreeCompte(emprentuer.ServiceReference1.Ensignant e) {
            return base.Channel.CreeCompte(e);
        }
        
        public System.Threading.Tasks.Task<bool> CreeCompteAsync(emprentuer.ServiceReference1.Ensignant e) {
            return base.Channel.CreeCompteAsync(e);
        }
        
        public System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage> Consulter() {
            return base.Channel.Consulter();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage>> ConsulterAsync() {
            return base.Channel.ConsulterAsync();
        }
        
        public System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage> Recherche(emprentuer.ServiceReference1.Ouvrage o) {
            return base.Channel.Recherche(o);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<emprentuer.ServiceReference1.Ouvrage>> RechercheAsync(emprentuer.ServiceReference1.Ouvrage o) {
            return base.Channel.RechercheAsync(o);
        }
        
        public bool Connexionn(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.Connexionn(e);
        }
        
        public System.Threading.Tasks.Task<bool> ConnexionnAsync(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.ConnexionnAsync(e);
        }
        
        public bool Connexion(emprentuer.ServiceReference1.Ensignant e) {
            return base.Channel.Connexion(e);
        }
        
        public System.Threading.Tasks.Task<bool> ConnexionAsync(emprentuer.ServiceReference1.Ensignant e) {
            return base.Channel.ConnexionAsync(e);
        }
        
        public bool ModifierMotPass(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.ModifierMotPass(e);
        }
        
        public System.Threading.Tasks.Task<bool> ModifierMotPassAsync(emprentuer.ServiceReference1.Etudiant e) {
            return base.Channel.ModifierMotPassAsync(e);
        }
        
        public int Reserver(emprentuer.ServiceReference1.OuvrageEmprent o) {
            return base.Channel.Reserver(o);
        }
        
        public System.Threading.Tasks.Task<int> ReserverAsync(emprentuer.ServiceReference1.OuvrageEmprent o) {
            return base.Channel.ReserverAsync(o);
        }
        
        public bool InscrireAttente(emprentuer.ServiceReference1.ListeAttente l) {
            return base.Channel.InscrireAttente(l);
        }
        
        public System.Threading.Tasks.Task<bool> InscrireAttenteAsync(emprentuer.ServiceReference1.ListeAttente l) {
            return base.Channel.InscrireAttenteAsync(l);
        }
        
        public void Sanctionner() {
            base.Channel.Sanctionner();
        }
        
        public System.Threading.Tasks.Task SanctionnerAsync() {
            return base.Channel.SanctionnerAsync();
        }
    }
}
