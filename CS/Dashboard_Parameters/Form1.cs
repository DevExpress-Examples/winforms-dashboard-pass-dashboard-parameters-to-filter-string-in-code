using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace Dashboard_Parameters {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            // Loads a dashboard from an XML file.
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            // Obtains dashboard items and specifies idenifiers for required data items.
            GridDashboardItem grid = (GridDashboardItem)dashboard.Items[0];
            PieDashboardItem pie = (PieDashboardItem)dashboard.Items[1];  
            ((GridDimensionColumn)grid.Columns[0]).Dimension.ID = "categoryColumn";
            pie.SeriesDimensions[0].ID = "categorySeries";

            // Obtains the dashboard data source used to provide parameter values.
            DashboardSqlDataSource parameterDataSource = 
                (DashboardSqlDataSource)dashboard.DataSources[0];

            // Creates a new parameter that obtains its values from the Categories query.
            DynamicListLookUpSettings settings = new DynamicListLookUpSettings();
            settings.DataSource = parameterDataSource;
            settings.DataMember = "Categories";
            settings.ValueMember = "CategoryName";
            DashboardParameter parameter = new DashboardParameter("categoryParameter", 
                typeof(string), "Beverages", "Select categories:", true, settings);
            // Enables multi-selection for the created parameter.
            parameter.AllowMultiselect = true;

            // Adds the created parameter to a collection of dashboard parameters.
            dashboard.Parameters.Add(parameter);

            // Includes the created parameter in filter strings as an operand value.
            grid.FilterString = "categoryColumn in (?categoryParameter)";
            pie.FilterString = "categorySeries in (?categoryParameter)";

            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
