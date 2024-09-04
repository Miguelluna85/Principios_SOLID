using SOLID._0_S.Solution.Interfaces;

namespace SOLID._0_S.Solution;
internal class OrderService
{
    private readonly IOrderRepository orderRepository;
    private readonly IInvoiceService invoiceService;
    private readonly INotificationService notificationService;
    private readonly ILoggerService loggerService;
    public OrderService(
        IOrderRepository OrderRepository,
        IInvoiceService InvoiceService,
        INotificationService NotificationService,
        ILoggerService LoggerService)
    {
        this.orderRepository = OrderRepository;
        this.invoiceService = InvoiceService;
        this.notificationService = NotificationService;
        this.loggerService = LoggerService;
    }

    public void SaveOrder(Order order)
    {
        try
        {
            orderRepository.InsertOrder(order);

            var invoice = invoiceService.CreateInvoice(order);

            notificationService.EmailInvoice(invoice);

            loggerService.Info("La order ha sido completada");

        }
        catch (Exception ex)
        {

            loggerService.Error(ex.Message, ex);
        }
    }
}
