namespace m10_lab
{
    public abstract class Employee : WorkerIF
    {
        protected List<WorkerIF> _subordinates = new List<WorkerIF>();
        protected WorkerIF? _superior = null;
        protected string _name;
        public Employee(WorkerIF? superior, string name)
        {
            if (superior != null)
            {
                this.AddSuperior(superior);
            }
            _name = name;
        }
        public void Evacuate()
        {
            foreach (WorkerIF s in _subordinates)
            {
                s.Evacuate();
            }
            Console.WriteLine("The person " + this._name + " has evacuated.");
        }

        public void SeeDanger()
        {
            throw new NotImplementedException();
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void AddSuperior(WorkerIF employee)
        {
            _superior = employee;
            employee.AddSubordinate(this);
        }
        public void AddSubordinate(WorkerIF employee)
        {
            _subordinates.Add(employee);
        }
    }

}

