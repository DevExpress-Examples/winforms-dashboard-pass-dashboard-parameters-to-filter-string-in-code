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
            settings.DisplayMember = "CategoryName";
            DashboardParameter parameter = 
                new DashboardParameter("Category", typeof(string), "Beverages", "", true, settings);

            // Adds the created parameter to a collection of dashboard parameters.
            dashboard.Parameters.Add(parameter);

            // Filters the Grid and Pie dashboard items according to the specified parameter.
            grid.FilterString = "categoryColumn = ?Category";
            pie.FilterString = "categorySeries = ?Category";

            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
