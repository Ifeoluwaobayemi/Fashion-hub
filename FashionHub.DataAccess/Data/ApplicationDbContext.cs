
using FashionHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FashionHub.DataAccess.Data
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shirt", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Bags", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Trouser", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Shoes", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Jiji",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "12121",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Jumia",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "AliExpress",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );


               modelBuilder.Entity<Product>().HasData(
     new Product
     {
         Id = 1,
         Name = "Ladies High Waist Skinny Jean- Blue",
         Description = "This remarkable high waist Jean is beautiful, trendy and affordable for Fashionable women. It is designed and tailored to slim fit and trim all waist. It is Stretchy and elastic. It does not fade. it is durable and long lasting. It gives you a perfect shape you desire. It is so rugged and does not wear out. It is comfortable and superb. Every woman deserve to be beautiful. Admire other people's beauty without questioning your own. ",
         Color = "Blue",
         Size = "27-34",
        ListPrice = 99,
         Price = 90,
         Price50 = 85,
         Price100 = 80,
         CategoryId = 3
     },
    new Product
    {
        Id = 2,
        Name = "Men's 2 In 1 Short Sleeve Round Neck T-Shirt & Shorts Set - Blue",
        Description = "Men's 2 In 1 Short Sleeve Round Neck T-Shirt & Shorts Set - BlueQuality is our number one priority. This is a very stylish men's T-shirt suit that include a short sleeve and a pair of shorts. It has been carefully designed to stand the test of time. Make sure you can wear it for a long time. You can wear them in interesting places at any time of the day, such as walking, dating and going to work. I believe that I really have many advantages, such as materials, ventilation, style, you need to wear them to feel.   It has a range of details that will make you stand out. No matter how long you wear it, it will continue to maintain its solid form.",
        Color = "Blue, Green, Black",
        Size = "M, L, XL, XXL",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1
    },
    new Product
    {
        Id = 3,
        Name = "Riapawel Fashion Handbag Bag Shoulder Bags Square Bag",
        Description = "Available in a variety of colors, it is easy to match with a variety of clothes. A popular rectangular underarm bag for parties, leisure, commuting, travel and more.",
        Color = "Black, Green, Black, Peach, Brown e.t.c",
        Size = "small",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 2
    },
    new Product
    {
        Id = 4,
        Name = "New Ladies Women Handbag - Brown",
        Description = "Made of high-quality PU, this elegant set includes a card bag, a wallet, a clutch bag, a shoulder bag and a coin purse. The printed design makes you outstanding from others. The wallet is without letter print. Perfect for office ladies who are in business, working, shopping, or dating.",
        Color = "Brown",
        Size = "small",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 2
    },
new Product
{
    Id = 5,
    Name = "Ladies Sexy Cross Strap High Heels Black",
    Description = "Our shop specializes in quality men's and women's clothing. Believe me, you own one of our products, enough to show off like your friends. To avoid choosing the wrong size, please read the size label carefully. Please select the size according to the \"foot length\".If the feet are thick and wide, please buy large shoes; if the shoes are too large, we recommend wearing insoles.",
    Color = "Black",
    Size = "38-42",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 4
},
new Product
{
    Id = 6,
    Name = "Well-tailored Unisex Up & Down Joggers - Black & Grey",
    Description = "Joggers from Bubbling Fashion Store comes with its own uniqueness, its brings out the style in you whenever it is worn, joggers are versatile choice for casual clothing which brings out the brilliant gear for chilled days, it is for every one who is stylish and urban. The fabrics are made from high quality which are manufactured and carefully paid to durability and comfortability Men designed combat joggers with high quality material from outfit and sportswear.",
    Color = "Black & Grey",
    Size = "S, M, L, XL, XXL, XXXL",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 3
},
new Product
{
    Id = 7,
    Name = "Crew Clothing Cargo Joggers",
    Description = "Easy to wash and quickly dry when you wash. it made of cotton blended material. nice for both casual and cooperate. Our sweatpants and joggers are made for extreme Comfort, fitted with pristine precision and finely crafted with the highest quality fabric. With these , you do not only feel the difference in fitting and comfort but also have access to a wide range of style purposes. These joggers can be worn for different days in a plethora of ways. Flip Wears now has a history of creating functional yet stylish street-wear, covering everything from retro styles to forward-thinking pieces.",
    Color = "Multi",
    Size = "S, M, L, XL, XXL, XXXL, XXXXL",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 3
},
new Product
{
    Id = 8,
    Name = "Ladies Round Neck Polo Printed T-Shirt",
    Description = "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable Nail the smart and demure look with this, Featuring high round neck, short shirt sleeves , Cotton fabric ,",
    Color = "Black",
    Size = "M, L, XL, S",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 1
},
new Product
{
    Id = 9,
    Name = "Boss Lady Ladies Round Neck Polo Printed T-Shirt",
    Description = "100% Cotton material gives you comfortable feeling with High Quality, Cool, Charming & Fashionable Nail the smart and demure look with this, Featuring high round neck, short shirt sleeves , Cotton fabric ,",
    Color = "Yellow",
    Size = "M, L, XL, S",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 1
},
new Product
{
    Id = 10,
    Name = "Top Long Sleeve Top For Ladies - Knitting Top",
    Description = "The fabric is cool and relaxed fit create an extremely flattering silhouette and produces a versatile piece that would go with any style of pant for an effortless, laid-back cool look. And at a brilliant value, these top will ensure that you stand out from the crowd this season without breaking the bank! ",
    Color = "White",
    Size = "S, M, L",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 1
},
new Product
{
    Id = 11,
    Name = "EILIFINTE B06 Casual Crossbody Shoulder Chest Bag-Grey",
    Description = "Lightweight design is easy for carrying: Made From Durable Polyester Fabric with good features of comfortable and portable.",
    Color = "Grey",
    Size = "small",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 2
},
new Product
{
    Id = 12,
    Name = "Shiny Rhinestone Evening Banquet Bag Handbag Purse - Gold",
    Description = "This fashionable handbag is made of durable, high height leather, leather, decorated with leather, water, cocoa, and cocoa for a long time",
    Color = "Gold",
    Size = "small",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 2
},
new Product
{
    Id = 13,
    Name = "EILIFINTE B01 Ladies Causal Stylish Shoulder Bag - Plaid",
    Description = "Lightweight design is easy for carrying: Made From Durable Polyester Fabric with good features of comfortable and portable.",
    Color = "multi",
    Size = "small",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 2
},
new Product
{
    Id = 14,
    Name = "Ladies Square Heels Sandals Elegant Summer Slippers",
    Description = "Material: PU leatherColor: beigeSize: 37, 38, 39, 40Gender: women",
    Color = "beige",
    Size = "37-40",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 4
},
new Product
{
    Id = 15,
    Name = "Fang Kenneth New Design Ladies Fashion Sandals-Black",
    Description = "Another beautiful fashion sandals with unique mid heels. One of lasted sandals on Vogue from well know brand fang Kenneth. Is very beautiful, lovely, strong and the heels is very balance that any lady that love unique design can wear it. Is one beautiful sandals you can wear for long. Thank you for always trusting me for the best.",
    Color = "Black",
    Size = "38-41",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 4
},
new Product
{
    Id = 16,
    Name = "Elegant Ladies Multiple Colour Sandals",
    Description = "Beautiful multiple colors sandals, lovely sandals that can go with any colours of your choice. Nice sandals with perfect fitting. One of trendy Sandals ",
    Color = "Multiple",
    Size = "37-41",
    ListPrice = 99,
    Price = 90,
    Price50 = 85,
    Price100 = 80,
    CategoryId = 4
}


                );
            modelBuilder.Entity<ProductImage>().HasData(
     new ProductImage { Id = 1, ImageUrl = @"\images\products\product-1\3f8cfae8-6e8b-4f77-a981-e2af59d2bec6.jpg", ProductId = 1 },
     new ProductImage { Id = 2, ImageUrl = @"\images\products\product-2\f67ce5a4-6e43-460b-a448-94843acc6717.jpg", ProductId = 2 },
     new ProductImage { Id = 3, ImageUrl = @"\images\products\product-3\af12e749-60c4-4998-a03b-cf84562b6a28.jpg", ProductId = 3 },
     new ProductImage { Id = 4, ImageUrl = @"\images\products\product-4\5dc8829e-951c-4723-98a9-9a477a271094.jpg", ProductId = 4 },
     new ProductImage { Id = 5, ImageUrl = @"\images\products\product-5\906d4ff7-589d-43ec-883a-49f486a19351.jpg", ProductId = 5 },
     new ProductImage { Id = 6, ImageUrl = @"\images\products\product-6\71758c64-0d21-4f1b-b379-316f07753f33.jpg", ProductId = 6 },
     new ProductImage { Id = 7, ImageUrl = @"\images\products\product-7\7dad1cdd-0c8c-4b34-b257-5827e2b386cd.jpg", ProductId = 7 },
     new ProductImage { Id = 8, ImageUrl = @"\images\products\product-8\84c8770c-0262-4ea4-9609-e100bf001a3e.jpg", ProductId = 8 },
     new ProductImage { Id = 9, ImageUrl = @"\images\products\product-9\30f6e2a5-e9c0-4f76-b519-42b39dadf6a0.jpg", ProductId = 9 },
     new ProductImage { Id = 10, ImageUrl = @"\images\products\product-10\4e22b28c-0fea-44d6-89a1-e5fb478e5646.jpg", ProductId = 10 },
     new ProductImage { Id = 11, ImageUrl = @"\images\products\product-11\202f3d19-9e90-48fc-8ae5-160a355bbc7c.jpg", ProductId = 11 },
     new ProductImage { Id = 12, ImageUrl = @"\images\products\product-12\6d98b3eb-715f-40a5-b7a4-3295091d531e.jpg", ProductId = 12},
     new ProductImage { Id = 13, ImageUrl = @"\images\products\product-13\f0deca55-6e82-4988-9955-ce5940928bec.jpg", ProductId = 13 },
     new ProductImage { Id = 14, ImageUrl = @"\images\products\product-14\0a5b0367-dda0-4b5f-b158-935a1c3c5f4b.jpg", ProductId = 14 },
     new ProductImage { Id = 15, ImageUrl = @"\images\products\product-15\92aeb63e-9661-4c5f-8ee9-9dcc22486684.jpg", ProductId = 15 },
     new ProductImage { Id = 16, ImageUrl = @"\images\products\product-16\9afd6a4f-c248-473f-b3bc-4ff9237276d1.jpg", ProductId = 16 }

);

        }
    }
}