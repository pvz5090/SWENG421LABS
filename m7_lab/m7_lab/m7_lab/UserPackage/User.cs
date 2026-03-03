using NovelPackage;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace UserPackage{ 
    public abstract class User
    {
        private Type componentInterface;
        public void doStuff(Component component, string methodName, params object[] arguments)
        {
            MethodInfo method = componentInterface.GetMethod(methodName);
            method?.Invoke(component, arguments);
        }
    }
}