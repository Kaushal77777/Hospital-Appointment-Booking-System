﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.HospitalReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCFservice")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Slot", Namespace="http://schemas.datacontract.org/2004/07/WCFservice")]
    [System.SerializableAttribute()]
    public partial class Slot : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SlotIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserphoneField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SlotID {
            get {
                return this.SlotIDField;
            }
            set {
                if ((this.SlotIDField.Equals(value) != true)) {
                    this.SlotIDField = value;
                    this.RaisePropertyChanged("SlotID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Userphone {
            get {
                return this.UserphoneField;
            }
            set {
                if ((object.ReferenceEquals(this.UserphoneField, value) != true)) {
                    this.UserphoneField = value;
                    this.RaisePropertyChanged("Userphone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HospitalReference.IHospitalService")]
    public interface IHospitalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/GetUser", ReplyAction="http://tempuri.org/IHospitalService/GetUserResponse")]
        Client.HospitalReference.User GetUser(string phone, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/GetUser", ReplyAction="http://tempuri.org/IHospitalService/GetUserResponse")]
        System.Threading.Tasks.Task<Client.HospitalReference.User> GetUserAsync(string phone, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/SetUser", ReplyAction="http://tempuri.org/IHospitalService/SetUserResponse")]
        void SetUser(Client.HospitalReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/SetUser", ReplyAction="http://tempuri.org/IHospitalService/SetUserResponse")]
        System.Threading.Tasks.Task SetUserAsync(Client.HospitalReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/GetSlot", ReplyAction="http://tempuri.org/IHospitalService/GetSlotResponse")]
        Client.HospitalReference.Slot GetSlot(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/GetSlot", ReplyAction="http://tempuri.org/IHospitalService/GetSlotResponse")]
        System.Threading.Tasks.Task<Client.HospitalReference.Slot> GetSlotAsync(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/SetSlot", ReplyAction="http://tempuri.org/IHospitalService/SetSlotResponse")]
        void SetSlot(Client.HospitalReference.Slot slot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHospitalService/SetSlot", ReplyAction="http://tempuri.org/IHospitalService/SetSlotResponse")]
        System.Threading.Tasks.Task SetSlotAsync(Client.HospitalReference.Slot slot);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHospitalServiceChannel : Client.HospitalReference.IHospitalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HospitalServiceClient : System.ServiceModel.ClientBase<Client.HospitalReference.IHospitalService>, Client.HospitalReference.IHospitalService {
        
        public HospitalServiceClient() {
        }
        
        public HospitalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HospitalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HospitalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HospitalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.HospitalReference.User GetUser(string phone, string password) {
            return base.Channel.GetUser(phone, password);
        }
        
        public System.Threading.Tasks.Task<Client.HospitalReference.User> GetUserAsync(string phone, string password) {
            return base.Channel.GetUserAsync(phone, password);
        }
        
        public void SetUser(Client.HospitalReference.User user) {
            base.Channel.SetUser(user);
        }
        
        public System.Threading.Tasks.Task SetUserAsync(Client.HospitalReference.User user) {
            return base.Channel.SetUserAsync(user);
        }
        
        public Client.HospitalReference.Slot GetSlot(string phone) {
            return base.Channel.GetSlot(phone);
        }
        
        public System.Threading.Tasks.Task<Client.HospitalReference.Slot> GetSlotAsync(string phone) {
            return base.Channel.GetSlotAsync(phone);
        }
        
        public void SetSlot(Client.HospitalReference.Slot slot) {
            base.Channel.SetSlot(slot);
        }
        
        public System.Threading.Tasks.Task SetSlotAsync(Client.HospitalReference.Slot slot) {
            return base.Channel.SetSlotAsync(slot);
        }
    }
}