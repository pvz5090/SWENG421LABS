namespace m10_lab
{
    public abstract class Employee : WorkerIF
    {
        protected List<WorkerIF> _subordinates = new List<WorkerIF>();
        protected WorkerIF? _superior = null;
        protected string _name;
        public Employee(List<WorkerIF> subordinates, WorkerIF? superior, string name)
        {
            _subordinates = subordinates;
            _superior = superior;
            _name = name;
        }
        public void Evacuate()
        {
            foreach (WorkerIF s in _subordinates)
            {
                s.Evacuate();
            }
            Evacuate();
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

        public void AddSuperior(Employee employee)
        {
            _superior = employee;
            employee.AddSubordinate(this);
        }
        protected void AddSubordinate(Employee employee)
        {
            _subordinates.Add(employee);
        }
    }

}

