using static SOLID._0_S.Problem.OrderService;

namespace SOLID._0_S.Solution.Interfaces;
internal interface INotificationService
{
    bool EmailInvoice(Invoice invoice);
}
