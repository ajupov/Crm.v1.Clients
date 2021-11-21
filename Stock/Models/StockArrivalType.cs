namespace Crm.v1.Clients.Stock.Models
{
    public enum StockArrivalType : byte
    {
        ArrivalFromSupplier = 1,
        RefundFromCustomer = 2,
        OversupplyFromInventory = 3
    }
}
