﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies.Desktop.RolesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RolesServiceReference.RolesServiceSoap")]
    public interface RolesServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetAllRolesResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRoles", ReplyAction="*")]
        Movies.Desktop.RolesServiceReference.GetAllRolesResponse GetAllRoles(Movies.Desktop.RolesServiceReference.GetAllRolesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllRoles", ReplyAction="*")]
        System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetAllRolesResponse> GetAllRolesAsync(Movies.Desktop.RolesServiceReference.GetAllRolesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetRoleResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRole", ReplyAction="*")]
        Movies.Desktop.RolesServiceReference.GetRoleResponse GetRole(Movies.Desktop.RolesServiceReference.GetRoleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRole", ReplyAction="*")]
        System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetRoleResponse> GetRoleAsync(Movies.Desktop.RolesServiceReference.GetRoleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRolesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRoles", Namespace="http://tempuri.org/", Order=0)]
        public Movies.Desktop.RolesServiceReference.GetAllRolesRequestBody Body;
        
        public GetAllRolesRequest() {
        }
        
        public GetAllRolesRequest(Movies.Desktop.RolesServiceReference.GetAllRolesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRolesRequestBody {
        
        public GetAllRolesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRolesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllRolesResponse", Namespace="http://tempuri.org/", Order=0)]
        public Movies.Desktop.RolesServiceReference.GetAllRolesResponseBody Body;
        
        public GetAllRolesResponse() {
        }
        
        public GetAllRolesResponse(Movies.Desktop.RolesServiceReference.GetAllRolesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllRolesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Movies.Desktop.RolesServiceReference.Role[] GetAllRolesResult;
        
        public GetAllRolesResponseBody() {
        }
        
        public GetAllRolesResponseBody(Movies.Desktop.RolesServiceReference.Role[] GetAllRolesResult) {
            this.GetAllRolesResult = GetAllRolesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRole", Namespace="http://tempuri.org/", Order=0)]
        public Movies.Desktop.RolesServiceReference.GetRoleRequestBody Body;
        
        public GetRoleRequest() {
        }
        
        public GetRoleRequest(Movies.Desktop.RolesServiceReference.GetRoleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRoleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetRoleRequestBody() {
        }
        
        public GetRoleRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRoleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRoleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Movies.Desktop.RolesServiceReference.GetRoleResponseBody Body;
        
        public GetRoleResponse() {
        }
        
        public GetRoleResponse(Movies.Desktop.RolesServiceReference.GetRoleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetRoleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Movies.Desktop.RolesServiceReference.Role GetRoleResult;
        
        public GetRoleResponseBody() {
        }
        
        public GetRoleResponseBody(Movies.Desktop.RolesServiceReference.Role GetRoleResult) {
            this.GetRoleResult = GetRoleResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RolesServiceSoapChannel : Movies.Desktop.RolesServiceReference.RolesServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RolesServiceSoapClient : System.ServiceModel.ClientBase<Movies.Desktop.RolesServiceReference.RolesServiceSoap>, Movies.Desktop.RolesServiceReference.RolesServiceSoap {
        
        public RolesServiceSoapClient() {
        }
        
        public RolesServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RolesServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RolesServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RolesServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Movies.Desktop.RolesServiceReference.GetAllRolesResponse Movies.Desktop.RolesServiceReference.RolesServiceSoap.GetAllRoles(Movies.Desktop.RolesServiceReference.GetAllRolesRequest request) {
            return base.Channel.GetAllRoles(request);
        }
        
        public Movies.Desktop.RolesServiceReference.Role[] GetAllRoles() {
            Movies.Desktop.RolesServiceReference.GetAllRolesRequest inValue = new Movies.Desktop.RolesServiceReference.GetAllRolesRequest();
            inValue.Body = new Movies.Desktop.RolesServiceReference.GetAllRolesRequestBody();
            Movies.Desktop.RolesServiceReference.GetAllRolesResponse retVal = ((Movies.Desktop.RolesServiceReference.RolesServiceSoap)(this)).GetAllRoles(inValue);
            return retVal.Body.GetAllRolesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetAllRolesResponse> Movies.Desktop.RolesServiceReference.RolesServiceSoap.GetAllRolesAsync(Movies.Desktop.RolesServiceReference.GetAllRolesRequest request) {
            return base.Channel.GetAllRolesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetAllRolesResponse> GetAllRolesAsync() {
            Movies.Desktop.RolesServiceReference.GetAllRolesRequest inValue = new Movies.Desktop.RolesServiceReference.GetAllRolesRequest();
            inValue.Body = new Movies.Desktop.RolesServiceReference.GetAllRolesRequestBody();
            return ((Movies.Desktop.RolesServiceReference.RolesServiceSoap)(this)).GetAllRolesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Movies.Desktop.RolesServiceReference.GetRoleResponse Movies.Desktop.RolesServiceReference.RolesServiceSoap.GetRole(Movies.Desktop.RolesServiceReference.GetRoleRequest request) {
            return base.Channel.GetRole(request);
        }
        
        public Movies.Desktop.RolesServiceReference.Role GetRole(int id) {
            Movies.Desktop.RolesServiceReference.GetRoleRequest inValue = new Movies.Desktop.RolesServiceReference.GetRoleRequest();
            inValue.Body = new Movies.Desktop.RolesServiceReference.GetRoleRequestBody();
            inValue.Body.id = id;
            Movies.Desktop.RolesServiceReference.GetRoleResponse retVal = ((Movies.Desktop.RolesServiceReference.RolesServiceSoap)(this)).GetRole(inValue);
            return retVal.Body.GetRoleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetRoleResponse> Movies.Desktop.RolesServiceReference.RolesServiceSoap.GetRoleAsync(Movies.Desktop.RolesServiceReference.GetRoleRequest request) {
            return base.Channel.GetRoleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Movies.Desktop.RolesServiceReference.GetRoleResponse> GetRoleAsync(int id) {
            Movies.Desktop.RolesServiceReference.GetRoleRequest inValue = new Movies.Desktop.RolesServiceReference.GetRoleRequest();
            inValue.Body = new Movies.Desktop.RolesServiceReference.GetRoleRequestBody();
            inValue.Body.id = id;
            return ((Movies.Desktop.RolesServiceReference.RolesServiceSoap)(this)).GetRoleAsync(inValue);
        }
    }
}
