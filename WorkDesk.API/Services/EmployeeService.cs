using Microsoft.Data.SqlClient;
using WorkDesk.API.Models;

namespace WorkDesk.API.Services
{
    public class EmployeeService
    {
        private readonly string _connectionString;

        public EmployeeService(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DefaultConnection")!;
        }

        // GET BY ID
        public Employee? GetEmployeeById(int id)
        {
            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            string query = @"
                SELECT Id, Name, Department, Email, Salary
                FROM Employees
                WHERE Id = @Id";

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Employee
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString()!,
                    Department = reader["Department"].ToString()!,
                    Email = reader["Email"].ToString()!,
                    Salary = Convert.ToDecimal(reader["Salary"])
                };
            }

            return null;
        }

        // GET
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            string query =
                "SELECT Id, Name, Department, Email, Salary FROM Employees";

            using SqlCommand command =
                new SqlCommand(query, connection);

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString()!,
                    Department = reader["Department"].ToString()!,
                    Email = reader["Email"].ToString()!,
                    Salary = Convert.ToDecimal(reader["Salary"])
                });
            }

            return employees;
        }

        // POST
        public void AddEmployee(Employee employee)
        {
            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            string query = @"
                INSERT INTO Employees (Name, Department, Email, Salary)
                VALUES (@Name, @Department, @Email, @Salary)";

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Department", employee.Department);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@Salary", employee.Salary);

            command.ExecuteNonQuery();
        }

        // PUT
        public void UpdateEmployee(Employee employee)
        {
            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            string query = @"
                UPDATE Employees
                SET Name = @Name,
                    Department = @Department,
                    Email = @Email,
                    Salary = @Salary
                WHERE Id = @Id";

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", employee.Id);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Department", employee.Department);
            command.Parameters.AddWithValue("@Email", employee.Email);
            command.Parameters.AddWithValue("@Salary", employee.Salary);

            command.ExecuteNonQuery();
        }

        // DELETE
        public void DeleteEmployee(int id)
        {
            using SqlConnection connection =
                new SqlConnection(_connectionString);

            connection.Open();

            string query = "DELETE FROM Employees WHERE Id = @Id";

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
}