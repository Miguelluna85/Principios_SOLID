using SOLID._1_O.Problem;

namespace SOLID._1_O.Solution.Interfaces;
internal interface IReportGenerator
{
    void CreateReport(List<Order> orders);
}
