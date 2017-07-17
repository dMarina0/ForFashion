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
        private static DIContainer instance;
        private DIContainer()
        {
            Container = new UnityContainer();
            //Container.RegisterType<IShirtManager, ShirtManager>(new ContainerControlledLifetimeManager());
        }
        //Singleton
        public static DIContainer Instance
        {

            get
            {
                if(instance == null)
                {
                    instance = new DIContainer();
                }
                return instance;
            }
        }
        
    }
}