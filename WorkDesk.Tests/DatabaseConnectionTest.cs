using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WorkDesk.API.Services;

namespace WorkDesk.Tests;

public class DatabaseConnectionTest
{
    private readonly IConfiguration _configuration;

    public DatabaseConnectionTest()
    {
        var settings = new Dictionary<string, string?>
        {
            {
                "ConnectionStrings:DefaultConnection",
                "Server=Prasadpatil;Database=WorkDeskDB;Trusted_Connection=True;TrustServerCertificate=True;"
            }
        };

        _configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(settings)
            .Build();
    }

    [Fact]
    public void Database_ShouldConnectSuccessfully()
    {
        string connectionString =
            _configuration.GetConnectionString("DefaultConnection")!;

        using SqlConnection connection =
            new SqlConnection(connectionString);

        connection.Open();

        Assert.Equal(
            System.Data.ConnectionState.Open,
            connection.State);
    }

    [Fact]
    public void EmployeesTable_ShouldContainRecords()
    {
        string connectionString =
            _configuration.GetConnectionString("DefaultConnection")!;

        using SqlConnection connection =
            new SqlConnection(connectionString);

        connection.Open();

        string query = "SELECT COUNT(*) FROM Employees";

        using SqlCommand command =
            new SqlCommand(query, connection);

        int employeeCount =
            Convert.ToInt32(command.ExecuteScalar());

        Assert.True(employeeCount > 0);
    }

    [Fact]
    public void EmployeeService_ShouldReturnEmployees()
    {
        // Arrange
        EmployeeService service =
            new EmployeeService(_configuration);

        // Act
        var employees = service.GetEmployees();

        // Assert
        Assert.NotNull(employees);
        Assert.NotEmpty(employees);
    }
}