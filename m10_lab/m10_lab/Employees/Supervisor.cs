using System.Transactions;

namespace m10_lab
{
    public class Supervisor : Worker, LowerManagementIF
    {
        private UpperManagementIF _superior;

        public Supervisor(List<Worker> subordinates, UpperManagementIF superior, string name) : base(subordinates, superior, name)
        {
            _superior = superior;
        }
        public string ProvideInfo()
        {
            return ("Information from " + this._name);
        }

        public void SeeDanger()
        {   
            if (_superior == null)
            {
                Console.WriteLine("No superior to report to.");
            }
            else
            {
                foreach (Worker s in this._subordinates)
                {
                    s.FixIt();//solve the problem
                }
                _superior.SeeDanger();//report to superiot the problem
            }
        }

        public String provideInfo()
        {
            return ("Information from " + this._name);
        }
    }

}

