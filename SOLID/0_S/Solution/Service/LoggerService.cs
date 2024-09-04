using SOLID._0_S.Solution.Interfaces;

namespace SOLID._0_S.Solution.Service;
internal class LoggerService : ILoggerService
{
    public LoggerService()
    {
            //Code por initialization
            //that is crating the Log file with necessary details
    }
    public void Error(string message, Exception ex)
    {
        //Implentation
    }

    public void Info(string message)
    {
        //Implentation
    }

    public void Warn(string message)
    {
        //Implentation
    }
}
