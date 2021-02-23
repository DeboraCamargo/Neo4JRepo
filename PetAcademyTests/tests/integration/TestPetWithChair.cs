using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests.Tests.Integration
{
    [Collection("Database collection")]
    public class TestPetWithChair
    {

        Crud crud;
        // Don't need to instanciate crud since now fixture shares the connection accross the tests - cool eh?!
        // If you want a different connection tho, feel free enjoy it

        public TestPetWithChair(DatabaseFixture fixture)
        {
            this.crud = fixture.Crud;
        }

        [Fact]
        public async Task SavePetWithChairSuccess()
        {
            var petTest = new Animal { Name = "Happy Tails2", Sex = "Female", Specie = "Dog", Color = "White", Breed = "Lhasa Apso", Age = 13 };
            var chairTest = new Chair { Name = "Doggy beggy eyes", Professor = "snob Kitten Snob" };

            var savedPetInChair = await crud.SavePetWithChair(petTest, chairTest);
            Assert.Equal(petTest.Name, savedPetInChair.Animal.Name);
            Assert.Equal(chairTest.Name, savedPetInChair.Chair.Name);

        }

        [Fact]
        public async Task SavePetWithChairSuccess2()
        {
            var petTest = new Animal { Name = "Happy Tails2", Sex = "Female", Specie = "Dog", Color = "White", Breed = "Lhasa Apso", Age = 13 };
            var chairTest = new Chair { Name = "Doggy beggy eyes", Professor = "snob Kitten Snob" };

            var savedPetInChair = await crud.SavePetWithChair(petTest, chairTest);
            Assert.Equal(petTest.Name, savedPetInChair.Animal.Name);
            Assert.Equal(chairTest.Name, savedPetInChair.Chair.Name);

        }
    }
}
