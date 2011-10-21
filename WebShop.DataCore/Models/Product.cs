namespace WebShop.DataCore.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Pris { get; set; }
        public virtual int NumberInStock { get; set; }
        public virtual string Picture { get; set; }
        public virtual SubCategory SubCat { get; set; }
        public virtual string Brand { get; set; }

    }
}