using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddRowButton_Clicked(object sender, EventArgs e)
        {
            if (Index.Text != null && Convert.ToInt32(Index.Text) < (this.viewModel.Employees.Count)
            && Convert.ToInt32(Index.Text) >= 0)
            {
                Employee newItem = new Employee()
                {
                    EmployeeID = 101,
                    Name = "Added Row",
                    IDNumber = 14417807,
                    ContactID = 2014,
                    ManagerID = 60,
                    LoginID = "Row",
                    Gender = "ABC",
                    Title = "ABC",
                    MaritalStatus = "XYZ",
                    SickLeaveHours = 15,
                    Salary = 200000,
                    EmployeeStatus = false,
                    Rating = 4
                };
                this.viewModel.Employees.Insert(Convert.ToInt32(Index.Text), newItem);
            }
            else
                Index.Text = "";
        }


        private void DeleteRowButton_Clicked(object sender, EventArgs e)
        {
            if (Index.Text != null && Convert.ToInt32(Index.Text) < (this.viewModel.Employees.Count)
            && Convert.ToInt32(Index.Text) >= 0)
                this.viewModel.Employees.RemoveAt(Convert.ToInt32(Index.Text));
            else
                Index.Text = "";
        }

        private void DeleteColumnButton_Clicked(object sender, EventArgs e)
        {
            if (Index.Text != null && Convert.ToInt32(Index.Text) < (dataGrid.Columns.Count)
            && Convert.ToInt32(Index.Text) >= 0)
                dataGrid.Columns.RemoveAt(Convert.ToInt32(Index.Text));
            else
                Index.Text = "";
        }

        private void AddColumnButton_Clicked(object sender, EventArgs e)
        {
            if (Index.Text != null && Convert.ToInt32(Index.Text) < (dataGrid.Columns.Count)
            && Convert.ToInt32(Index.Text) >= 0)
            {
                var col = new DataGridTextColumn()
                {
                    MappingName = "AddedColumn",
                    HeaderText = "AddedColumn"
                };
                dataGrid.Columns.Insert(Convert.ToInt32(Index.Text), col);
            }
            else
                Index.Text = "";
        }
    }
}
