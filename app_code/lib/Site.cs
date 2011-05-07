using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

/// <summary>
/// Summary description for Site
/// </summary>
public class Site
{

    static Logger _logger;
    public Site()
	{
        _logger = LogManager.GetCurrentClassLogger();
	}
    public void LogInfo(string message) {
        _logger.Info(message);
    }

    public void LogWarning(string message) {
        _logger.Warn(message);
    }

    public void LogDebug(string message) {
        _logger.Debug(message);
    }

    public void LogError(string message) {
        _logger.Error(message);
    }

    public void LogFatal(string message) {
        _logger.Fatal(message);
    }
}