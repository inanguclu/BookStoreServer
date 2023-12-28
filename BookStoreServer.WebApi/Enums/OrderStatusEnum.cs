namespace BookStoreServer.WebApi.Enums;

public enum OrderStatusEnum
{
    AwaitingApproval=0,//Onay bekliyor
    BeingPrepared =1,//Hazırlanıyor
    InTransit =2,//Kargoda
    Delivered =3,//Teslim edildi
    Rejected =4,//Reddedildi
    Returned =5//İade edildi
}