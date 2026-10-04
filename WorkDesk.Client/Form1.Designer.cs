namespace WorkDesk.Client;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblDepartment;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblSalary;

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtDepartment;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtSalary;

    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnRefresh;

    private System.Windows.Forms.DataGridView dgvEmployees;

    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();

        this.lblTitle = new System.Windows.Forms.Label();

        this.lblName = new System.Windows.Forms.Label();
        this.lblDepartment = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblSalary = new System.Windows.Forms.Label();

        this.txtName = new System.Windows.Forms.TextBox();
        this.txtDepartment = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtSalary = new System.Windows.Forms.TextBox();

        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnRefresh = new System.Windows.Forms.Button();

        this.dgvEmployees = new System.Windows.Forms.DataGridView();

        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();

        ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();

        this.SuspendLayout();

        // =====================================================
        // FORM
        // =====================================================

        this.AutoScaleDimensions =
            new System.Drawing.SizeF(7F, 15F);

        this.AutoScaleMode =
            System.Windows.Forms.AutoScaleMode.Font;

        this.BackColor =
            System.Drawing.Color.WhiteSmoke;

        this.ClientSize =
            new System.Drawing.Size(1100, 700);

        this.MinimumSize =
            new System.Drawing.Size(950, 600);

        this.StartPosition =
            System.Windows.Forms.FormStartPosition.CenterScreen;

        this.Text =
            "WorkDesk - Employee Management";

        this.Name =
            "Form1";

        this.FormBorderStyle =
            System.Windows.Forms.FormBorderStyle.Sizable;

        this.MaximizeBox = true;
        this.MinimizeBox = true;

        // =====================================================
        // TITLE
        // =====================================================

        this.lblTitle.AutoSize = true;

        this.lblTitle.Font =
            new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold);

        this.lblTitle.ForeColor =
            System.Drawing.Color.FromArgb(30, 30, 30);

        this.lblTitle.Location =
            new System.Drawing.Point(30, 25);

        this.lblTitle.Name =
            "lblTitle";

        this.lblTitle.Text =
            "WorkDesk - Employee Management";

        // =====================================================
        // NAME LABEL
        // =====================================================

        this.lblName.AutoSize = true;

        this.lblName.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.lblName.Location =
            new System.Drawing.Point(40, 100);

        this.lblName.Name =
            "lblName";

        this.lblName.Text =
            "Name:";

        // =====================================================
        // NAME TEXTBOX
        // =====================================================

        this.txtName.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.txtName.Location =
            new System.Drawing.Point(140, 96);

        this.txtName.Name =
            "txtName";

        this.txtName.Size =
            new System.Drawing.Size(260, 25);

        // =====================================================
        // DEPARTMENT LABEL
        // =====================================================

        this.lblDepartment.AutoSize = true;

        this.lblDepartment.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.lblDepartment.Location =
            new System.Drawing.Point(40, 140);

        this.lblDepartment.Name =
            "lblDepartment";

        this.lblDepartment.Text =
            "Department:";

        // =====================================================
        // DEPARTMENT TEXTBOX
        // =====================================================

        this.txtDepartment.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.txtDepartment.Location =
            new System.Drawing.Point(140, 136);

        this.txtDepartment.Name =
            "txtDepartment";

        this.txtDepartment.Size =
            new System.Drawing.Size(260, 25);

        // =====================================================
        // EMAIL LABEL
        // =====================================================

        this.lblEmail.AutoSize = true;

        this.lblEmail.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.lblEmail.Location =
            new System.Drawing.Point(40, 180);

        this.lblEmail.Name =
            "lblEmail";

        this.lblEmail.Text =
            "Email:";

        // =====================================================
        // EMAIL TEXTBOX
        // =====================================================

        this.txtEmail.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.txtEmail.Location =
            new System.Drawing.Point(140, 176);

        this.txtEmail.Name =
            "txtEmail";

        this.txtEmail.Size =
            new System.Drawing.Size(260, 25);

        // =====================================================
        // SALARY LABEL
        // =====================================================

        this.lblSalary.AutoSize = true;

        this.lblSalary.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.lblSalary.Location =
            new System.Drawing.Point(40, 220);

        this.lblSalary.Name =
            "lblSalary";

        this.lblSalary.Text =
            "Salary:";

        // =====================================================
        // SALARY TEXTBOX
        // =====================================================

        this.txtSalary.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F);

        this.txtSalary.Location =
            new System.Drawing.Point(140, 216);

        this.txtSalary.Name =
            "txtSalary";

        this.txtSalary.Size =
            new System.Drawing.Size(260, 25);

        // =====================================================
        // ADD BUTTON
        // =====================================================

        this.btnAdd.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

        this.btnAdd.Location =
            new System.Drawing.Point(450, 96);

        this.btnAdd.Name =
            "btnAdd";

        this.btnAdd.Size =
            new System.Drawing.Size(110, 38);

        this.btnAdd.Text =
            "Add";

        this.btnAdd.UseVisualStyleBackColor = true;

        // =====================================================
        // UPDATE BUTTON
        // =====================================================

        this.btnUpdate.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

        this.btnUpdate.Location =
            new System.Drawing.Point(570, 96);

        this.btnUpdate.Name =
            "btnUpdate";

        this.btnUpdate.Size =
            new System.Drawing.Size(110, 38);

        this.btnUpdate.Text =
            "Update";

        this.btnUpdate.UseVisualStyleBackColor = true;

        // =====================================================
        // DELETE BUTTON
        // =====================================================

        this.btnDelete.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

        this.btnDelete.Location =
            new System.Drawing.Point(690, 96);

        this.btnDelete.Name =
            "btnDelete";

        this.btnDelete.Size =
            new System.Drawing.Size(110, 38);

        this.btnDelete.Text =
            "Delete";

        this.btnDelete.UseVisualStyleBackColor = true;

        // =====================================================
        // REFRESH BUTTON
        // =====================================================

        this.btnRefresh.Font =
            new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold);

        this.btnRefresh.Location =
            new System.Drawing.Point(810, 96);

        this.btnRefresh.Name =
            "btnRefresh";

        this.btnRefresh.Size =
            new System.Drawing.Size(110, 38);

        this.btnRefresh.Text =
            "Refresh";

        this.btnRefresh.UseVisualStyleBackColor = true;

        // =====================================================
        // DATA GRID
        // =====================================================

        this.dgvEmployees.AllowUserToAddRows = false;

        this.dgvEmployees.AllowUserToDeleteRows = false;

        this.dgvEmployees.AllowUserToResizeRows = false;

        this.dgvEmployees.Anchor =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Bottom |
            System.Windows.Forms.AnchorStyles.Left |
            System.Windows.Forms.AnchorStyles.Right;

        this.dgvEmployees.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        this.dgvEmployees.BackgroundColor =
            System.Drawing.Color.White;

        this.dgvEmployees.BorderStyle =
            System.Windows.Forms.BorderStyle.FixedSingle;

        this.dgvEmployees.ColumnHeadersHeight =
            35;

        this.dgvEmployees.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        this.dgvEmployees.Location =
            new System.Drawing.Point(40, 280);

        this.dgvEmployees.MultiSelect =
            false;

        this.dgvEmployees.Name =
            "dgvEmployees";

        this.dgvEmployees.ReadOnly =
            true;

        this.dgvEmployees.RowHeadersVisible =
            false;

        this.dgvEmployees.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

        this.dgvEmployees.Size =
            new System.Drawing.Size(1020, 360);

        // =====================================================
        // ID COLUMN
        // =====================================================

        this.colId.HeaderText =
            "ID";

        this.colId.Name =
            "colId";

        this.colId.ReadOnly =
            true;

        this.colId.FillWeight =
            40;

        // =====================================================
        // NAME COLUMN
        // =====================================================

        this.colName.HeaderText =
            "Name";

        this.colName.Name =
            "colName";

        this.colName.ReadOnly =
            true;

        this.colName.FillWeight =
            100;

        // =====================================================
        // DEPARTMENT COLUMN
        // =====================================================

        this.colDepartment.HeaderText =
            "Department";

        this.colDepartment.Name =
            "colDepartment";

        this.colDepartment.ReadOnly =
            true;

        this.colDepartment.FillWeight =
            100;

        // =====================================================
        // EMAIL COLUMN
        // =====================================================

        this.colEmail.HeaderText =
            "Email";

        this.colEmail.Name =
            "colEmail";

        this.colEmail.ReadOnly =
            true;

        this.colEmail.FillWeight =
            160;

        // =====================================================
        // SALARY COLUMN
        // =====================================================

        this.colSalary.HeaderText =
            "Salary";

        this.colSalary.Name =
            "colSalary";

        this.colSalary.ReadOnly =
            true;

        this.colSalary.FillWeight =
            90;

        // =====================================================
        // ADD COLUMNS
        // =====================================================

        this.dgvEmployees.Columns.AddRange(
            new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colName,
                this.colDepartment,
                this.colEmail,
                this.colSalary
            });

        // =====================================================
        // ADD CONTROLS
        // =====================================================

        this.Controls.Add(this.lblTitle);

        this.Controls.Add(this.lblName);
        this.Controls.Add(this.lblDepartment);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.lblSalary);

        this.Controls.Add(this.txtName);
        this.Controls.Add(this.txtDepartment);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtSalary);

        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnRefresh);

        this.Controls.Add(this.dgvEmployees);

        ((System.ComponentModel.ISupportInitialize)
            (this.dgvEmployees)).EndInit();

        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}