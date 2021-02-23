using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests.Tests.Integration
{
    [Collection("Database collection")]
    public class TestPet
    {
        Crud crud;
        // Don't need to instanciate crud since now fixture shares the connection accross the tests - cool eh?!
        // If you want a different connection tho, feel free enjoy it

        public TestPet(DatabaseFixture fixture)
        {
            this.crud = fixture.Crud;
        }

        [Fact]
        public async Task SavePetSuccess()
        {
            //Crud crud = new Crud();
            //await crud.CleanDatabase();

            var petTest = new Animal { Name = "Happy Tails1", Sex = "Female", Specie = "Dog", Color = "White", Breed = "Lhasa Apso", Age = 13 };

            var savedPet = await crud.SavePet(petTest);
            Assert.Equal(petTest.Name, savedPet.Name);

        }
    }
}


