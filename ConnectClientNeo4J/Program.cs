using System;
using Neo4jClient;

namespace ConnectClientNeo4J
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var client = new GraphClient(new Uri("bolt://localhost:7687"), "neo4j", "123");
            var client = new GraphClient(new Uri("http://localhost:7474"), "neo4j", "123");

            client.ConnectAsync().Wait();

            var createQuery = client.Cypher
                .Create("(j:Book {Title: 'debora test', PageCount:250})<-[rel:HAS_BOOK]-(m:Person {Name: 'John Doe'})")
                .Return((j, m) => new
                {
                    Book = j.As<Book>(),
                    Person = m.As<Person>(),
                }).ResultsAsync;

            foreach (var item in createQuery.Result)
            {
                Console.WriteLine(item.Book.Title);
            }
            //var test = new ConnectCoolWay();

        }
    }

    public class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }

    }
    public class Person
    {
        public string Name { get; set; }

    }

    public class ConnectCoolWay
    {
        private readonly IBoltGraphClient _bc;

        public ConnectCoolWay()
        {
            string neo4jHostname = "bolt://localhost:7687",
                neo4jUsername = "neo4j",
                neo4jPassword = "123";

            //var driver = GraphDatabase.Driver(
            //    new Uri(neo4jHostname),
            //    AuthTokens.Basic(neo4jUsername, neo4jPassword),
            //    o => o.WithEncryptionLevel(EncryptionLevel.None)
            //);
            //_bc = new BoltGraphClient(driver);


            _bc = new BoltGraphClient(new Uri(neo4jHostname), neo4jUsername, neo4jPassword);
            //{
            //    DefaultDatabase = "integrationtest",
            //};

            
        }
    }
}
