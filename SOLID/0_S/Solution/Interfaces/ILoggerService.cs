﻿namespace SOLID._0_S.Solution.Interfaces;
internal interface ILoggerService
{
    void Info(string message);
    void Warn(string message);
    void Error(string message, Exception ex);
}
