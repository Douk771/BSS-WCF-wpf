﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/BookStoreService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/BookStoreService")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idAuthorField;
        
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
        public string FIO {
            get {
                return this.FIOField;
            }
            set {
                if ((object.ReferenceEquals(this.FIOField, value) != true)) {
                    this.FIOField = value;
                    this.RaisePropertyChanged("FIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idAuthor {
            get {
                return this.idAuthorField;
            }
            set {
                if ((this.idAuthorField.Equals(value) != true)) {
                    this.idAuthorField = value;
                    this.RaisePropertyChanged("idAuthor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AvailabilityBooks", Namespace="http://schemas.datacontract.org/2004/07/BookStoreService")]
    [System.SerializableAttribute()]
    public partial class AvailabilityBooks : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AithorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StoreNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SupplierNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Aithors {
            get {
                return this.AithorsField;
            }
            set {
                if ((object.ReferenceEquals(this.AithorsField, value) != true)) {
                    this.AithorsField = value;
                    this.RaisePropertyChanged("Aithors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StoreName {
            get {
                return this.StoreNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreNameField, value) != true)) {
                    this.StoreNameField = value;
                    this.RaisePropertyChanged("StoreName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SupplierName {
            get {
                return this.SupplierNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SupplierNameField, value) != true)) {
                    this.SupplierNameField = value;
                    this.RaisePropertyChanged("SupplierName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AvailabilityBooksInStore_Result", Namespace="http://schemas.datacontract.org/2004/07/BookStoreService")]
    [System.SerializableAttribute()]
    public partial class AvailabilityBooksInStore_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string FIO {
            get {
                return this.FIOField;
            }
            set {
                if ((object.ReferenceEquals(this.FIOField, value) != true)) {
                    this.FIOField = value;
                    this.RaisePropertyChanged("FIO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        WindowsFormsApp1.ServiceReference.CompositeType GetDataUsingDataContract(WindowsFormsApp1.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApp1.ServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAuthors", ReplyAction="http://tempuri.org/IService/SelectAuthorsResponse")]
        WindowsFormsApp1.ServiceReference.Author[] SelectAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SelectAuthors", ReplyAction="http://tempuri.org/IService/SelectAuthorsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.Author[]> SelectAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateAutor", ReplyAction="http://tempuri.org/IService/CreateAutorResponse")]
        void CreateAutor(string FIO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateAutor", ReplyAction="http://tempuri.org/IService/CreateAutorResponse")]
        System.Threading.Tasks.Task CreateAutorAsync(string FIO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AvailabilityBooks", ReplyAction="http://tempuri.org/IService/AvailabilityBooksResponse")]
        WindowsFormsApp1.ServiceReference.AvailabilityBooks[] AvailabilityBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AvailabilityBooks", ReplyAction="http://tempuri.org/IService/AvailabilityBooksResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.AvailabilityBooks[]> AvailabilityBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AutorsInStore", ReplyAction="http://tempuri.org/IService/AutorsInStoreResponse")]
        WindowsFormsApp1.ServiceReference.AvailabilityBooksInStore_Result[] AutorsInStore(int idStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AutorsInStore", ReplyAction="http://tempuri.org/IService/AutorsInStoreResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.AvailabilityBooksInStore_Result[]> AutorsInStoreAsync(int idStore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/StoreIdName", ReplyAction="http://tempuri.org/IService/StoreIdNameResponse")]
        System.Collections.Generic.Dictionary<int, string> StoreIdName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/StoreIdName", ReplyAction="http://tempuri.org/IService/StoreIdNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> StoreIdNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WindowsFormsApp1.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference.IService>, WindowsFormsApp1.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WindowsFormsApp1.ServiceReference.CompositeType GetDataUsingDataContract(WindowsFormsApp1.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.CompositeType> GetDataUsingDataContractAsync(WindowsFormsApp1.ServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WindowsFormsApp1.ServiceReference.Author[] SelectAuthors() {
            return base.Channel.SelectAuthors();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.Author[]> SelectAuthorsAsync() {
            return base.Channel.SelectAuthorsAsync();
        }
        
        public void CreateAutor(string FIO) {
            base.Channel.CreateAutor(FIO);
        }
        
        public System.Threading.Tasks.Task CreateAutorAsync(string FIO) {
            return base.Channel.CreateAutorAsync(FIO);
        }
        
        public WindowsFormsApp1.ServiceReference.AvailabilityBooks[] AvailabilityBooks() {
            return base.Channel.AvailabilityBooks();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.AvailabilityBooks[]> AvailabilityBooksAsync() {
            return base.Channel.AvailabilityBooksAsync();
        }
        
        public WindowsFormsApp1.ServiceReference.AvailabilityBooksInStore_Result[] AutorsInStore(int idStore) {
            return base.Channel.AutorsInStore(idStore);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference.AvailabilityBooksInStore_Result[]> AutorsInStoreAsync(int idStore) {
            return base.Channel.AutorsInStoreAsync(idStore);
        }
        
        public System.Collections.Generic.Dictionary<int, string> StoreIdName() {
            return base.Channel.StoreIdName();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> StoreIdNameAsync() {
            return base.Channel.StoreIdNameAsync();
        }
    }
}