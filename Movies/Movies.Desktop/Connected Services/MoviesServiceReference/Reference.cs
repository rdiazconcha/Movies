﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies.Desktop.MoviesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/Movies.WebServices.Models")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.PersonRole> CastField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Movies.Desktop.MoviesServiceReference.Country CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.PersonRole> Cast {
            get {
                return this.CastField;
            }
            set {
                if ((object.ReferenceEquals(this.CastField, value) != true)) {
                    this.CastField = value;
                    this.RaisePropertyChanged("Cast");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Movies.Desktop.MoviesServiceReference.Country Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/Movies.WebServices.Models")]
    [System.SerializableAttribute()]
    public partial class Country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonRole", Namespace="http://schemas.datacontract.org/2004/07/Movies.WebServices.Models")]
    [System.SerializableAttribute()]
    public partial class PersonRole : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleIdField;
        
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
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoleId {
            get {
                return this.RoleIdField;
            }
            set {
                if ((this.RoleIdField.Equals(value) != true)) {
                    this.RoleIdField = value;
                    this.RaisePropertyChanged("RoleId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/Movies.WebServices.Models")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Movies.WebServices.Models")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
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
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviesServiceReference.IMoviesService")]
    public interface IMoviesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllMovies", ReplyAction="http://tempuri.org/IMoviesService/GetAllMoviesResponse")]
        System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Movie> GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllMovies", ReplyAction="http://tempuri.org/IMoviesService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Movie>> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetMovie", ReplyAction="http://tempuri.org/IMoviesService/GetMovieResponse")]
        Movies.Desktop.MoviesServiceReference.Movie GetMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetMovie", ReplyAction="http://tempuri.org/IMoviesService/GetMovieResponse")]
        System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Movie> GetMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/InsertMovie", ReplyAction="http://tempuri.org/IMoviesService/InsertMovieResponse")]
        bool InsertMovie(Movies.Desktop.MoviesServiceReference.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/InsertMovie", ReplyAction="http://tempuri.org/IMoviesService/InsertMovieResponse")]
        System.Threading.Tasks.Task<bool> InsertMovieAsync(Movies.Desktop.MoviesServiceReference.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/UpdateMovie", ReplyAction="http://tempuri.org/IMoviesService/UpdateMovieResponse")]
        bool UpdateMovie(int id, Movies.Desktop.MoviesServiceReference.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/UpdateMovie", ReplyAction="http://tempuri.org/IMoviesService/UpdateMovieResponse")]
        System.Threading.Tasks.Task<bool> UpdateMovieAsync(int id, Movies.Desktop.MoviesServiceReference.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/DeleteMovie", ReplyAction="http://tempuri.org/IMoviesService/DeleteMovieResponse")]
        bool DeleteMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/DeleteMovie", ReplyAction="http://tempuri.org/IMoviesService/DeleteMovieResponse")]
        System.Threading.Tasks.Task<bool> DeleteMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllCountries", ReplyAction="http://tempuri.org/IMoviesService/GetAllCountriesResponse")]
        System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Country> GetAllCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllCountries", ReplyAction="http://tempuri.org/IMoviesService/GetAllCountriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Country>> GetAllCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetCountry", ReplyAction="http://tempuri.org/IMoviesService/GetCountryResponse")]
        Movies.Desktop.MoviesServiceReference.Country GetCountry(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetCountry", ReplyAction="http://tempuri.org/IMoviesService/GetCountryResponse")]
        System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Country> GetCountryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllRoles", ReplyAction="http://tempuri.org/IMoviesService/GetAllRolesResponse")]
        System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Role> GetAllRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllRoles", ReplyAction="http://tempuri.org/IMoviesService/GetAllRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Role>> GetAllRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetRole", ReplyAction="http://tempuri.org/IMoviesService/GetRoleResponse")]
        Movies.Desktop.MoviesServiceReference.Role GetRole(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetRole", ReplyAction="http://tempuri.org/IMoviesService/GetRoleResponse")]
        System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Role> GetRoleAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllPeople", ReplyAction="http://tempuri.org/IMoviesService/GetAllPeopleResponse")]
        System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Person> GetAllPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllPeople", ReplyAction="http://tempuri.org/IMoviesService/GetAllPeopleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Person>> GetAllPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetPerson", ReplyAction="http://tempuri.org/IMoviesService/GetPersonResponse")]
        Movies.Desktop.MoviesServiceReference.Person GetPerson(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetPerson", ReplyAction="http://tempuri.org/IMoviesService/GetPersonResponse")]
        System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Person> GetPersonAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/InsertPerson", ReplyAction="http://tempuri.org/IMoviesService/InsertPersonResponse")]
        bool InsertPerson(Movies.Desktop.MoviesServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/InsertPerson", ReplyAction="http://tempuri.org/IMoviesService/InsertPersonResponse")]
        System.Threading.Tasks.Task<bool> InsertPersonAsync(Movies.Desktop.MoviesServiceReference.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMoviesServiceChannel : Movies.Desktop.MoviesServiceReference.IMoviesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MoviesServiceClient : System.ServiceModel.ClientBase<Movies.Desktop.MoviesServiceReference.IMoviesService>, Movies.Desktop.MoviesServiceReference.IMoviesService {
        
        public MoviesServiceClient() {
        }
        
        public MoviesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Movie> GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Movie>> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public Movies.Desktop.MoviesServiceReference.Movie GetMovie(int id) {
            return base.Channel.GetMovie(id);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Movie> GetMovieAsync(int id) {
            return base.Channel.GetMovieAsync(id);
        }
        
        public bool InsertMovie(Movies.Desktop.MoviesServiceReference.Movie movie) {
            return base.Channel.InsertMovie(movie);
        }
        
        public System.Threading.Tasks.Task<bool> InsertMovieAsync(Movies.Desktop.MoviesServiceReference.Movie movie) {
            return base.Channel.InsertMovieAsync(movie);
        }
        
        public bool UpdateMovie(int id, Movies.Desktop.MoviesServiceReference.Movie movie) {
            return base.Channel.UpdateMovie(id, movie);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateMovieAsync(int id, Movies.Desktop.MoviesServiceReference.Movie movie) {
            return base.Channel.UpdateMovieAsync(id, movie);
        }
        
        public bool DeleteMovie(int id) {
            return base.Channel.DeleteMovie(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMovieAsync(int id) {
            return base.Channel.DeleteMovieAsync(id);
        }
        
        public System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Country> GetAllCountries() {
            return base.Channel.GetAllCountries();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Country>> GetAllCountriesAsync() {
            return base.Channel.GetAllCountriesAsync();
        }
        
        public Movies.Desktop.MoviesServiceReference.Country GetCountry(int id) {
            return base.Channel.GetCountry(id);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Country> GetCountryAsync(int id) {
            return base.Channel.GetCountryAsync(id);
        }
        
        public System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Role> GetAllRoles() {
            return base.Channel.GetAllRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Role>> GetAllRolesAsync() {
            return base.Channel.GetAllRolesAsync();
        }
        
        public Movies.Desktop.MoviesServiceReference.Role GetRole(int id) {
            return base.Channel.GetRole(id);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Role> GetRoleAsync(int id) {
            return base.Channel.GetRoleAsync(id);
        }
        
        public System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Person> GetAllPeople() {
            return base.Channel.GetAllPeople();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Movies.Desktop.MoviesServiceReference.Person>> GetAllPeopleAsync() {
            return base.Channel.GetAllPeopleAsync();
        }
        
        public Movies.Desktop.MoviesServiceReference.Person GetPerson(System.Guid id) {
            return base.Channel.GetPerson(id);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.MoviesServiceReference.Person> GetPersonAsync(System.Guid id) {
            return base.Channel.GetPersonAsync(id);
        }
        
        public bool InsertPerson(Movies.Desktop.MoviesServiceReference.Person person) {
            return base.Channel.InsertPerson(person);
        }
        
        public System.Threading.Tasks.Task<bool> InsertPersonAsync(Movies.Desktop.MoviesServiceReference.Person person) {
            return base.Channel.InsertPersonAsync(person);
        }
    }
}
