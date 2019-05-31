namespace TestApp.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestApp.DAL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TestApp.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestApp.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            SaveData(context);
        }

        public void SaveData(ApplicationDbContext db)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Food" },
                new Category { Name = "Construction" },
                new Category { Name = "Hospitality" },
                new Category { Name = "Business" }
            };
            categories.ForEach(s => db.Categories.AddOrUpdate(p => p.Name, s));
            db.SaveChanges();

            var tags = new List<Tag>
            {
                new Tag
                {
                    Name = "Hypermarkets",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "MeatProducts",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Khalal",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Beverage",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Juice",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "EnergyDrink",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Banks",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Finance",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Marketing",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "WindowsDoors",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "ConstructionProducts",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "EuropeanDesign",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "EasternDesign",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "ConstructionCompanies",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Restaurants",
                    CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "Hotels",
                    CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id
                },
                new Tag
                {
                    Name = "FiveStar",
                    CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id
                },
            };
            tags.ForEach(s => db.Tags.AddOrUpdate(p => p.Name, s));
            db.SaveChanges();

            var logos = new List<Logo>
            {
                //Logos in the category of Business and Finance
                //banks
                new Logo
                {
                    CompanyName = "Ipoteka",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/banks/ipoteka/ipoteka.jpg",
                    Tags = new List<Tag>()
                },
                new Logo
                {
                    CompanyName = "Kapital",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/banks/kapital/kapital.jpg",
                    Tags = new List<Tag>()
                },
                new Logo
                {
                    CompanyName = "NBU",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/banks/nbu/nbu.jpg",
                    Tags = new List<Tag>()
                },
                 new Logo
                {
                    CompanyName = "Xalq",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/banks/xalq/xalq.jpg",
                    Tags = new List<Tag>()
                },
                  new Logo
                {
                    CompanyName = "Xamkor",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/banks/xamkor/xamkor.jpg",
                    Tags = new List<Tag>()
                },
                  //marketing
                  new Logo
                {
                    CompanyName = "InterIntellect",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/marketing/inter/inter.jpg",
                    Tags = new List<Tag>()
                },
                  new Logo
                {
                    CompanyName = "ProMarketing",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/marketing/promarketing/promarketing.jpeg",
                    Tags = new List<Tag>()
                },
                  new Logo
                {
                    CompanyName = "Space",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/marketing/space/space.jpg",
                    Tags = new List<Tag>()
                },
                  new Logo
                {
                    CompanyName = "TurnKey",
                    CategoryId = db.Categories.Where(s => s.Name == "Business").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/BusinessAndFinance/marketing/turnkey/turnkey.jpeg",
                    Tags = new List<Tag>()
                },

                  //Logos in the category of Construction
                  //windows and doors
                   new Logo
                {
                    CompanyName = "Ekopen",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/doorsWindows/ekopen/ekopen.jpeg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "Imzo",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/doorsWindows/imzo/imzo.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "Zebra",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/doorsWindows/zebra/zebra.jpg",
                    Tags = new List<Tag>()
                },
                   //construction companies
                   new Logo
                {
                    CompanyName = "AllStroy",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/companies/allstroy/allstroy.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "BestGeta",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/companies/bestgeta/bestgeta.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "GoldenHouse",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/companies/golden/golden.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "NovaStroy",
                    CategoryId = db.Categories.Where(s => s.Name == "Construction").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/construction/companies/novastroy/novastroy.jpg",
                    Tags = new List<Tag>()
                },

                   //Logos in the category of Food
                   //beverage
                   new Logo
                {
                    CompanyName = "ArkTea",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/beverage/arktea/arktea.jpg",
                    Tags = new List<Tag>()
                },
                    new Logo
                {
                    CompanyName = "Bliss",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/beverage/bliss/bliss.jpg",
                    Tags = new List<Tag>()
                },
                    new Logo
                {
                    CompanyName = "Flash",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/beverage/flash/flash.jpeg",
                    Tags = new List<Tag>()
                },
                    new Logo
                {
                    CompanyName = "WF",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/beverage/wf/wf.jpg",
                    Tags = new List<Tag>()
                },
                  //hypermarkets
                  new Logo
                {
                    CompanyName = "Kazbino",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/hypermarkets/kazbino/kazbino.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                    CompanyName = "Korzinka",
                    CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                    ImagePath = "~/Images/Logos/food/hypermarkets/korzinka/korzinka.jpg",
                    Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Makro",
                   CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/food/hypermarkets/makro/makro.jpeg",
                   Tags = new List<Tag>()
                },
                   //meat products
                   new Logo
                {
                   CompanyName = "Osiyo",
                   CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/food/meatProducts/osiyo/osiyo.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Rozmetov",
                   CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/food/meatProducts/rozmetov/rozmetov.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Sharshara",
                   CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/food/meatProducts/sharshara/sharshara.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Tegen",
                   CategoryId = db.Categories.Where(s => s.Name == "Food").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/food/meatProducts/tegen/tegen.jpg",
                   Tags = new List<Tag>()
                },
                   //Logos in the category of hospitality
                   //hotels
                   new Logo
                {
                   CompanyName = "Alliance",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/hotels/alliance/alliance.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "International",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/hotels/international/international.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Radisson",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/hotels/radisson/radisson.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Uzbekistan",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/hotels/uzbekistan/uzbekistan.jpeg",
                   Tags = new List<Tag>()
                },
                   //restaurants
                   new Logo
                {
                   CompanyName = "Baxor",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/restaurants/baxor/baxor.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Efendi",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/restaurants/efendi/efendi.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Evos",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/restaurants/evos/evos.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "OqTepa",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/restaurants/oqtepa/oqtepa.jpg",
                   Tags = new List<Tag>()
                },
                   new Logo
                {
                   CompanyName = "Qanotchi",
                   CategoryId = db.Categories.Where(s => s.Name == "Hospitality").SingleOrDefault().Id,
                   ImagePath = "~/Images/Logos/hospitality/restaurants/qanotchi/qanotchi.jpg",
                   Tags = new List<Tag>()
                },
            };
            logos.ForEach(s => db.Logos.AddOrUpdate(p => p.CompanyName, s));
            db.SaveChanges();
            //banks
            AddOrUpdateTag(db, "Ipoteka", "Banks");
            AddOrUpdateTag(db, "Ipoteka", "Finance");
            AddOrUpdateTag(db, "Kapital", "Banks");
            AddOrUpdateTag(db, "NBU", "Finance");
            AddOrUpdateTag(db, "NBU", "Banks");
            AddOrUpdateTag(db, "Xalq", "Banks");
            AddOrUpdateTag(db, "Xamkor", "Finance");
            AddOrUpdateTag(db, "Xamkor", "Banks");

            //marketing
            AddOrUpdateTag(db, "InterIntellect", "Marketing");
            AddOrUpdateTag(db, "ProMarketing", "Marketing");
            AddOrUpdateTag(db, "Space", "Marketing");
            AddOrUpdateTag(db, "TurnKey", "Marketing");

            //windows and doors
            AddOrUpdateTag(db, "Ekopen", "WindowsDoors");
            AddOrUpdateTag(db, "Imzo", "WindowsDoors");
            AddOrUpdateTag(db, "Zebra", "WindowsDoors");
            AddOrUpdateTag(db, "Ekopen", "ConstructionProducts");
            AddOrUpdateTag(db, "Imzo", "ConstructionProducts");
            AddOrUpdateTag(db, "Zebra", "ConstructionProducts");

            //construction companies
            AddOrUpdateTag(db, "AllStroy", "ConstructionCompanies");
            AddOrUpdateTag(db, "BestGeta", "ConstructionCompanies");
            AddOrUpdateTag(db, "GoldenHouse", "ConstructionCompanies");
            AddOrUpdateTag(db, "NovaStroy", "ConstructionCompanies");
            AddOrUpdateTag(db, "AllStroy", "EasternDesign");
            AddOrUpdateTag(db, "BestGeta", "EasternDesign");
            AddOrUpdateTag(db, "GoldenHouse", "EuropeanDesign");
            AddOrUpdateTag(db, "NovaStroy", "EuropeanDesign");

            //beverage
            AddOrUpdateTag(db, "ArkTea", "Beverage");
            AddOrUpdateTag(db, "Bliss", "Beverage");
            AddOrUpdateTag(db, "Flash", "Beverage");
            AddOrUpdateTag(db, "WF", "Beverage");
            AddOrUpdateTag(db, "Bliss", "Juice");
            AddOrUpdateTag(db, "Flash", "EnergyDrink");
            AddOrUpdateTag(db, "WF", "EnergyDrink");

            //hypermarkets
            AddOrUpdateTag(db, "Kazbino", "Hypermarkets");
            AddOrUpdateTag(db, "Korzinka", "Hypermarkets");
            AddOrUpdateTag(db, "Makro", "Hypermarkets");

            //meat products
            AddOrUpdateTag(db, "Osiyo", "MeatProducts");
            AddOrUpdateTag(db, "Rozmetov", "MeatProducts");
            AddOrUpdateTag(db, "Sharshara", "MeatProducts");
            AddOrUpdateTag(db, "Tegen", "MeatProducts");
            AddOrUpdateTag(db, "Osiyo", "Khalal");
            AddOrUpdateTag(db, "Rozmetov", "Khalal");

            //hotels
            AddOrUpdateTag(db, "Alliance", "Hotels");
            AddOrUpdateTag(db, "International", "Hotels");
            AddOrUpdateTag(db, "Radisson", "Hotels");
            AddOrUpdateTag(db, "Uzbekistan", "Hotels");
            AddOrUpdateTag(db, "Radisson", "FiveStar");
            AddOrUpdateTag(db, "Uzbekistan", "FiveStar");

            //restaurants
            AddOrUpdateTag(db, "Baxor", "Restaurants");
            AddOrUpdateTag(db, "Efendi", "Restaurants");
            AddOrUpdateTag(db, "Evos", "Restaurants");
            AddOrUpdateTag(db, "OqTepa", "Restaurants");
            AddOrUpdateTag(db, "Qanotchi", "Restaurants");
            db.SaveChanges();
        }

        private void AddOrUpdateTag(ApplicationDbContext db, string logoName, string tagName)
        {
            var logo = db.Logos.Where(s => s.CompanyName.ToLower() == logoName.ToLower()).First();
            var tag = logo.Tags.Where(s => s.Name.ToLower() == tagName.ToLower()).FirstOrDefault();
            if (tag == null)
                logo.Tags.Add(db.Tags.Where(s => s.Name.ToLower() == tagName.ToLower()).First());
            db.SaveChanges();
        }
    }
}
