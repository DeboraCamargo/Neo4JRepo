using Neo4j.Driver;
using System;
using System.Linq;

namespace Neo4JConnectionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var conec = new HelloWorldExample("bolt://localhost:7687", "neo4j", "123");
            conec.SaveMessageGreeting("Here is your cookie with coffee");
        }
    }

    public class HelloWorldExample : IDisposable
    {
        private readonly IDriver _driver;

        public HelloWorldExample(string uri, string username, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password));
        }

        public void SaveMessageGreeting(string message)
        {
            using var session = _driver.Session();
            //using var session = _driver.AsyncSession();
            var greeting = session.WriteTransaction(tx =>
            {
                var result = tx.Run("CREATE (a:Greeting) " +
                    "SET a.message = $message " +
                    "RETURN a.message + ', from node ' + id(a)",
                    new { message });
                return result.Single()[0].As< String > ();
            });
            Console.WriteLine(greeting);
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}
