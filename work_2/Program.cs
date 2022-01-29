using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_2
{
    internal class Program
    {
        internal class Product
        {
            public string ProductName { get; set; }
            public string ProductCategory { get; set; }
            public int ProductStok { get; set; }
            public int ProductPrice { get; set; }


        }
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.ProductName = "Ayakkabı";
            urun1.ProductCategory = "Kadın";
            urun1.ProductStok = 21;
            urun1.ProductPrice = 320;

            Product urun2 = new Product();
            urun2.ProductName = "Pantolon";
            urun2.ProductCategory = "Erkek";
            urun2.ProductStok = 10;
            urun2.ProductPrice = 185;

            Product urun3 = new Product();
            urun3.ProductName = "Gömlek";
            urun3.ProductCategory = "Unisex";
            urun3.ProductStok = 100;
            urun3.ProductPrice = 85;

            Product urun4 = new Product();
            urun4.ProductName = "Gözlük";
            urun4.ProductCategory = "Unisex";
            urun4.ProductStok = 45;
            urun4.ProductPrice = 350;

            Product[] products = new Product[] { urun1, urun2, urun3, urun4 };




            Console.WriteLine("............foreach döngüsü.............");

            foreach (Product urunler in products)
            {
                Console.WriteLine("Ürün Adı: " + urunler.ProductName + " Ürün Kategorisi " + urunler.ProductCategory
                    + " Ürün Stoğu: " + urunler.ProductStok
                    + " adet, " + "Ürün Fiyatı: " + urunler.ProductPrice + "TL");
            }



            Console.WriteLine(".............fon döngüsü............");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + products[i].ProductName + "  Ürün Kategorisi: "
                    + products[i].ProductCategory + "  Ürün stok adedi: " + products[i].ProductStok
                    + "  Ürün Fiyatı: " + products[i].ProductPrice + " TL");
            }


            Console.WriteLine(".............while döngüsü...........");

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine("İsmi: " + products[x].ProductName + " Kategorisi: " + products[x].ProductCategory +
                    " Stok: " + products[x].ProductStok + " Fiyat: " + products[x].ProductPrice + " TL");
                x++;
            }

        }
    }
}
