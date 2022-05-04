using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using LibraryDemo.Queries.Container;
using System;

namespace LibraryDemo.Schemas
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