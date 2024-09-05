namespace SOLID._1_O.Problem;
internal class ReportingService
{
    public void GenerateReport(List<Order> orders, ReportType type)
    {
        //Generic code to create report
        //Specific conversion depending on type

        if (type == ReportType.PDF)
        {
            CreatePDFReport(orders);
        }
        else if (type==ReportType.EXCEL)
        {
            CreateExcelReport(orders);
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

}

public enum ReportType
{
    PDF,
    EXCEL
}
