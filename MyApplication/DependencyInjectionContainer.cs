using System;
using System.Collections.Generic;
using System.Configuration;

namespace MyApplication
{
    static class DependencyInjectionContainer
    {
        static IDictionary<Type, object> instanceCatalog;
        static IDictionary<Type, object> InstanceCatalog
        {
            get
            {
                if (instanceCatalog == null)
                {
                    instanceCatalog = new Dictionary<Type, object>();
                }
                return instanceCatalog;
            }
        }
        internal static T GetInstance<T>() where T: class
        {
            Type interfaceType = typeof(T);
            if (InstanceCatalog.ContainsKey(interfaceType))
            {
                return InstanceCatalog[interfaceType] as T;
            }

            string typeName = ConfigurationManager.AppSettings.Get(interfaceType.ToString());
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            Type instanceType = Type.GetType(typeName);
            object instanceObject = Activator.CreateInstance(instanceType);
            T instance = instanceObject as T;
            return instance;
        }
        internal static void MapInstance<T>(object instance)
        {
            Type type = typeof(T);
            if (InstanceCatalog.ContainsKey(type))
            {
                InstanceCatalog.Remove(type);
            }
            InstanceCatalog.Add(type, instance);
        }

        internal static void ClearCatalog()
        {
            InstanceCatalog.Clear();
        }
    }
}
