using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests
{
    [Collection("Database collection")]
    public class PetTest
    {
        Crud crud;

        public PetTest(RunForEachTestClass fixture)
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


