using Neo4jClient;
using Neo4jClient.Cypher;
using Neo4jClient.Execution;
using Neo4jClient.Serialization;
using Neo4jClient.Transactions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetAcademyTests.Shared
{
    class GraphClientNOOP : IGraphClient
    {
        public string DefaultDatabase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CypherCapabilities CypherCapabilities => throw new NotImplementedException();

        public Uri RootEndpoint => throw new NotImplementedException();

        public Version ServerVersion => throw new NotImplementedException();

        public Uri TransactionEndpoint => throw new NotImplementedException();

        public ISerializer Serializer => throw new NotImplementedException();

        public ExecutionConfiguration ExecutionConfiguration => throw new NotImplementedException();

        public bool IsConnected => throw new NotImplementedException();

        public List<JsonConverter> JsonConverters => throw new NotImplementedException();

        public DefaultContractResolver JsonContractResolver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITransactionalGraphClient Tx => throw new NotImplementedException();

        ICypherFluentQuery cypher = new CypherFluentQueryNOOP<Object>();
        public ICypherFluentQuery Cypher { get { return cypher; } set { this.cypher = value; } }

        public event OperationCompletedEventHandler OperationCompleted;

        public Task ConnectAsync(NeoServerConfiguration configuration = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Uri GetTransactionEndpoint(string database, bool autoCommit)
        {
            throw new NotImplementedException();
        }
    }
}
