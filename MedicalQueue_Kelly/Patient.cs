namespace MedicalQueue_Kelly
{
    class Patient
    {
        private readonly string _Name;
        private readonly int _Priority;
        public string Name { get { return _Name; } }
        public int Priority { get { return _Priority; } }
        public Patient(string name, int priority)
        {
            _Name = name;
            _Priority = priority;
        }
    }
}