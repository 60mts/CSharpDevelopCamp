using OOP1;

Product product = new Product();
product.Id = 1;
product.ProductName = "Mobilya";
product.UnitInStock = 5;
product.UnitPrice = 200;
product.CategoryId = 2;

Product product1 = new Product { Id=5,CategoryId=7,UnitInStock=3};

ProductManager productManager = new ProductManager();
productManager.Topla(2, 5);
Console.Read();
Console.WriteLine("Merhaba Özcan");

