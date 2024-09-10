using SOLID._1_O.Problem;

namespace SOLID._1_O.Solution;
internal class Program
{
    public static void Main()
    {
        List<Order> orders = new List<Order>();//Get orders from data source

        ReportingService serviceXML = new ReportingService(new ReportGeneratorXML());//send implementation
        serviceXML.GenerateReport(orders);

        ReportingService servicePDF = new ReportingService(new ReportGeneratorPDF());//send implementation
        servicePDF.GenerateReport(orders);

        ReportingService serviceJson = new ReportingService(new ReportGeneratorJson());//send implementation
        serviceJson.GenerateReport(orders);
    }
}
