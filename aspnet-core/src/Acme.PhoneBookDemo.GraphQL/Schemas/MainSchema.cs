using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Acme.PhoneBookDemo.Queries.Container;
using System;

namespace Acme.PhoneBookDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}