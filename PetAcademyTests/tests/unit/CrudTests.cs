using Moq;
using Neo4jClient;
using Neo4jClient.Cypher;
using PetAcademy;
using PetAcademy.Models;
using PetAcademyTests.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PetAcademyTests.tests.unit
{
   public class CrudTests
    {
        private Mock<CypherFluentQueryNOOP<Animal>> mockFluentQueryAnimal;
        private Mock<CypherFluentQueryNOOP<Chair>> mockFluentQueryChair;


        GraphClientNOOP client;
        Crud crud;

        public CrudTests ()
        {
            this.client = new GraphClientNOOP();
            this.crud = new Crud(client);
            this.mockFluentQueryAnimal = new Mock<CypherFluentQueryNOOP<Animal>>() { CallBase = true };
            this.mockFluentQueryChair = new Mock<CypherFluentQueryNOOP<Chair>>() { CallBase = true };
        }

        [Fact]
        public async Task SaveChairSucess()
        {
            var chairTest = new Chair { Name = "Dog Brush Teeth", Professor = "Doggo" };

            this.client.Cypher = this.mockFluentQueryChair.Object;
            mockFluentQueryChair.Setup(x => x.ResultsAsyncMock())
                .Returns(Task.FromResult(new List<Chair>() { chairTest } as IEnumerable<Chair>));
            

            var savedChair = await crud.SaveChair(chairTest);
            Assert.Equal(chairTest.Name, savedChair.Name);
            mockFluentQueryChair.Verify(x=> x.WithParam(It.IsAny<string>(), It.IsAny<Object>()), Times.Once);

        }

    }
}
