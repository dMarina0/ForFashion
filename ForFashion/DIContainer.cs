using Abstracts;
using Abstracts.IManagers;
using BusinessLayer;
using BusinessObjects;
using BusinessObjects.Entities;
using DataLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForFashion
{
    public class DIContainer
    {
         private IUnityContainer _container;
        private static DIContainer instance;
        private DIContainer()
        {

            _container = new UnityContainer();
            _container.RegisterType<IShirtManager, ShirtManager>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IUserDetailsManager, UserDetailsManager>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IDressManager, DressManager>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IRepository<Shirt>, Repository<Shirt>>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IRepository<ApplicationUser>, Repository<ApplicationUser>>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IRepository<UserDetails>, Repository<UserDetails>>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IRepository<DressManager>, Repository<DressManager>>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IRepository<FashionHouse>, Repository<FashionHouse>>(new ContainerControlledLifetimeManager());
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
        public T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
