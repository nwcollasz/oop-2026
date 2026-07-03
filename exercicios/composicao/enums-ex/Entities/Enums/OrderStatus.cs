namespace EnumsEx.Entities.Enums
{
    public enum OrderStatus : int // : é uma herança, ou seja, o tipo do enum é int, mas poderia ser byte, char, etc.
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}