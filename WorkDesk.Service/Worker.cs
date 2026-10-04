using Microsoft.Data.SqlClient;

namespace WorkDesk.Service;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _configuration;

    public Worker(
        ILogger<Worker> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        string connectionString =
            _configuration.GetConnectionString("DefaultConnection")!;

        string logFilePath = "WorkDeskService.log";

        try
        {
            using SqlConnection connection =
                new SqlConnection(connectionString);

            await connection.OpenAsync(stoppingToken);

            _logger.LogInformation(
                "WorkDesk Service connected to SQL Server successfully.");

            WriteLog(
                logFilePath,
                "WorkDesk Service connected to SQL Server successfully.");

            int previousEmployeeCount = -1;

            while (!stoppingToken.IsCancellationRequested)
            {
                string query = "SELECT COUNT(*) FROM Employees";

                using SqlCommand command =
                    new SqlCommand(query, connection);

                int currentEmployeeCount =
                    Convert.ToInt32(
                        await command.ExecuteScalarAsync(stoppingToken));

                _logger.LogInformation(
                    "Employee count: {count}",
                    currentEmployeeCount);

                WriteLog(
                    logFilePath,
                    $"Employee count: {currentEmployeeCount}");

                if (previousEmployeeCount != -1 &&
                    currentEmployeeCount > previousEmployeeCount)
                {
                    _logger.LogInformation(
                        "New employee detected!");

                    WriteLog(
                        logFilePath,
                        "New employee detected!");
                }

                previousEmployeeCount = currentEmployeeCount;

                await Task.Delay(5000, stoppingToken);
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation(
                "WorkDesk Service stopped.");

            WriteLog(
                logFilePath,
                "WorkDesk Service stopped.");
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error while monitoring Employees table.");

            WriteLog(
                logFilePath,
                $"ERROR: {ex.Message}");
        }
    }

    private void WriteLog(string filePath, string message)
    {
        string logMessage =
            $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";

        File.AppendAllText(
            filePath,
            logMessage + Environment.NewLine);
    }
}