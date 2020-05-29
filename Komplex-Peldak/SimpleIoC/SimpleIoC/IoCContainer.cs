using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SimpleIoC
{
    public class IoCContainer : IIoCContainer
    {
        private Dictionary<Type, Type> _instances;
        private Dictionary<Type, object> _singletons;

        public IoCContainer()
        {
            _instances = new Dictionary<Type, Type>();
            _singletons = new Dictionary<Type, object>();
        }

        public void Register<TInterface, TClass>()
            where TInterface : class
            where TClass : class, TInterface
        {
            Type iface = typeof(TInterface);

            if (!iface.IsInterface)
                throw new ResolveException($"{iface.FullName} is not an interface");

            if (_instances.ContainsKey(iface)
                || _singletons.ContainsKey(iface))
            {
                throw new Exception($"{iface.FullName} is allready registered");
            }

            _instances.Add(iface, typeof(TClass));
        }

        public void RegisterSingleton<TInterface, TClass>()
            where TInterface : class
            where TClass : class, TInterface
        {
            Type iface = typeof(TInterface);

            if (!iface.IsInterface)
                throw new ResolveException($"{iface.FullName} is not an interface");

            if (_instances.ContainsKey(iface)
                || _singletons.ContainsKey(iface))
            {
                throw new Exception($"{iface.FullName} is allready registered");
            }

            _singletons.Add(typeof(TInterface), CreteInstance(typeof(TClass)));
        }

        public TInterface Resolve<TInterface>() where TInterface : class
        {
            Type requested = typeof(TInterface);
            return Resolve(requested) as TInterface;
        }

        private object Resolve(Type requested)
        {
            if (_singletons.ContainsKey(requested))
            {
                return _singletons[requested];
            }

            if (_instances.ContainsKey(requested))
            {
                return CreteInstance(_instances[requested]);
            }

            throw new ResolveException(requested);
        }

        private object CreteInstance(Type requested)
        {
            ConstructorInfo[] constructors = requested.GetConstructors();

            ConstructorInfo full = (from constructor in constructors
                                    where
                                        constructor.IsPublic
                                    orderby
                                        constructor.GetParameters().Length descending
                                    select
                                        constructor).FirstOrDefault();

            if (full == null)
                throw new ResolveException($"Type {requested.FullName} doesn't have a public constructor");

            try
            {

                var parameters = full.GetParameters();
                List<object> dependencies = new List<object>(parameters.Length);

                foreach (var parameter in parameters)
                {
                    object resolved = Resolve(parameter.ParameterType);
                    dependencies.Add(resolved);
                }

                return Activator.CreateInstance(requested, dependencies.ToArray());
            }
            catch (Exception ex)
            {
                throw new ResolveException($"Can't create type: {requested.FullName}", ex);
            }
        }
    }
}
