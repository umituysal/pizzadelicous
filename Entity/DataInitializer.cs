using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pizza.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var galeries = new List<Galery>()
            {
                new Galery() {  Image="gallery-1.jpg" },
                new Galery() {  Image="gallery-2.jpg" },
                new Galery() {  Image="gallery-3.jpg" },
                new Galery() {  Image="gallery-4.jpg" }

            };

            foreach (var item in galeries)
            {
                context.Galeries.Add(item);
            }
            context.SaveChanges();


            var kategoriler = new List<Category>()
            {
                new Category() { Name="Kahve" , Description="Kahve Ürünleri" },
                new Category() { Name="Yemekler" , Description="Bilgisayar Ürünleri" },
                new Category() { Name="İçecekler" , Description="Elektronik Ürünleri" },
                new Category() { Name="Tatlılar" , Description="Telefon Ürünleri"},
                new Category() { Name="Atıştırmalıklar" , Description="Beyaz Eşya Ürünleri" },
            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            var carousels = new List<Carousel>()
            {
                new Carousel() { Title="Pizza Alla Romana" ,SubTitle="Romana", Image="bg_1.png", Description="Domates sos, mozzarella peyniri, salam, sosis" },
                new Carousel() { Title="Pizza Alla Turca" ,SubTitle="Turca", Image="bg_2.png", Description="Domates sos, mozzarella peyniri, sucuk, pastırma, yumurta" }


            };

            foreach (var item in carousels)
            {
                context.Carousels.Add(item);
            }
            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product() {Title="Pizza Margherita", Description="Domates sos, mozzarella peyniri", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-1.jpg",CategoryId=1 },
                new Product() {Title="Pizza Ai Funghi", Description=" Domates sos, mozzarella peyniri, mantar", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-2.jpg",CategoryId=1 },
                new Product() {Title="Pizza Ai Quattro Stagioni", Description="Domates sos, mozzarella peyniri, jambon, mantar, turşu biber, zeytin", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-3.jpg",CategoryId=1 },
                new Product() {Title="Pizza Con L’agnello Cottoa", Description=" Domates sos, mozzarella peyniri, karamelize soğan, taze fesleğen, kuzu cotto, fırınlanmış domates", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-4.jpg",CategoryId=2 },
                new Product() {Title="Pizza Venedik", Description="Domates sos, mozzarella peyniri, jambon, mantar, salam", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-5.jpg",CategoryId=2 },
                new Product() {Title="Pizza Alla Marinara", Description=" Domates sos, mozzarella peyniri, karides, midye, tonbalığı", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-6.jpg",CategoryId=2 },
                new Product() {Title="Pizza Speciale", Description=" Domates sos,mozzarella peyniri, jambon, salam, sosis, mantar, yumurta, turşu biber, zeytin", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-7.jpg",CategoryId=3 },
                new Product() {Title="Pizza Di Buffala", Description="Domates sos, mozzarella peyniri, burrata peyniri, roka, çeri domates", Price=17, Stock=5, IsApproved=true ,IsHome = true ,Image="pizza-8.jpg",CategoryId=3 },

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();



            var blogs = new List<Blog>()
            {
                new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=1,CommentId=1, Image="image_1.jpg" },
                new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=2,CommentId=1, Image="image_2.jpg" },
                new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=3,CommentId=1, Image="image_3.jpg" },
                  new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=2,CommentId=1, Image="image_1.jpg" },
                new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=3,CommentId=1, Image="image_2.jpg" },
                new Blog() {Title="The Delicious Pizza",Description="A small river named Duden flows by their place and supplies it with the necessary regelialia.",Date=DateTime.Parse("09/06/2019"), IsApproved=true ,IsHome = true ,CategoryId=1,CommentId=1, Image="image_3.jpg" },

            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();




            var comments = new List<Comment>()
            {
                 new Comment() {  Name="Ahmet Aydın",Subject="ürün tadı",Message="ürün tadı inanılmaz!",Date=DateTime.Parse("09/06/2018 "),IsApproved=true,IsHome=true },
                 new Comment() {  Name="Ahmet Aydın",Subject="ürün tadı",Message="ürün tadı inanılmaz!",Date=DateTime.Parse("09/06/2018 "),IsApproved=true,IsHome=true },
                 new Comment() {  Name="Ahmet Aydın",Subject="ürün tadı",Message="ürün tadı inanılmaz!",Date=DateTime.Parse("09/06/2018 "),IsApproved=true,IsHome=true },
                 new Comment() {  Name="Ahmet Aydın",Subject="ürün tadı",Message="ürün tadı inanılmaz!",Date=DateTime.Parse("09/06/2018 "),IsApproved=true,IsHome=true }

            };

            foreach (var item in comments)
            {
                context.Comments.Add(item);
            }
            context.SaveChanges();




        }
    }
}
