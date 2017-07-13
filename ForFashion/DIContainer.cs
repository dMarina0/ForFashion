using Abstracts;
using BusinessLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForFashion
{
    public class DIContainer
    {
        public IUnityContainer Container;
        public DIContainer()
        {
            Container = new UnityContainer();
            Container.RegisterType<IShirtManager, ShirtManager>(new ContainerControlledLifetimeManager());
        }
        
    }
}