using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_D.Problem;

internal class OrderService
{
    public readonly DataDogService dataDogService;
    public OrderService(DataDogService DataDogService)
    {
            dataDogService = DataDogService;
    }

    public void GenerateOrder(DataDogService order)
    {
        // Todo codigo para crear la orden

        //send notication to datadog
        dataDogService.LogEvent("The Rder was successfully created");

    }




}
