//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KB_Guadalupana.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoTabla", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable buscarcreditoTabla(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoTabla", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> buscarcreditoTablaAsync(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcredito", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string buscarcredito(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcredito", ReplyAction="*")]
        System.Threading.Tasks.Task<string> buscarcreditoAsync(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarresponsables", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscarresponsables(string variabledebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarresponsables", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarresponsablesAsync(string variabledebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditosasociados", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscarcreditosasociados(string valordebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditosasociados", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarcreditosasociadosAsync(string valordebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoporcif", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet buscarcreditoporcif(string valordebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoporcif", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> buscarcreditoporcifAsync(string valordebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoexpedientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string buscarcreditoexpedientes(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarcreditoexpedientes", ReplyAction="*")]
        System.Threading.Tasks.Task<string> buscarcreditoexpedientesAsync(string variablebusqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacolocacionesnegocios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultacolocacionesnegocios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacolocacionesnegocios", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacolocacionesnegociosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacaptacionesnegocios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultacaptacionesnegocios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacaptacionesnegocios", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacaptacionesnegociosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistoricocolocaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultagistoricocolocaciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistoricocolocaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistoricocolocacionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistorrecuperacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultagistorrecuperacion(string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistorrecuperacion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistorrecuperacionAsync(string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistoricocolo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultagistoricocolo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultagistoricocolo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistoricocoloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrocolocaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultacantidadregistrocolocaciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrocolocaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrocolocacionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrocaptaciones", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultacantidadregistrocaptaciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrocaptaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrocaptacionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrorecuperacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet cargarconsultacantidadregistrorecuperacion(string fecha1, string fecha2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cargarconsultacantidadregistrorecuperacion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrorecuperacionAsync(string fecha1, string fecha2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : KB_Guadalupana.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<KB_Guadalupana.ServiceReference1.WebService1Soap>, KB_Guadalupana.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataTable buscarcreditoTabla(string variablebusqueda) {
            return base.Channel.buscarcreditoTabla(variablebusqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> buscarcreditoTablaAsync(string variablebusqueda) {
            return base.Channel.buscarcreditoTablaAsync(variablebusqueda);
        }
        
        public string buscarcredito(string variablebusqueda) {
            return base.Channel.buscarcredito(variablebusqueda);
        }
        
        public System.Threading.Tasks.Task<string> buscarcreditoAsync(string variablebusqueda) {
            return base.Channel.buscarcreditoAsync(variablebusqueda);
        }
        
        public System.Data.DataSet buscarresponsables(string variabledebusqueda) {
            return base.Channel.buscarresponsables(variabledebusqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarresponsablesAsync(string variabledebusqueda) {
            return base.Channel.buscarresponsablesAsync(variabledebusqueda);
        }
        
        public System.Data.DataSet buscarcreditosasociados(string valordebusqueda) {
            return base.Channel.buscarcreditosasociados(valordebusqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarcreditosasociadosAsync(string valordebusqueda) {
            return base.Channel.buscarcreditosasociadosAsync(valordebusqueda);
        }
        
        public System.Data.DataSet buscarcreditoporcif(string valordebusqueda) {
            return base.Channel.buscarcreditoporcif(valordebusqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> buscarcreditoporcifAsync(string valordebusqueda) {
            return base.Channel.buscarcreditoporcifAsync(valordebusqueda);
        }
        
        public string buscarcreditoexpedientes(string variablebusqueda) {
            return base.Channel.buscarcreditoexpedientes(variablebusqueda);
        }
        
        public System.Threading.Tasks.Task<string> buscarcreditoexpedientesAsync(string variablebusqueda) {
            return base.Channel.buscarcreditoexpedientesAsync(variablebusqueda);
        }
        
        public System.Data.DataSet cargarconsultacolocacionesnegocios() {
            return base.Channel.cargarconsultacolocacionesnegocios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacolocacionesnegociosAsync() {
            return base.Channel.cargarconsultacolocacionesnegociosAsync();
        }
        
        public System.Data.DataSet cargarconsultacaptacionesnegocios() {
            return base.Channel.cargarconsultacaptacionesnegocios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacaptacionesnegociosAsync() {
            return base.Channel.cargarconsultacaptacionesnegociosAsync();
        }
        
        public System.Data.DataSet cargarconsultagistoricocolocaciones() {
            return base.Channel.cargarconsultagistoricocolocaciones();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistoricocolocacionesAsync() {
            return base.Channel.cargarconsultagistoricocolocacionesAsync();
        }
        
        public System.Data.DataSet cargarconsultagistorrecuperacion(string fecha1, string fecha2) {
            return base.Channel.cargarconsultagistorrecuperacion(fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistorrecuperacionAsync(string fecha1, string fecha2) {
            return base.Channel.cargarconsultagistorrecuperacionAsync(fecha1, fecha2);
        }
        
        public System.Data.DataSet cargarconsultagistoricocolo() {
            return base.Channel.cargarconsultagistoricocolo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultagistoricocoloAsync() {
            return base.Channel.cargarconsultagistoricocoloAsync();
        }
        
        public System.Data.DataSet cargarconsultacantidadregistrocolocaciones() {
            return base.Channel.cargarconsultacantidadregistrocolocaciones();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrocolocacionesAsync() {
            return base.Channel.cargarconsultacantidadregistrocolocacionesAsync();
        }
        
        public System.Data.DataSet cargarconsultacantidadregistrocaptaciones() {
            return base.Channel.cargarconsultacantidadregistrocaptaciones();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrocaptacionesAsync() {
            return base.Channel.cargarconsultacantidadregistrocaptacionesAsync();
        }
        
        public System.Data.DataSet cargarconsultacantidadregistrorecuperacion(string fecha1, string fecha2) {
            return base.Channel.cargarconsultacantidadregistrorecuperacion(fecha1, fecha2);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> cargarconsultacantidadregistrorecuperacionAsync(string fecha1, string fecha2) {
            return base.Channel.cargarconsultacantidadregistrorecuperacionAsync(fecha1, fecha2);
        }
    }
}
