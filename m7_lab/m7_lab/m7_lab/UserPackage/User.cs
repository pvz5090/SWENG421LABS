using NovelPackage;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace UserPackage{ 
    public abstract class User
    {
        protected Type componentInterface;
        public User(Type c)
        {
            componentInterface=c;
        }
        public void doStuff(Component component, string methodName, params object[] arguments)
        {
        if (!componentInterface.IsAssignableFrom(component.GetType()))
            throw new UnauthorizedAccessException("Permission denied.");

        MethodInfo method = componentInterface.GetMethod(methodName);

        if (method == null)
            throw new UnauthorizedAccessException("Method not allowed.");

        method.Invoke(component, arguments);
        }
    }
}