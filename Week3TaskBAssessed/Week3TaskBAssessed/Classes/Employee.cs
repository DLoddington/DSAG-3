using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TaskBAssessed.Classes
{
    public class Employee
    {
        private string name;
        private int id;
        private bool avail;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.avail = true;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Avail
        {
            get { return avail; }
            set { avail = value; }
        }

        public string GetSummary()
        {
            return Id + " - " + name + ". Availability: " + availabilityString();
        }

        private string availabilityString()
        {
            if (Avail == true)
                return "available";
            return "unavailable";
        }

    }
}
