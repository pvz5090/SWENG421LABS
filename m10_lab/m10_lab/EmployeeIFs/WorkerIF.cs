namespace m10_lab
{
    public interface WorkerIF
    {
        public void SeeDanger();
        public void Evacuate();
        public void AddSubordinate(WorkerIF employee);
        public string GetName();
        List<WorkerIF> GetSubordinates();
    }
}
