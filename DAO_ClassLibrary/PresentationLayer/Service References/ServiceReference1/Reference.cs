﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        PresentationLayer.ServiceReference1.CompositeType GetDataUsingDataContract(PresentationLayer.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(PresentationLayer.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addDummy", ReplyAction="http://tempuri.org/IService1/addDummyResponse")]
        void addDummy(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addDummy", ReplyAction="http://tempuri.org/IService1/addDummyResponse")]
        System.Threading.Tasks.Task addDummyAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDummy", ReplyAction="http://tempuri.org/IService1/deleteDummyResponse")]
        void deleteDummy(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDummy", ReplyAction="http://tempuri.org/IService1/deleteDummyResponse")]
        System.Threading.Tasks.Task deleteDummyAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchDummy", ReplyAction="http://tempuri.org/IService1/SearchDummyResponse")]
        System.Data.DataSet SearchDummy(int ID_toSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchDummy", ReplyAction="http://tempuri.org/IService1/SearchDummyResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchDummyAsync(int ID_toSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDummy", ReplyAction="http://tempuri.org/IService1/UpdateDummyResponse")]
        void UpdateDummy(int ID, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDummy", ReplyAction="http://tempuri.org/IService1/UpdateDummyResponse")]
        System.Threading.Tasks.Task UpdateDummyAsync(int ID, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewALLDummy", ReplyAction="http://tempuri.org/IService1/viewALLDummyResponse")]
        System.Data.DataSet viewALLDummy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewALLDummy", ReplyAction="http://tempuri.org/IService1/viewALLDummyResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> viewALLDummyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PresentationLayer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PresentationLayer.ServiceReference1.IService1>, PresentationLayer.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public PresentationLayer.ServiceReference1.CompositeType GetDataUsingDataContract(PresentationLayer.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(PresentationLayer.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void addDummy(string name) {
            base.Channel.addDummy(name);
        }
        
        public System.Threading.Tasks.Task addDummyAsync(string name) {
            return base.Channel.addDummyAsync(name);
        }
        
        public void deleteDummy(int ID) {
            base.Channel.deleteDummy(ID);
        }
        
        public System.Threading.Tasks.Task deleteDummyAsync(int ID) {
            return base.Channel.deleteDummyAsync(ID);
        }
        
        public System.Data.DataSet SearchDummy(int ID_toSearch) {
            return base.Channel.SearchDummy(ID_toSearch);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchDummyAsync(int ID_toSearch) {
            return base.Channel.SearchDummyAsync(ID_toSearch);
        }
        
        public void UpdateDummy(int ID, string Name) {
            base.Channel.UpdateDummy(ID, Name);
        }
        
        public System.Threading.Tasks.Task UpdateDummyAsync(int ID, string Name) {
            return base.Channel.UpdateDummyAsync(ID, Name);
        }
        
        public System.Data.DataSet viewALLDummy() {
            return base.Channel.viewALLDummy();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> viewALLDummyAsync() {
            return base.Channel.viewALLDummyAsync();
        }
    }
}