using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests
{
    [Collection("Database collection")]
    public class ChairTest
    {
        Crud crud;

        public ChairTest(RunForEachTestClass fixture)
        {
            this.crud = fixture.Crud;
        }

        [Fact]
        public async Task SaveChairSucess()
        {
            var chairTest = new Chair { Name = "Dog Brush Teeth", Professor = "Doggo" };

            var savedChair = await crud.SaveChair(chairTest);
            Assert.Equal(chairTest.Name, savedChair.Name);

        }
    }
}
