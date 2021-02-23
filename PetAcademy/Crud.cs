using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PetAcademy.Models;
using System.Linq;

namespace PetAcademy
{
    public class Crud
    {
       private IGraphClient client;
        public Crud(IGraphClient client)
        {
            //client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "123");
            //client.ConnectAsync().Wait();

            this.client = client;
        }
        public async Task<Animal> SavePet (Animal pet)
        {
            //await client.Cypher
            //    .Create("(a:Animal $newAnimal)")
            //    .WithParam("newAnimal", pet)
            //    .ExecuteWithoutResultsAsync();

            var a = await client.Cypher
            .Create("(a:Animal $newAnimal)")
            .WithParam("newAnimal", pet)
             .Return((a) => a.As<Animal>()).ResultsAsync;

            return a.First();

        }
        public async Task<PetChair> SavePetWithChair(Animal pet, Chair chair)
        {
            var createQuery = await client.Cypher
                .Create("(a:Animal $newAnimal)<-[rel: IS_IN_CLASS]-(c:Chair $newChair)")
                .WithParam("newAnimal", pet)
                .WithParam("newChair", chair)
                .Return((a, c) => new PetChair
                {
                    Animal = a.As<Animal>(),
                    Chair = c.As<Chair>(),
                }).ResultsAsync;

            return createQuery.First();
        }
        public async Task UpdatePet()
        {

        }
        public async Task RemovePet()
        {

        }
        public async Task GetPet(string name)
        {

        }
        public async Task GetPets()
        {

        }
        public async Task<Chair> SaveChair(Chair chair)
        {
            var a = await client.Cypher
             .Create("(c:Chair $newChair)")
             .WithParam("newChair", chair)
              .Return((c) => c.As<Chair>()).ResultsAsync;

            return a.First();
        }

        public async Task CleanDatabase()
        {
            await client.Cypher
              .Match("(n)")
              .DetachDelete("n").ExecuteWithoutResultsAsync();
        }
    }
}
