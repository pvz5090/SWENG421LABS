namespace m10_lab
{
    public class EvacuationQueue
    {
        private static EvacuationQueue? _instance;
        private List<List<WorkerIF>> _levels;

        private EvacuationQueue()
        {
            _levels = new List<List<WorkerIF>>();
        }

        public static EvacuationQueue Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EvacuationQueue();
                }
                return _instance;
            }
        }

        public void BuildLevels(WorkerIF root)
        {
            _levels.Clear();

            Queue<WorkerIF> queue = new Queue<WorkerIF>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<WorkerIF> currentLevel = new List<WorkerIF>();

                for (int i = 0; i < size; i++)
                {
                    WorkerIF current = queue.Dequeue();
                    currentLevel.Add(current);

                    foreach (WorkerIF sub in current.GetSubordinates())
                    {
                        queue.Enqueue(sub);
                    }
                }

                _levels.Add(currentLevel);
            }
        }

        public void EvacuateAll()
        {
            // Print BFS traversal in reverse order (from bottom to top)
            for (int i = _levels.Count - 1; i >= 0; i--)
            {
                foreach (WorkerIF worker in _levels[i])
                {
                    Console.WriteLine($"The person {worker.GetName()} has evacuated.");
                }
            }
        }
    }
}

