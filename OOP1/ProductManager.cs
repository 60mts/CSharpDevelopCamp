namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Ürün başarılı bir şekilde eklendi." + product.ProductName);
        }

            public int Topla(int sayi1,int sayi2) 
        { 
            return sayi1+sayi2; 
        }
            public void Topla2(int sayi1, int sayi2) 
        {
            Console.WriteLine( sayi1 + sayi2 ); 
        }

    }
    
}      
