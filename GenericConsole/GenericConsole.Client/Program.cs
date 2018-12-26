using System;
using glm = GenericConsole.Library.Models;

namespace GenericConsole.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //var g = new glm.GenericModel<string>();
            //var h = new glm.GenericModel<int>();
            //g.Hello();
            //h.Hello();
            //PlayWithGeneric();
            PlayWithGenericEmployee();
        }

        static void PlayWithGeneric()
        {
            //var c = new glm.Client();
            //var c1 = new glm.Client();

            //foreach (var item in glm.Client.Clients.Peoples)
            //{
            //    Console.WriteLine("{0}\n{1}", item.Name, item.Title);
            //}
        }

        static void PlayWithGenericEmployee()
        {
            var a1 = new glm.Employee<glm.Associate>();
            var a2 = new glm.Employee<glm.Associate>();
            var c1 = new glm.Employee<glm.Trainer>();
            var c2 = new glm.Employee<glm.Trainer>();

            foreach (var item in glm.Employee<glm.Associate>.Employees.Peoples)
            {
                Console.WriteLine("{0}\n{1}", item.Name, item.Title);
            }

            foreach (var item in glm.Employee<glm.Trainer>.Employees.Peoples)
            {
                Console.WriteLine("{0}\n{1}", item.Name, item.Title);
            }
        }
    }
}
