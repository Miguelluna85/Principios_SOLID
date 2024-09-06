namespace SOLID._4_D.Solution;
internal class Program
{
    public static void Main()
    {
        OrderService orderDog= new OrderService(new DatadogService());
        orderDog.GenerateOrder();

        OrderService orderAWS = new OrderService(new AnyOtherMonitoringService());
        orderAWS.GenerateOrder();

        OrderService orderAzure = new OrderService(new AzureMonitoringService());
        orderAWS.GenerateOrder();
    }
}
