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

        string initialLatter = "TNR";
        string year = DateTime.Now.Year.ToString();
        string orderNumber = initialLatter + year;

        AppDbContext context = new();
        var lastOrder= context.Orders.OrderByDescending(o=>o.Id).FirstOrDefault();
        string currentOrderNumber = lastOrder?.OrderNumber.Substring(7);
        if (currentOrderNumber != null)
        {
            int currentOrderNumberInt =int.Parse(currentOrderNumber);
            currentOrderNumberInt++;
            orderNumber += currentOrderNumberInt.ToString("D9");
        }
        else
        {
            orderNumber += "000000001";
        }
        return orderNumber;

    }
}
