using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project.Factories
{
    public class ObjectFactory : IObjectFactory
    {

        public T Create<T>(params object[] args) where T : class
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }
    }
}
