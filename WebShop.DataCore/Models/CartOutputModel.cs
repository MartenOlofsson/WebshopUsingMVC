
namespace WebShop.DataCore.Models
{
    public class CartOutputModel
    {
                        
            public virtual int TotalAmount { get; set; }
            public virtual double TotalPrice { get; set; }
            public virtual int Id { get; set; }
            public virtual double WholeCartPrice { get; set; }
    }

}
