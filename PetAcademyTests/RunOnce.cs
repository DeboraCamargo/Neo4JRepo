using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PetAcademyTests
{
    [CollectionDefinition("Database collection")]
    public class RunOnce: ICollectionFixture<RunForEachTestClass>
    {
        // no code here at all

    }
}
