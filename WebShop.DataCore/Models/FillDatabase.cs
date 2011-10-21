using System;
using System.Collections.Generic;
using System.Linq;

using NHibernate;
using NHibernate.Linq;

namespace WebShop.DataCore.Models
{
    public class FillDatabase
    {
        private ISession session;
        public FillDatabase(ISession session)
        {
            this.session = session;
        }

        public List<Category> FillIt()
        {

            //ladda in allt innehåll i databasen.
            //6 kategorier med 2 underkategorier var som i sin tur har en produkt i sig. 

            



            var listOfProducts1 = new List<Product>();
            var listOfProducts2 = new List<Product>();
            var listOfProducts3 = new List<Product>();
            var listOfProducts4 = new List<Product>();
            var listOfProducts5 = new List<Product>();
            var listOfProducts6 = new List<Product>();
            var listOfProducts7 = new List<Product>();
            var listOfProducts8 = new List<Product>();
            var listOfProducts9 = new List<Product>();
            var listOfProducts10 = new List<Product>();
            var listOfProducts11 = new List<Product>();
            var listOfProducts12 = new List<Product>();

            var listOfSubCat1 = new List<SubCategory>();
            var listOfSubCat2 = new List<SubCategory>();
            var listOfSubCat3 = new List<SubCategory>();
            var listOfSubCat4 = new List<SubCategory>();
            var listOfSubCat5 = new List<SubCategory>();
            var listOfSubCat6 = new List<SubCategory>();

            var a1 = (new Product() { Brand = "HP" , Name = "HP-190989783", Pris = 10999.99, NumberInStock = 200, Picture = "/Pictures/thumbnails/laptop.png" });
            var a2 = (new Product() { Brand = "Packard", Name = "Packard bell", Pris =5199.99, NumberInStock = 20, Picture = "/Pictures/thumbnails/staionär.png" });
            var a3 = (new Product() { Brand = "Samsung", Name = "40 tum", Pris = 4999.99, NumberInStock = 15, Picture = "/Pictures/thumbnails/samsung.png" });
            var a4 = (new Product() { Brand = "LG", Name = "32 tum", Pris = 7382.44, NumberInStock = 9, Picture = "/Pictures/thumbnails/lg.png" });
            var a5 = (new Product() { Brand = "Bosch", Name = "Kylskåp", Pris = 3444.99, NumberInStock = 13, Picture = "/Pictures/thumbnails/kyl.png" });
            var a6 = (new Product() { Brand = "Bosch", Name = "Diskmaskin", Pris = 4999.99, NumberInStock = 9, Picture = "/Pictures/thumbnails/diskmaskin.png" });
            var a7 = (new Product() { Brand = "Ericsson", Name = "Xperia Arc", Pris = 4999.99, NumberInStock = 1, Picture = "/Pictures/thumbnails/ericsson.jpg" });
            var a8 = (new Product() { Brand = "Motorola", Name = "Telefon1233", Pris = 4199.99, NumberInStock = 43, Picture = "/Pictures/thumbnails/motorola.jpg" });
            var a9 = (new Product() { Brand = "Nikon", Name = "Kamera", Pris = 4999.99, NumberInStock = 12, Picture = "/Pictures/thumbnails/nikonkamera.jpg" });
            var a10 = (new Product() { Brand = "Nikon", Name = "Videokamera", Pris = 4999.99, NumberInStock = 100, Picture = "/Pictures/thumbnails/videocam.jpg" });
            var a11 = (new Product() { Brand = "Sony", Name = "Playstation3", Pris = 7599.99, NumberInStock = 300, Picture = "/Pictures/thumbnails/playstation3.jpg" });
            var a12 = (new Product() { Brand = "Microsoft", Name = "XBOX 360", Pris = 4999.99, NumberInStock = 15, Picture = "/Pictures/thumbnails/xbox.jpg" });

          

            var c1 = (new ProductsOnCampaign() {CampaginPrice = 3999.99,Product = a1, StartTime = DateTime.Now});
            var c2 = (new ProductsOnCampaign() { CampaginPrice = 3999.99, Product = a2, StartTime = DateTime.Now });
            var c3 = (new ProductsOnCampaign() { CampaginPrice = 3999.99, Product = a3,StartTime = DateTime.Now });
            var c4 = (new ProductsOnCampaign() { CampaginPrice = 3999.99, Product = a4 ,StartTime = DateTime.Now});
            var c5 = (new ProductsOnCampaign() { CampaginPrice = 3999.99, Product = a5,StartTime = DateTime.Now });
            var c6 = (new ProductsOnCampaign() { CampaginPrice = 3999.99, Product = a6,StartTime = DateTime.Now });

            session.SaveOrUpdate(c1);
            session.SaveOrUpdate(c2);
            session.SaveOrUpdate(c3);
            session.SaveOrUpdate(c4);
            session.SaveOrUpdate(c5);
            session.SaveOrUpdate(c6);

            session.Save(c1);
            session.Save(c2);
            session.Save(c3);
            session.Save(c4);
            session.Save(c5);
            session.Save(c6);
          


            session.Save(a1);
            session.Save(a2);
            session.Save(a3);
            session.Save(a4);
            session.Save(a5);
            session.Save(a6);
            session.Save(a7);
            session.Save(a8);
            session.Save(a9);
            session.Save(a10);
            session.Save(a11);
            session.Save(a12);
   


            listOfProducts1.Add(a1);
            listOfProducts2.Add(a2);
            listOfProducts3.Add(a3);
            listOfProducts4.Add(a4);
            listOfProducts5.Add(a5);
            listOfProducts6.Add(a6);
            listOfProducts7.Add(a7);
            listOfProducts8.Add(a8);
            listOfProducts9.Add(a9);
            listOfProducts10.Add(a10);
            listOfProducts11.Add(a11);
            listOfProducts12.Add(a12);

            //Underkategorier


            var laptops = (new SubCategory() { Name = "Bärbara", ProductList = listOfProducts1 });
            var regularcomputers = (new SubCategory() { Name = "Stationära", ProductList = listOfProducts2 });

            var tv1 = (new SubCategory() { Name = "Plattskärmar", ProductList = listOfProducts3 });
            var tv2 = (new SubCategory() { Name = "Tjock-TV", ProductList = listOfProducts4 });

            var ericsson = (new SubCategory() { Name = "Ericsson", ProductList = listOfProducts7 });
            var motorola = (new SubCategory() { Name = "Motorola", ProductList = listOfProducts8 });


            var refrigirators = (new SubCategory() { Name = "Kylskåp", ProductList = listOfProducts5});
            var dishwasher = (new SubCategory() { Name = "Diskmaskiner", ProductList = listOfProducts6 });

            var camera = (new SubCategory() { Name = "Kameror", ProductList = listOfProducts9 });
            var videoCamera = (new SubCategory() { Name = "Videokameror", ProductList = listOfProducts10 });

            var playstation = (new SubCategory() { Name = "Playstation", ProductList = listOfProducts11 });
            var xBox = (new SubCategory() { Name = "XBOX", ProductList = listOfProducts12 });

            session.Save(tv2);
            session.Save(tv1);
            session.Save(ericsson);
            session.Save(laptops);
            session.Save(regularcomputers);
            session.Save(motorola);
            session.Save(refrigirators);
            session.Save(camera);
            session.Save(xBox);
            session.Save(videoCamera);
            session.Save(playstation);
            session.Save(dishwasher);


            listOfSubCat1.Add(laptops);
            listOfSubCat1.Add(regularcomputers);
            listOfSubCat2.Add(tv1);
            listOfSubCat2.Add(tv2);
            listOfSubCat3.Add(motorola);
            listOfSubCat3.Add(ericsson);
            listOfSubCat4.Add(refrigirators);
            listOfSubCat4.Add(dishwasher);
            listOfSubCat5.Add(videoCamera);
            listOfSubCat5.Add(camera);
            listOfSubCat6.Add(playstation);
            listOfSubCat6.Add(xBox);


            var Computers = (new Category() { Name = "Datorer", CategoryPicture = "/Pictures/computer.png", ListOfSubCategories = listOfSubCat1, Class = "greenyellow" });
            var Tvs = (new Category() { Name = "TV", CategoryPicture = "/Pictures/tv.png", ListOfSubCategories = listOfSubCat2, Class = "purple" });
            var Phones = (new Category() { Name = "Telefoner", CategoryPicture = "/Pictures/telephone.png", ListOfSubCategories = listOfSubCat3, Class = "orange" });
            var Vitvaror = (new Category() { Name = "Vitvaror", CategoryPicture = "/Pictures/thumbnails/kyl.png", ListOfSubCategories = listOfSubCat4, Class = "darkgreen" });
            var FotoAndVideo = (new Category() { Name = "Foto och Video", CategoryPicture = "/Pictures/camera.png", ListOfSubCategories = listOfSubCat5, Class = "lightblue" });
            var GamesAndConsoles = (new Category() { Name = "Konsoller", CategoryPicture = "/Pictures/playstation.png", ListOfSubCategories = listOfSubCat6, Class = "blue" });

            

            
            session.SaveOrUpdate(Computers);
            session.SaveOrUpdate(Tvs);
            session.SaveOrUpdate(Phones);
            session.SaveOrUpdate(Vitvaror);
            session.SaveOrUpdate(FotoAndVideo);
            session.SaveOrUpdate(GamesAndConsoles);


            session.Flush();
            var result = session.Query<Category>().ToList();

  
            session.Dispose();
            return result;

        }


    }
}
