using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests
{
    public class DatabaseFixture : IDisposable
    {
        public static int id = 0;
        public Crud Crud { get; private set; }

        public DatabaseFixture()
        {
            id++;
            Crud = new Crud();
            Crud.CleanDatabase().Wait();
        }

        public void Dispose()
        {
            Crud.CleanDatabase().Wait();
        }
    }
}

