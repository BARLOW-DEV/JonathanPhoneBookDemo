﻿using Acme.PhoneBookDemo.Editions;
using Acme.PhoneBookDemo.EntityFrameworkCore;

namespace Acme.PhoneBookDemo.Test.Base.TestData
{
    public class TestEditionsBuilder
    {
        private readonly PhoneBookDemoDbContext _context;

        public TestEditionsBuilder(PhoneBookDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            CreateEdition("Free Edition 1", "FreeEdition1", null, null);
            CreateEdition("Free Edition 2", "FreeEdition2", null, null);
            CreateEdition("Free Edition 3", "FreeEdition3", null, null);
            CreateEdition("Paid Edition 1", "PaidEdition1", 10, 100);
            CreateEdition("Paid Edition 2", "PaidEdition2", 20, 200);
            CreateEdition("Paid Edition 3", "PaidEdition3", 30, 300);
        }

        private void CreateEdition(string displayName, string name, decimal? monthlyPrice, decimal? annualPrice)
        {
            var edition = new SubscribableEdition
            {
                DisplayName = displayName,
                Name = name,
                MonthlyPrice = monthlyPrice,
                AnnualPrice = annualPrice
            };

            _context.SubscribableEditions.Add(edition);
        }
    }
}
