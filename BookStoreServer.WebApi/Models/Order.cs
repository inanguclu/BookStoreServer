using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.ValueObjects;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreServer.WebApi.Models;

public sealed class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }//16 hane ve unique olacak TNR2023000000001


    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book Book { get; set; }


    public Money Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentType { get; set; }
    public string PaymentNumber { get; set; }

    public static string GetNewOrderNumber()
    {

        string initialLatter = "TNR";//seri no
        string year = DateTime.Now.Year.ToString();//siparişin mevcut yılı
        string orderNumber = initialLatter + year;
        string newOrderNumber = orderNumber;//kontrol için orjinal degeri saklıyorum 

        AppDbContext context = new();
        var lastOrder = context.Orders.OrderByDescending(o => o.Id).FirstOrDefault();//son sşparişi aldım
        string currentOrderNumber = lastOrder?.OrderNumber;//son siparişin numarasını aldım 

        if (currentOrderNumber != null)//son siparis varmı kontrolu yapıyorum
        {
            string currentYear = currentOrderNumber.Substring(3, 4);//son siparisin yılını aldım

            if (currentYear == year)//yıl ile mevcut yılı kontrol ediyorum
            {
                currentOrderNumber = currentOrderNumber.Substring(7);//son siparisin numarasını aldım
                int currentOrderNumberInt = int.Parse(currentOrderNumber);//son siparis numarasını inte cevirdim 
                
                bool isOrderNumberUnique = false;//siparis numaramın unique olmasını kontrol ediyorum
                while (!isOrderNumberUnique)
                {

                    currentOrderNumberInt++;
                    orderNumber = newOrderNumber + currentOrderNumberInt.ToString("D9");

                    var order = context.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);

                    if (order == null)
                    {
                        isOrderNumberUnique = true;
                    }
                }

            }
            else
            {
                int currentOrderNumberInt = 0;
                bool isOrderNumberUnique = false;
                while (!isOrderNumberUnique)
                {

                    currentOrderNumberInt++;
                    orderNumber = newOrderNumber + currentOrderNumberInt.ToString("D9");

                    var order = context.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);

                    if (order == null)
                    {
                        isOrderNumberUnique = true;
                    }
                }
                
            }

        }
        else
        {
            orderNumber += "000000001";
        }
        return orderNumber;

    }
}
