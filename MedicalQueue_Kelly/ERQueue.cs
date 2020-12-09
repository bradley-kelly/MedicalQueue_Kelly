using System.Collections.Generic;

namespace MedicalQueue_Kelly
{
    class ERQueue
    {
        public List<Patient> list = new List<Patient>(13);

        public int EnQueue(Patient inputdata)
        {
            if (list.Count >= 13)
            {
                return -1;
            }
            else
            {
                list.Add(inputdata);
                return list.Count;
            }
        }
        public string DeQueue()
        {
            if (list.Count <= 0)
            {
                return "Queue is empty.\n";
            }
            else
            {
                Patient Current = list[0];
                list.RemoveAt(0);
                return "Removed " + $"{Current.Name}" + " from the queue.\n";
            }
        }
        public override string ToString()
        {
            string output = "";
            if (list.Count <= 0)
            {
                output += "Queue is empty.\n";
            }
            foreach (Patient patient in list)
            {
                output += patient.Name + "\t" + patient.Priority + "\n";
            }
            return output;
        }
    }
}