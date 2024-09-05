using SOLID._1_O.Problem;
using SOLID._1_O.Solution.Interfaces;

namespace SOLID._1_O.Solution;
internal class ReportingService
{
    private readonly IReportGenerator reportGenerator;
    public ReportingService(IReportGenerator ReportGenerator)
    {
        reportGenerator = ReportGenerator;
    }

    public void GenerateReport(List<Order> orders)
    {
        reportGenerator.CreateReport(orders);
    }
}
