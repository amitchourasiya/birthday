﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Application.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/BirthdayService")]
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeList", ReplyAction="http://tempuri.org/IService1/GetEmployeeListResponse")]
        Client.Application.ServiceReference1.GetEmployeeListResponse GetEmployeeList(Client.Application.ServiceReference1.GetEmployeeListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeList", ReplyAction="http://tempuri.org/IService1/GetEmployeeListResponse")]
        System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetEmployeeListResponse> GetEmployeeListAsync(Client.Application.ServiceReference1.GetEmployeeListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeExclusion", ReplyAction="http://tempuri.org/IService1/GetEmployeeExclusionResponse")]
        Client.Application.ServiceReference1.GetEmployeeExclusionResponse GetEmployeeExclusion(Client.Application.ServiceReference1.GetEmployeeExclusionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeExclusion", ReplyAction="http://tempuri.org/IService1/GetEmployeeExclusionResponse")]
        System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetEmployeeExclusionResponse> GetEmployeeExclusionAsync(Client.Application.ServiceReference1.GetEmployeeExclusionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        Client.Application.ServiceReference1.GetDataResponse GetData(Client.Application.ServiceReference1.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetDataResponse> GetDataAsync(Client.Application.ServiceReference1.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Client.Application.ServiceReference1.GetDataUsingDataContractResponse GetDataUsingDataContract(Client.Application.ServiceReference1.GetDataUsingDataContractRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetDataUsingDataContractResponse> GetDataUsingDataContractAsync(Client.Application.ServiceReference1.GetDataUsingDataContractRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeListRequest {
        
        public GetEmployeeListRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ACME.EmplyeeBirthdayWish.CrossCutting.DTO.Employee[] GetEmployeeListResult;
        
        public GetEmployeeListResponse() {
        }
        
        public GetEmployeeListResponse(ACME.EmplyeeBirthdayWish.CrossCutting.DTO.Employee[] GetEmployeeListResult) {
            this.GetEmployeeListResult = GetEmployeeListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeExclusion", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeExclusionRequest {
        
        public GetEmployeeExclusionRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeExclusionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeExclusionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ACME.EmplyeeBirthdayWish.CrossCutting.DTO.EmployeeExclusion[] GetEmployeeExclusionResult;
        
        public GetEmployeeExclusionResponse() {
        }
        
        public GetEmployeeExclusionResponse(ACME.EmplyeeBirthdayWish.CrossCutting.DTO.EmployeeExclusion[] GetEmployeeExclusionResult) {
            this.GetEmployeeExclusionResult = GetEmployeeExclusionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        public GetDataRequest() {
        }
        
        public GetDataRequest(int value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetDataResult;
        
        public GetDataResponse() {
        }
        
        public GetDataResponse(string GetDataResult) {
            this.GetDataResult = GetDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataUsingDataContract", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataUsingDataContractRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.Application.ServiceReference1.CompositeType composite;
        
        public GetDataUsingDataContractRequest() {
        }
        
        public GetDataUsingDataContractRequest(Client.Application.ServiceReference1.CompositeType composite) {
            this.composite = composite;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataUsingDataContractResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataUsingDataContractResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.Application.ServiceReference1.CompositeType GetDataUsingDataContractResult;
        
        public GetDataUsingDataContractResponse() {
        }
        
        public GetDataUsingDataContractResponse(Client.Application.ServiceReference1.CompositeType GetDataUsingDataContractResult) {
            this.GetDataUsingDataContractResult = GetDataUsingDataContractResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.Application.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.Application.ServiceReference1.IService1>, Client.Application.ServiceReference1.IService1 {
        
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
        
        public Client.Application.ServiceReference1.GetEmployeeListResponse GetEmployeeList(Client.Application.ServiceReference1.GetEmployeeListRequest request) {
            return base.Channel.GetEmployeeList(request);
        }
        
        public System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetEmployeeListResponse> GetEmployeeListAsync(Client.Application.ServiceReference1.GetEmployeeListRequest request) {
            return base.Channel.GetEmployeeListAsync(request);
        }
        
        public Client.Application.ServiceReference1.GetEmployeeExclusionResponse GetEmployeeExclusion(Client.Application.ServiceReference1.GetEmployeeExclusionRequest request) {
            return base.Channel.GetEmployeeExclusion(request);
        }
        
        public System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetEmployeeExclusionResponse> GetEmployeeExclusionAsync(Client.Application.ServiceReference1.GetEmployeeExclusionRequest request) {
            return base.Channel.GetEmployeeExclusionAsync(request);
        }
        
        public Client.Application.ServiceReference1.GetDataResponse GetData(Client.Application.ServiceReference1.GetDataRequest request) {
            return base.Channel.GetData(request);
        }
        
        public System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetDataResponse> GetDataAsync(Client.Application.ServiceReference1.GetDataRequest request) {
            return base.Channel.GetDataAsync(request);
        }
        
        public Client.Application.ServiceReference1.GetDataUsingDataContractResponse GetDataUsingDataContract(Client.Application.ServiceReference1.GetDataUsingDataContractRequest request) {
            return base.Channel.GetDataUsingDataContract(request);
        }
        
        public System.Threading.Tasks.Task<Client.Application.ServiceReference1.GetDataUsingDataContractResponse> GetDataUsingDataContractAsync(Client.Application.ServiceReference1.GetDataUsingDataContractRequest request) {
            return base.Channel.GetDataUsingDataContractAsync(request);
        }
    }
}