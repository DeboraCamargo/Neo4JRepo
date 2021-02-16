using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PetAcademyTests
{
    [CollectionDefinition("Database collection")]
    public class DatabaseCollection: ICollectionFixture<DatabaseFixture>
    {
        // no code here at all
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
