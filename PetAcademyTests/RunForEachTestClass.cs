using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests
{
    [Collection("Database collection")]
    public class RunForEachTestClass : IDisposable
    {
        public static int id = 0;
        public Crud Crud { get; private set; }

        public RunForEachTestClass()
        {
            id++;
            //setup code
            Console.WriteLine("This will run ONCE for each test class");
            Crud = new Crud();
            Crud.CleanDatabase().Wait();
        }

        public void Dispose()
        {
            // clean up code
            Console.WriteLine("Run ONCE after this test class");
            //Crud.CleanDatabase().Wait();
        }
    }
}

