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
                    }
                        );
                    context.SaveChanges();
                }
                if (!context.Sweets.Any())
                {
                    context.Sweets.AddRange(new List<Sweet>()
                    {
                        new Sweet()
                        {
                            SweetName = "Starmix",
                            BrandId = 1,
                            PriceInPence = 71,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/427bad75-8c3e-4296-908c-11bf29a20888/7b675127-1295-4139-9d3f-3989a2d3b362_2020008133.jpeg?h=960&w=960",
                            StockInGrams = 1000
                        },
                        new Sweet()
                        {
                            SweetName = "Tangfastics",
                            BrandId = 1,
                            PriceInPence = 71,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/b4df73f8-5055-4330-9ae8-c1d6c49d2546/a09cc260-6f1d-464e-85d8-2ffdb803b00d_1031889638.jpeg?h=960&w=960",
                            StockInGrams = 3300
                        },
                        new Sweet()
                        {
                            SweetName = "Starmix",
                            BrandId = 1,
                            PriceInPence = 71,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/427bad75-8c3e-4296-908c-11bf29a20888/7b675127-1295-4139-9d3f-3989a2d3b362_2020008133.jpeg?h=960&w=960",
                            StockInGrams = 1000
                        },
                        new Sweet()
                        {
                            SweetName = "Fruits",
                            BrandId = 2,
                            PriceInPence = 92,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/7939ad65-0e77-49bf-9d1c-11bf8bee235d/4ff7275b-0631-4e8b-94b5-b6e54de53db8_1189161010.jpeg?h=225&w=225",
                            StockInGrams = 4750
                        },
                        new Sweet()
                        {
                            SweetName = "Crazy Sour Fruit",
                            BrandId = 2,
                            PriceInPence = 101,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/f6620880-a91a-46f6-9bb6-4a76203ca534/73e92669-25c0-4f98-a649-dc244a92c14c_1269631225.jpeg?h=225&w=225",
                            StockInGrams = 1500
                        },
                        new Sweet()
                        {
                            SweetName = "Original Fruit Chews",
                            BrandId = 3,
                            PriceInPence = 61,
                            ImageUrl = "https://digitalcontent.api.tesco.com/v2/media/ghs/71ab4436-ce5c-4fd9-9b71-4f744f0ab247/acdb5eb0-f00f-43c9-b5c6-7fbafd839282_911573377.jpeg?h=225&w=225",
                            StockInGrams = 10000
                        },
                    }
                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
