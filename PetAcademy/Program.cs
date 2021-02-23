using Neo4jClient;
using System;
using System.Threading.Tasks;
using PetAcademy.Models;

namespace PetAcademy
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "123");
            client.ConnectAsync().Wait();

            Crud crud = new Crud(client);
            await crud.CleanDatabase();
            await crud.SavePet(new Animal { Name= "Happy Tails1", Sex = "Female", Specie= "Dog", Color= "White", Breed= "Lhasa Apso", Age= 13 });
        }
    }

}
