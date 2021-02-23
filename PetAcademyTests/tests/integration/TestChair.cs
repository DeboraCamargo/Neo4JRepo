using PetAcademy;
using PetAcademy.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests.Tests.Integration
{
    [Collection("Database collection")]
    public class TestChair
    {
        Crud crud;
        // Don't need to instanciate crud since now fixture shares the connection accross the tests - cool eh?!
        // If you want a different connection tho, feel free enjoy it

        public TestChair(DatabaseFixture fixture)
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
