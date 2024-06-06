using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data
{
    public class AppDbInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            BrandName = "Haribo"
                        },
                         new Brand()
                        {
                            BrandName = "Skittles"
                        }, 
                        new Brand()
                        {
                            BrandName = "Starburst"
                        },
                        new Brand()
                        {
                            BrandName = "Cadbury"
                        },
                        new Brand()
                        {
                            BrandName = "Swizzels"
                        },
                    }
                        );
                    context.SaveChanges();
                }
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            CategoryName = "Sweets",
                            CategoryImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg5aiQhaOm9EkF9HWXX2zew2QPAedM7YmoPw&s"
                        },
                        new Category()
                        {
                            CategoryName = "Chocolate",
                            CategoryImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYpjFvFAPz6AEugjS2teKD976mJm7du6q4lw&s"
                        },
                         new Category()
                        {
                            CategoryName = "PickNMix",
                            CategoryImageURL = "https://www.google.com/imgres?q=sweets&imgurl=https%3A%2F%2Fsweecandy.co.uk%2Fcdn%2Fshop%2Fproducts%2FFizzySweets_b5c3c822-8ec6-45bd-9228-425aaf9aa1a1.jpg%3Fv%3D1624062153%26width%3D1445&imgrefurl=https%3A%2F%2Fsweecandy.co.uk%2Fproducts%2Fbuild-your-own-medium-letter-box-sweets&docid=pDF1jI55weafIM&tbnid=1pxXxK05phGLcM&vet=12ahUKEwjRjOWW0caGAxX_TUEAHXRFL_wQM3oECFEQAA..i&w=1080&h=1080&hcb=2&ved=2ahUKEwjRjOWW0caGAxX_TUEAHXRFL_wQM3oECFEQAA"
                        },

                    }
                        );
                    context.SaveChanges();
                }
                if (!context.Sweets.Any())
                {
                    var haribo = context.Brands.FirstOrDefault(b => b.BrandName == "Haribo");
                    var skittles = context.Brands.FirstOrDefault(b => b.BrandName == "Skittles");
                    var starburst = context.Brands.FirstOrDefault(b => b.BrandName == "Starburst");
                    var cadbury = context.Brands.FirstOrDefault(b => b.BrandName == "Cadbury");
                    var swizzels = context.Brands.FirstOrDefault(b => b.BrandName == "Swizzels");

                    var sweetsCategory = context.Categories.FirstOrDefault(c => c.CategoryName == "Sweets");
                    var chocolateCategory = context.Categories.FirstOrDefault(c => c.CategoryName == "Chocolate");
                    var pickNMixCategory = context.Categories.FirstOrDefault(c => c.CategoryName == "PickNMix");

                    context.Sweets.AddRange(new List<Sweet>()
                    {
                        new Sweet()
                        {
                            SweetName = "Starmix",
                            BrandId = haribo.Id,
                            PriceInPence = 71,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/427bad75-8c3e-4296-908c-11bf29a20888/7b675127-1295-4139-9d3f-3989a2d3b362_2020008133.jpeg?h=960&w=960",
                            StockInGrams = 1000,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Tangfastics",
                            BrandId = haribo.Id,
                            PriceInPence = 71,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/b4df73f8-5055-4330-9ae8-c1d6c49d2546/a09cc260-6f1d-464e-85d8-2ffdb803b00d_1031889638.jpeg?h=960&w=960",
                            StockInGrams = 3300,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Starmix",
                            BrandId = haribo.Id,
                            PriceInPence = 71,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/427bad75-8c3e-4296-908c-11bf29a20888/7b675127-1295-4139-9d3f-3989a2d3b362_2020008133.jpeg?h=960&w=960",
                            StockInGrams = 1000,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Fruits",
                            BrandId = skittles.Id,
                            PriceInPence = 92,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/7939ad65-0e77-49bf-9d1c-11bf8bee235d/4ff7275b-0631-4e8b-94b5-b6e54de53db8_1189161010.jpeg?h=225&w=225",
                            StockInGrams = 4750,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Crazy Sour Fruit",
                            BrandId = skittles.Id,
                            PriceInPence = 101,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/f6620880-a91a-46f6-9bb6-4a76203ca534/73e92669-25c0-4f98-a649-dc244a92c14c_1269631225.jpeg?h=225&w=225",
                            StockInGrams = 1500,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Original Fruit Chews",
                            BrandId = starburst.Id,
                            PriceInPence = 61,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/71ab4436-ce5c-4fd9-9b71-4f744f0ab247/acdb5eb0-f00f-43c9-b5c6-7fbafd839282_911573377.jpeg?h=225&w=225",
                            StockInGrams = 10000,
                            CategoryId = pickNMixCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Dairy Milk",
                            BrandId = cadbury.Id,
                            PriceInPence = 90,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/9a5ee81f-54e3-4cab-806d-f3a81af225a1/24feddf0-1a1c-4f56-9ab3-fe68499686b4_1408738934.jpeg?h=960&w=960",
                            StockInGrams = 18000,
                            CategoryId = chocolateCategory.Id
                        },
                        new Sweet()
                        {
                            SweetName = "Scrumptious Sweets",
                            BrandId = swizzels.Id,
                            PriceInPence = 72,
                            ImageURL = "https://digitalcontent.api.tesco.com/v2/media/ghs/853e6eac-9d6f-4472-a2c6-bbe2248c654c/853ad0e9-ac50-4b10-ac77-879138d55a35_968795853.jpeg?h=960&w=960",
                            StockInGrams = 1800,
                            CategoryId = sweetsCategory.Id
                        },
                    }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
