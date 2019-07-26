using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace Dashboard_Parameters {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            // Obtain dashboard items and specify identifiers for data items.
            GridDashboardItem grid = (GridDashboardItem)dashboard.Items[0];
            PieDashboardItem pie = (PieDashboardItem)dashboard.Items[1];  
            ((GridDimensionColumn)grid.Columns[0]).Dimension.UniqueId = "categoryColumn";
            pie.SeriesDimensions[0].UniqueId = "categorySeries";

            // Obtain the dashboard data source used to provide parameter values.
            DashboardSqlDataSource parameterDataSource = 
                (DashboardSqlDataSource)dashboard.DataSources[0];

            // Create a new parameter that obtains its values from the Categories query.
            DynamicListLookUpSettings settings = new DynamicListLookUpSettings();
            settings.DataSource = parameterDataSource;
            settings.DataMember = "Categories";
            settings.ValueMember = "CategoryName";
            DashboardParameter parameter = new DashboardParameter("categoryParameter", 
                typeof(string), "Beverages", "Select categories:", true, settings);
            // Enable multi-selection for the created parameter.
            parameter.AllowMultiselect = true;

            // Add the created parameter to a collection of dashboard parameters.
            dashboard.Parameters.Add(parameter);

            // Include the created parameter in filter strings as an operand value.
            grid.FilterString = "categoryColumn in (?categoryParameter)";
            pie.FilterString = "categorySeries in (?categoryParameter)";

            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
