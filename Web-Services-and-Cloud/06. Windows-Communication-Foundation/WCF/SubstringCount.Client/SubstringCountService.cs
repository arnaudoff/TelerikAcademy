﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ISubstringCountService")]
public interface ISubstringCountService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubstringCountService/GetOccurencesCount", ReplyAction="http://tempuri.org/ISubstringCountService/GetOccurencesCountResponse")]
    int GetOccurencesCount(string first, string second);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubstringCountService/GetOccurencesCount", ReplyAction="http://tempuri.org/ISubstringCountService/GetOccurencesCountResponse")]
    System.Threading.Tasks.Task<int> GetOccurencesCountAsync(string first, string second);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISubstringCountServiceChannel : ISubstringCountService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SubstringCountServiceClient : System.ServiceModel.ClientBase<ISubstringCountService>, ISubstringCountService
{
    
    public SubstringCountServiceClient()
    {
    }
    
    public SubstringCountServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SubstringCountServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SubstringCountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SubstringCountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int GetOccurencesCount(string first, string second)
    {
        return base.Channel.GetOccurencesCount(first, second);
    }
    
    public System.Threading.Tasks.Task<int> GetOccurencesCountAsync(string first, string second)
    {
        return base.Channel.GetOccurencesCountAsync(first, second);
    }
}