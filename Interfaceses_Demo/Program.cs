using System;

namespace Interfaceses_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
            new Manager(),
            new Worker(),
            new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
        }
    // SOLID Interface Segregation
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat(); 
    }
    interface ISalary
    {
        void GetSalary();
    }
    // Classlar birden fazla interface alabilir 
    //ama birden fazle class dan miras(inheritance) alamaz.
    class Manager : IWorker, IEat, ISalary 
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
        }
    }
}
