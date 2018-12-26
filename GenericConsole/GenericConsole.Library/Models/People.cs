using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class People<T> where T : APerson
    {
        //clients associates trainers and managers
        public List<T> Peoples { get; set; }

        public People()
        {
            Peoples = new List<T>();
        }
    }
}
