using System;
using System.Collections.Generic;

namespace Game.Scripts
{
    public interface IService
    {
    }

    public class ServiceLocator
    {
        private Dictionary<Type, IService> _services;

        public static ServiceLocator _instance = new ServiceLocator();

        public ServiceLocator()
        {
            _services = new Dictionary<Type, IService>();
        }

        public static void Register<T>(IService service) where T : IService
        {
            _instance._services.Add(typeof(T), service);
        }

        public static T Get<T>() where T : IService
        {
            return (T)_instance._services[typeof(T)];
        }
    }
}