﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OutputData", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class OutputData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] leftGyroXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] leftGyroYField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] leftGyroZField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double leftTurnsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] responsesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] rightGyroXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] rightGyroYField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] rightGyroZField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double rightTurnsField;
        
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
        public double[] leftGyroX {
            get {
                return this.leftGyroXField;
            }
            set {
                if ((object.ReferenceEquals(this.leftGyroXField, value) != true)) {
                    this.leftGyroXField = value;
                    this.RaisePropertyChanged("leftGyroX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] leftGyroY {
            get {
                return this.leftGyroYField;
            }
            set {
                if ((object.ReferenceEquals(this.leftGyroYField, value) != true)) {
                    this.leftGyroYField = value;
                    this.RaisePropertyChanged("leftGyroY");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] leftGyroZ {
            get {
                return this.leftGyroZField;
            }
            set {
                if ((object.ReferenceEquals(this.leftGyroZField, value) != true)) {
                    this.leftGyroZField = value;
                    this.RaisePropertyChanged("leftGyroZ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double leftTurns {
            get {
                return this.leftTurnsField;
            }
            set {
                if ((this.leftTurnsField.Equals(value) != true)) {
                    this.leftTurnsField = value;
                    this.RaisePropertyChanged("leftTurns");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] responses {
            get {
                return this.responsesField;
            }
            set {
                if ((object.ReferenceEquals(this.responsesField, value) != true)) {
                    this.responsesField = value;
                    this.RaisePropertyChanged("responses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] rightGyroX {
            get {
                return this.rightGyroXField;
            }
            set {
                if ((object.ReferenceEquals(this.rightGyroXField, value) != true)) {
                    this.rightGyroXField = value;
                    this.RaisePropertyChanged("rightGyroX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] rightGyroY {
            get {
                return this.rightGyroYField;
            }
            set {
                if ((object.ReferenceEquals(this.rightGyroYField, value) != true)) {
                    this.rightGyroYField = value;
                    this.RaisePropertyChanged("rightGyroY");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] rightGyroZ {
            get {
                return this.rightGyroZField;
            }
            set {
                if ((object.ReferenceEquals(this.rightGyroZField, value) != true)) {
                    this.rightGyroZField = value;
                    this.RaisePropertyChanged("rightGyroZ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double rightTurns {
            get {
                return this.rightTurnsField;
            }
            set {
                if ((this.rightTurnsField.Equals(value) != true)) {
                    this.rightTurnsField = value;
                    this.RaisePropertyChanged("rightTurns");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendPackage", ReplyAction="http://tempuri.org/IService/SendPackageResponse")]
        void SendPackage(byte[] rawData, int numberOfpackages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendPackage", ReplyAction="http://tempuri.org/IService/SendPackageResponse")]
        System.Threading.Tasks.Task SendPackageAsync(byte[] rawData, int numberOfpackages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DetectTurns", ReplyAction="http://tempuri.org/IService/DetectTurnsResponse")]
        WindowsFormsApp.ServiceReference.OutputData DetectTurns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DetectTurns", ReplyAction="http://tempuri.org/IService/DetectTurnsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp.ServiceReference.OutputData> DetectTurnsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WindowsFormsApp.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp.ServiceReference.IService>, WindowsFormsApp.ServiceReference.IService {
        
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
        
        public void SendPackage(byte[] rawData, int numberOfpackages) {
            base.Channel.SendPackage(rawData, numberOfpackages);
        }
        
        public System.Threading.Tasks.Task SendPackageAsync(byte[] rawData, int numberOfpackages) {
            return base.Channel.SendPackageAsync(rawData, numberOfpackages);
        }
        
        public WindowsFormsApp.ServiceReference.OutputData DetectTurns() {
            return base.Channel.DetectTurns();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp.ServiceReference.OutputData> DetectTurnsAsync() {
            return base.Channel.DetectTurnsAsync();
        }
    }
}
