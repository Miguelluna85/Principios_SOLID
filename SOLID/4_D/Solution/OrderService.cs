using SOLID._4_D.Solution.Interfaces;

namespace SOLID._4_D.Solution;
internal class OrderService
{
    public readonly IEventNotificationService eventNotificationService;

    public OrderService(IEventNotificationService EventNotificationService)
    {
        eventNotificationService = EventNotificationService;            
    }

    public void GenerateOrder()
    {
        //Codigo para crear la orden

        //Send notification to datadog
        eventNotificationService.LogEvent("The order was successfully created");
    }
}

public class Order
{

}
