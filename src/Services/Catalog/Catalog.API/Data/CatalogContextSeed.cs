using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> products)
        {
            bool exitsProduct = products.Find(p => true).Any();
            if (!exitsProduct)
            {
                products.InsertMany(GetPreconfiguredProducts());

                
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id="lm718zf0ea7lih9pvs04f3sa",
                    Name="IPhone X",
                    Summary="This is the companys bigges change to its flaghsip masrtphone is years.",
                    Description="Loren sisdf asdfasdfasdfasdf",
                    ImageFile="product-1.png",
                    Price=859.00m,
                    Category="Smart Phone"
                },
                new Product()
                {
                    Id="416hly3qs5bpb8itwx60ds2a",
                    Name="Samsung 10",
                    Summary="This is the companys bigges change to its flaghsip masrtphone is years.",
                    Description="Loren sisdf asdfasdfasdfasdf",
                    ImageFile="product-2.png",
                    Price=819.00m,
                    Category="Smart Phone"
                },
                new Product()
                {
                    Id="hdjrljx6s57vy4ttz86u32as",
                    Name="Huwei plus",
                    Summary="This is the companys bigges change to its flaghsip masrtphone is years.",
                    Description="Loren sisdf asdfasdfasdfasdf",
                    ImageFile="product-3.png",
                    Price=650.00M,
                    Category="White Appliances"
                },new Product()
                {
                    Id="7pt0kla7iqsal59k3k80d2aa",
                    Name="Xiaomi Mi 9",
                    Summary="This is the companys bigges change to its flaghsip masrtphone is years.",
                    Description="Loren sisdf asdfasdfasdfasdf",
                    ImageFile="product-4.png",
                    Price=470.00M,
                    Category="White Appliances"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "HTC U11+ Plus",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id="602d2149e773f2a3990b47fa",
                    Name="LG G7 ThinQ",
                    Summary="This is the companys bigges change to its flaghsip masrtphone is years.",
                    Description="Loren sisdf asdfasdfasdfasdf",
                    ImageFile="product-6.png",
                    Price=240.00M,
                    Category="Home Kitchen"
                }
            };
        }
    }
}
