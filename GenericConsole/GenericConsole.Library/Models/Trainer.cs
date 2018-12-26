using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class Trainer
    {
        public static readonly People<Peep> Trainers = new People<Peep>();

        public Trainer()
        {
        }
    }
}
