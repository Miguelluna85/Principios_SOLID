namespace SOLID._1_O.Problem;
internal class Program
{
    public static void Main()
    {
        List<Order> orders = new List<Order>();//Get orders from data source

        ReportingService service = new ReportingService();
        service.GenerateReport(orders, ReportType.PDF);
    }

}

