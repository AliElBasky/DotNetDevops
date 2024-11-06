using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "Iphone x",
                Description = "this iphone is X",
                ImageFile = "product-1.png",
                Price = 850.00m,
                Category = "Smart Phones"
            },
            new Product()
            {
                Name = "Iphone 11",
                Description = "this iphone is 11",
                ImageFile = "product-2.png",
                Price = 950.00m,
                Category = "Smart Phones"
            },
            new Product()
            {
                Name = "Mo's Iphone",
                Description = "Mohamed Ali Iphone",
                ImageFile = "product-2.png",
                Price = 900.00m,
                Category = "Smart Phones"
            },
        };
    }
}
