﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService()
        {
            return new global::LightSwitchApplication.DataWorkspace().ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::ApplicationData.Implementation.ApplicationDataObjectContext>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::ApplicationData.Implementation.Product))
            {
                return new global::ApplicationData.Implementation.Product();
            }
            if (type == typeof(global::ApplicationData.Implementation.ProductFeature))
            {
                return new global::ApplicationData.Implementation.ProductFeature();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::ApplicationData.Implementation.ApplicationDataObjectContext CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::ApplicationData.Implementation.ApplicationDataObjectContext(base.GetEntityConnectionString(
                "_IntrinsicData", 
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl", 
                "System.Data.SqlClient"));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Product))
            {
                return new global::ApplicationData.Implementation.Product();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.ProductFeature))
            {
                return new global::ApplicationData.Implementation.ProductFeature();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Product) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.Product);
            }
            if (typeof(global::LightSwitchApplication.ProductFeature) == definitionType)
            {
                return typeof(global::ApplicationData.Implementation.ProductFeature);
            }
            return null;
        }
    }
}

namespace ApplicationData.Implementation
{

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product :
        global::LightSwitchApplication.Product.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Product.DetailsClass.IImplementation.ProductFeatures
        {
            get
            {
                return this.ProductFeatures;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ProductFeature :
        global::LightSwitchApplication.ProductFeature.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.ProductFeature.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::ApplicationData.Implementation.Product)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Product");
                }
            }
        }
        
        partial void OnProductFeature_ProductChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Product");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

