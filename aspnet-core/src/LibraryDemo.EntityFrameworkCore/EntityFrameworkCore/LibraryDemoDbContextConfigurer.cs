using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryDemo.EntityFrameworkCore
{
    public static class LibraryDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}