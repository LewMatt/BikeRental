﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeRental.ClientApp.BikeRentalService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BikeRentalService.IBikeRentalService")]
    public interface IBikeRentalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeRentalService/AddUser", ReplyAction="http://tempuri.org/IBikeRentalService/AddUserResponse")]
        void AddUser(string login, string password, string name, string surname, string phone, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBikeRentalService/AddUser", ReplyAction="http://tempuri.org/IBikeRentalService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string login, string password, string name, string surname, string phone, string address);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBikeRentalServiceChannel : BikeRental.ClientApp.BikeRentalService.IBikeRentalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BikeRentalServiceClient : System.ServiceModel.ClientBase<BikeRental.ClientApp.BikeRentalService.IBikeRentalService>, BikeRental.ClientApp.BikeRentalService.IBikeRentalService {
        
        public BikeRentalServiceClient() {
        }
        
        public BikeRentalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BikeRentalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BikeRentalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BikeRentalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUser(string login, string password, string name, string surname, string phone, string address) {
            base.Channel.AddUser(login, password, name, surname, phone, address);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string login, string password, string name, string surname, string phone, string address) {
            return base.Channel.AddUserAsync(login, password, name, surname, phone, address);
        }
    }
}
