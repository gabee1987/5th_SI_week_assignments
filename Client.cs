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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDerivativesCalculator")]
public interface IDerivativesCalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDerivativesCalculator/CalculateDerivative", ReplyAction="http://tempuri.org/IDerivativesCalculator/CalculateDerivativeResponse")]
    decimal CalculateDerivative(int days, string[] symbols, string[] functions);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDerivativesCalculator/CalculateDerivative", ReplyAction="http://tempuri.org/IDerivativesCalculator/CalculateDerivativeResponse")]
    System.Threading.Tasks.Task<decimal> CalculateDerivativeAsync(int days, string[] symbols, string[] functions);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDerivativesCalculatorChannel : IDerivativesCalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DerivativesCalculatorClient : System.ServiceModel.ClientBase<IDerivativesCalculator>, IDerivativesCalculator
{
    
    public DerivativesCalculatorClient()
    {
    }
    
    public DerivativesCalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public DerivativesCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DerivativesCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DerivativesCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public decimal CalculateDerivative(int days, string[] symbols, string[] functions)
    {
        return base.Channel.CalculateDerivative(days, symbols, functions);
    }
    
    public System.Threading.Tasks.Task<decimal> CalculateDerivativeAsync(int days, string[] symbols, string[] functions)
    {
        return base.Channel.CalculateDerivativeAsync(days, symbols, functions);
    }
}
