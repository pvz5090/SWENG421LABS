using System.Security.Cryptography.X509Certificates;
using NovelPackage;
namespace UserPackage{ 
    public class Writer : User
    {
        public Writer():base(typeof(WriterComponent)) {}

    }
}