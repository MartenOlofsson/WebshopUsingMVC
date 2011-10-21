
using System.Collections.Generic;


namespace WebShop.DataCore.Models
{
    public class Cart
    {
        public static DictionaryAndTotalpriceHolder TakeEventsAndDoCalculations(IList<CartUpdateEvents> evennts)
        {
            var cartRows = new DictionaryAndTotalpriceHolder();
            for (int i = 0; i < evennts.Count; i++)
            {

                if (cartRows.dictionary.ContainsKey(evennts[i].Product))
                {

                    cartRows.dictionary[evennts[i].Product].TotalPrice += ((evennts[i].Product.Pris) * evennts[i].Change);
                    cartRows.dictionary[evennts[i].Product].TotalAmount += evennts[i].Change;

                    if (cartRows.dictionary[evennts[i].Product].TotalAmount == 0)
                    {

                        cartRows.dictionary.Remove(evennts[i].Product);
                    }
                    cartRows.Amount += ((evennts[i].Product.Pris) * evennts[i].Change);
                }
                else
                {
                    var outputModel = new CartOutputModel();
                    
                    outputModel.TotalAmount = evennts[i].Change;
                    outputModel.TotalPrice += (evennts[i].Product.Pris*evennts[i].Change);
                    cartRows.Amount += outputModel.TotalPrice;
                    cartRows.dictionary.Add(evennts[i].Product, outputModel);
                }
            }

            return cartRows;
        }

    }
}

