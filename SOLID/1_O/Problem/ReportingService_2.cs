namespace SOLID._1_O.Problem;
internal class ReportingService_2
{
    public void GenerateReport(List<Order> orders, ReportType_2 type)
    {
        //Generic code to create report
        //Specific conversion depending on type

        if (type == ReportType_2.PDF)
        {
            CreatePDFReport(orders);
        }
        else if (type== ReportType_2.EXCEL)
        {
            CreateExcelReport(orders);
        }
        else if (type == ReportType_2.JSON)
        {
            CreateJsonReport(orders);
        }
        else if (type == ReportType_2.XML)
        {
            CreateXMLReport(orders);
        }
    }

    public void CreatePDFReport(List<Order> orders)
    {
        //Create PDF Report
    }
    public void CreateExcelReport(List<Order> orders)
    {
        //Create Excel Report
    }
    public void CreateJsonReport(List<Order> orders)
    {
        //Create Json Report
    }
    public void CreateXMLReport(List<Order> orders)
    {
        //Create XML Report
    }

}

public enum ReportType_2
{
    PDF,
    EXCEL,
    JSON,
    XML
}
