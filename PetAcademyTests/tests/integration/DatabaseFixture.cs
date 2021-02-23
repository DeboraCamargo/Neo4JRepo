using Neo4jClient;
using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests.Tests.Integration
{
    public class DatabaseFixture : IDisposable
    {
        public static int id = 0;
        public Crud Crud { get; private set; }

        public DatabaseFixture()
        {
            id++;
            var client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "123");
            client.ConnectAsync().Wait();

            Crud = new Crud(client);
            Crud.CleanDatabase().Wait();
        }

        public void Dispose()
        {
            //Crud.CleanDatabase().Wait();
        }
    }
}

