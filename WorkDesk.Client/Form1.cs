using System.Net.Http.Json;

namespace WorkDesk.Client;

public partial class Form1 : Form
{
    // API URL
    private readonly HttpClient _httpClient = new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5000/")
    };

    // Currently selected employee ID
    private int selectedEmployeeId = 0;

    public Form1()
    {
        InitializeComponent();

        // Button events
        btnAdd.Click += btnAdd_Click;
        btnUpdate.Click += btnUpdate_Click;
        btnDelete.Click += btnDelete_Click;
        btnRefresh.Click += btnRefresh_Click;

        // Grid row selection event
        dgvEmployees.CellClick += dgvEmployees_CellClick;

        // Load employees when application starts
        LoadEmployees();
    }


    // =========================================================
    // GET - Load Employees
    // =========================================================

    private async void LoadEmployees()
    {
        try
        {
            var employees =
                await _httpClient.GetFromJsonAsync<List<Employee>>(
                    "api/Employee");

            dgvEmployees.Rows.Clear();

            if (employees != null)
            {
                foreach (var employee in employees)
                {
                    dgvEmployees.Rows.Add(
                        employee.Id,
                        employee.Name,
                        employee.Department,
                        employee.Email,
                        employee.Salary
                    );
                }
            }
        }
        catch (HttpRequestException)
        {
            MessageBox.Show(
                "API is not running.\n\nPlease start WorkDesk.API first.",
                "Connection Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }


    // =========================================================
    // ADD - POST
    // =========================================================

    private async void btnAdd_Click(object? sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            return;
        }

        try
        {
            Employee employee = new Employee
            {
                Name = txtName.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Salary = decimal.Parse(txtSalary.Text.Trim())
            };

            var response =
                await _httpClient.PostAsJsonAsync(
                    "api/Employee",
                    employee);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    "Employee added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();

                LoadEmployees();
            }
            else
            {
                MessageBox.Show(
                    "Failed to add employee.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }


    // =========================================================
    // UPDATE - PUT
    // =========================================================

    private async void btnUpdate_Click(object? sender, EventArgs e)
    {
        if (selectedEmployeeId == 0)
        {
            MessageBox.Show(
                "Please select an employee first.",
                "Select Employee",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        if (!ValidateInput())
        {
            return;
        }

        try
        {
            Employee employee = new Employee
            {
                Id = selectedEmployeeId,
                Name = txtName.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Salary = decimal.Parse(txtSalary.Text.Trim())
            };

            var response =
                await _httpClient.PutAsJsonAsync(
                    $"api/Employee/{selectedEmployeeId}",
                    employee);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    "Employee updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();

                LoadEmployees();
            }
            else
            {
                MessageBox.Show(
                    "Failed to update employee.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }


    // =========================================================
    // DELETE - DELETE
    // =========================================================

    private async void btnDelete_Click(object? sender, EventArgs e)
    {
        if (selectedEmployeeId == 0)
        {
            MessageBox.Show(
                "Please select an employee first.",
                "Select Employee",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        DialogResult result = MessageBox.Show(
            "Are you sure you want to delete this employee?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
        {
            return;
        }

        try
        {
            var response =
                await _httpClient.DeleteAsync(
                    $"api/Employee/{selectedEmployeeId}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    "Employee deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();

                LoadEmployees();
            }
            else
            {
                MessageBox.Show(
                    "Failed to delete employee.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }


    // =========================================================
    // REFRESH - GET
    // =========================================================

    private void btnRefresh_Click(object? sender, EventArgs e)
    {
        ClearFields();

        LoadEmployees();
    }


    // =========================================================
    // GRID ROW CLICK
    // =========================================================

    private void dgvEmployees_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        DataGridViewRow row =
            dgvEmployees.Rows[e.RowIndex];

        selectedEmployeeId =
            Convert.ToInt32(row.Cells["colId"].Value);

        txtName.Text =
            row.Cells["colName"].Value?.ToString() ?? "";

        txtDepartment.Text =
            row.Cells["colDepartment"].Value?.ToString() ?? "";

        txtEmail.Text =
            row.Cells["colEmail"].Value?.ToString() ?? "";

        txtSalary.Text =
            row.Cells["colSalary"].Value?.ToString() ?? "";
    }


    // =========================================================
    // INPUT VALIDATION
    // =========================================================

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show(
                "Please enter employee name.");

            txtName.Focus();

            return false;
        }

        if (string.IsNullOrWhiteSpace(txtDepartment.Text))
        {
            MessageBox.Show(
                "Please enter department.");

            txtDepartment.Focus();

            return false;
        }

        if (string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            MessageBox.Show(
                "Please enter email.");

            txtEmail.Focus();

            return false;
        }

        if (!decimal.TryParse(
                txtSalary.Text.Trim(),
                out decimal salary))
        {
            MessageBox.Show(
                "Please enter a valid salary.");

            txtSalary.Focus();

            return false;
        }

        if (salary < 0)
        {
            MessageBox.Show(
                "Salary cannot be negative.");

            txtSalary.Focus();

            return false;
        }

        return true;
    }


    // =========================================================
    // CLEAR INPUT FIELDS
    // =========================================================

    private void ClearFields()
    {
        txtName.Clear();
        txtDepartment.Clear();
        txtEmail.Clear();
        txtSalary.Clear();

        selectedEmployeeId = 0;

        dgvEmployees.ClearSelection();

        txtName.Focus();
    }


    // =========================================================
    // EMPLOYEE MODEL
    // =========================================================

    private class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Department { get; set; } = "";

        public string Email { get; set; } = "";

        public decimal Salary { get; set; }
    }
}