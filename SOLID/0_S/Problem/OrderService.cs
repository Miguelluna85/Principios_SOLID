namespace SOLID._0_S.Problem;
internal class OrderService
{
    public void SaveOrder(Order order)
    {
        try
        {
            this.InsertOrder(order);

            var invoice = this.CreateInvoice(order);

            this.EmailInvoice(invoice);

            File.WriteAllText(@"c:\dev\InfoLog.txt", "The order has been complete");

        }
        catch (Exception e)
        {
            File.WriteAllText(@"c:\ErrorLog.txt", e.Message);
        }
    }
    
    public bool InsertOrder(Order order)
    {
        //Code
        return true;
    }

    public Invoice CreateInvoice(Order order)
    {
        //Code
        return new Invoice();
    }

    public bool EmailInvoice(Invoice invoice)
    {
        return true;
    }

    public class Order
    {

    }
    public class Invoice
    {

    }
}
