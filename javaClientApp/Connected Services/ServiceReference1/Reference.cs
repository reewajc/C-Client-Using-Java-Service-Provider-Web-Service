﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace javaClientApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://db_emulator/", ConfigurationName="ServiceReference1.ProductDB_APIDelegate")]
    public interface ProductDB_APIDelegate {
        
        // CODEGEN: Generating message contract since element name arg0 from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://db_emulator/ProductDB_APIDelegate/getProductRequest", ReplyAction="http://db_emulator/ProductDB_APIDelegate/getProductResponse")]
        javaClientApp.ServiceReference1.getProductResponse getProduct(javaClientApp.ServiceReference1.getProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db_emulator/ProductDB_APIDelegate/getProductRequest", ReplyAction="http://db_emulator/ProductDB_APIDelegate/getProductResponse")]
        System.Threading.Tasks.Task<javaClientApp.ServiceReference1.getProductResponse> getProductAsync(javaClientApp.ServiceReference1.getProductRequest request);
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://db_emulator/ProductDB_APIDelegate/createProductDB_ObjectRequest", ReplyAction="http://db_emulator/ProductDB_APIDelegate/createProductDB_ObjectResponse")]
        javaClientApp.ServiceReference1.createProductDB_ObjectResponse createProductDB_Object(javaClientApp.ServiceReference1.createProductDB_ObjectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://db_emulator/ProductDB_APIDelegate/createProductDB_ObjectRequest", ReplyAction="http://db_emulator/ProductDB_APIDelegate/createProductDB_ObjectResponse")]
        System.Threading.Tasks.Task<javaClientApp.ServiceReference1.createProductDB_ObjectResponse> createProductDB_ObjectAsync(javaClientApp.ServiceReference1.createProductDB_ObjectRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getProduct", Namespace="http://db_emulator/", Order=0)]
        public javaClientApp.ServiceReference1.getProductRequestBody Body;
        
        public getProductRequest() {
        }
        
        public getProductRequest(javaClientApp.ServiceReference1.getProductRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getProductRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public getProductRequestBody() {
        }
        
        public getProductRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getProductResponse", Namespace="http://db_emulator/", Order=0)]
        public javaClientApp.ServiceReference1.getProductResponseBody Body;
        
        public getProductResponse() {
        }
        
        public getProductResponse(javaClientApp.ServiceReference1.getProductResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class getProductResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public getProductResponseBody() {
        }
        
        public getProductResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createProductDB_ObjectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createProductDB_Object", Namespace="http://db_emulator/", Order=0)]
        public javaClientApp.ServiceReference1.createProductDB_ObjectRequestBody Body;
        
        public createProductDB_ObjectRequest() {
        }
        
        public createProductDB_ObjectRequest(javaClientApp.ServiceReference1.createProductDB_ObjectRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class createProductDB_ObjectRequestBody {
        
        public createProductDB_ObjectRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createProductDB_ObjectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createProductDB_ObjectResponse", Namespace="http://db_emulator/", Order=0)]
        public javaClientApp.ServiceReference1.createProductDB_ObjectResponseBody Body;
        
        public createProductDB_ObjectResponse() {
        }
        
        public createProductDB_ObjectResponse(javaClientApp.ServiceReference1.createProductDB_ObjectResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class createProductDB_ObjectResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public createProductDB_ObjectResponseBody() {
        }
        
        public createProductDB_ObjectResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductDB_APIDelegateChannel : javaClientApp.ServiceReference1.ProductDB_APIDelegate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductDB_APIDelegateClient : System.ServiceModel.ClientBase<javaClientApp.ServiceReference1.ProductDB_APIDelegate>, javaClientApp.ServiceReference1.ProductDB_APIDelegate {
        
        public ProductDB_APIDelegateClient() {
        }
        
        public ProductDB_APIDelegateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductDB_APIDelegateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductDB_APIDelegateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductDB_APIDelegateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        javaClientApp.ServiceReference1.getProductResponse javaClientApp.ServiceReference1.ProductDB_APIDelegate.getProduct(javaClientApp.ServiceReference1.getProductRequest request) {
            return base.Channel.getProduct(request);
        }
        
        public string getProduct(string arg0) {
            javaClientApp.ServiceReference1.getProductRequest inValue = new javaClientApp.ServiceReference1.getProductRequest();
            inValue.Body = new javaClientApp.ServiceReference1.getProductRequestBody();
            inValue.Body.arg0 = arg0;
            javaClientApp.ServiceReference1.getProductResponse retVal = ((javaClientApp.ServiceReference1.ProductDB_APIDelegate)(this)).getProduct(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<javaClientApp.ServiceReference1.getProductResponse> javaClientApp.ServiceReference1.ProductDB_APIDelegate.getProductAsync(javaClientApp.ServiceReference1.getProductRequest request) {
            return base.Channel.getProductAsync(request);
        }
        
        public System.Threading.Tasks.Task<javaClientApp.ServiceReference1.getProductResponse> getProductAsync(string arg0) {
            javaClientApp.ServiceReference1.getProductRequest inValue = new javaClientApp.ServiceReference1.getProductRequest();
            inValue.Body = new javaClientApp.ServiceReference1.getProductRequestBody();
            inValue.Body.arg0 = arg0;
            return ((javaClientApp.ServiceReference1.ProductDB_APIDelegate)(this)).getProductAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        javaClientApp.ServiceReference1.createProductDB_ObjectResponse javaClientApp.ServiceReference1.ProductDB_APIDelegate.createProductDB_Object(javaClientApp.ServiceReference1.createProductDB_ObjectRequest request) {
            return base.Channel.createProductDB_Object(request);
        }
        
        public string createProductDB_Object() {
            javaClientApp.ServiceReference1.createProductDB_ObjectRequest inValue = new javaClientApp.ServiceReference1.createProductDB_ObjectRequest();
            inValue.Body = new javaClientApp.ServiceReference1.createProductDB_ObjectRequestBody();
            javaClientApp.ServiceReference1.createProductDB_ObjectResponse retVal = ((javaClientApp.ServiceReference1.ProductDB_APIDelegate)(this)).createProductDB_Object(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<javaClientApp.ServiceReference1.createProductDB_ObjectResponse> javaClientApp.ServiceReference1.ProductDB_APIDelegate.createProductDB_ObjectAsync(javaClientApp.ServiceReference1.createProductDB_ObjectRequest request) {
            return base.Channel.createProductDB_ObjectAsync(request);
        }
        
        public System.Threading.Tasks.Task<javaClientApp.ServiceReference1.createProductDB_ObjectResponse> createProductDB_ObjectAsync() {
            javaClientApp.ServiceReference1.createProductDB_ObjectRequest inValue = new javaClientApp.ServiceReference1.createProductDB_ObjectRequest();
            inValue.Body = new javaClientApp.ServiceReference1.createProductDB_ObjectRequestBody();
            return ((javaClientApp.ServiceReference1.ProductDB_APIDelegate)(this)).createProductDB_ObjectAsync(inValue);
        }
    }
}
