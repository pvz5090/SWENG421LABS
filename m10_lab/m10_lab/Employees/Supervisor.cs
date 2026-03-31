using System.Transactions;

namespace m10_lab
{
    public class Supervisor : Worker, LowerManagementIF
    {
        private UpperManagement _superior;

        public Supervisor(List<Worker> subordinates, UpperManagement? superior, string name)
        {
            _superior = superior;
        }
        public void Evacuate()
        {
            throw new NotImplementedException();
        }

        public void SeeDanger()
        {
            throw new NotImplementedException();
        }

        public String provideInfo()
        {
            return ("Information from " + this._name);
        }
    }

}

