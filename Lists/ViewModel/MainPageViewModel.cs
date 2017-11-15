using System;
using System.Collections.Generic;
using Lists.Model;

namespace Lists.ViewModel
{
    public class MainPageViewModel
    {
        public string FullName { get; set; }
        public string Company { get; set; }

        // Create list of person objects, this would normally be populated
        // by a web service or database
        public List<Person> Employees
        {
            get
            {
                return new List<Person>()
                {
                    new Person(){FullName="George Washington", Company="US"},
                    new Person(){FullName="Bill Gates", Company="Microsoft"},
                    new Person(){FullName="John Lennon", Company="Beetles"},
                    new Person(){FullName="Donnald Trump", Company="US Government"}
                };
            }
        }
    }
}
