using System.Transactions;

namespace m10_lab
{
    internal class Supervisor : Worker, LowerManagementIF, ProvidesInfoIF
    {
        private UpperManagementIF _superior;

        public Supervisor(UpperManagementIF superior, string name) : base(superior, name)
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
                _superior.AddInformer(this);
                _superior.SeeDanger();//report to superiot the problem
            }
        }

        public String provideInfo()
        {
            return ("Information from " + this._name);
        }
    }

}

