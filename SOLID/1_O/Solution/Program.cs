using SOLID._1_O.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_O.Solution;
internal class Program
{
    public static void Main()
    {
        List<Order> orders = new List<Order>();//Get orders from data source

        ReportingService service = new ReportingService(
                                        new ReportGeneratorXML());//send implementation
        service.GenerateReport(orders);
    }
}
