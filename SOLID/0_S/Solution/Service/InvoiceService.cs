using SOLID._0_S.Solution.Interfaces;
using static SOLID._0_S.Problem.OrderService;

namespace SOLID._0_S.Solution.Service;
internal class InvoiceService : IInvoiceService
{
    public Invoice CreateInvoice(Order order)
    {
        //Implementación
        return new Invoice();
    }
}
