using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace Dashboard_Parameters {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            // Loads a dashboard from an XML file.
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(@"..\..\Data\Dashboard.xml");

            // Obtains dashboard data sources.
            DataSource dataSource1 = dashboard.DataSources[0];
            DataSource dataSource2 = dashboard.DataSources[1];

            // Creates a new parameter that obtains its values from dataSource2.
            DynamicListLookUpSettings settings = new DynamicListLookUpSettings();
            settings.DataSource = dataSource2;
            settings.ValueMember = "CategoryName";
            settings.DisplayMember = "CategoryName";
            DashboardParameter parameter = 
                new DashboardParameter("Category", typeof(string), "Beverages", "", true, settings);

            // Adds the created parameter to a collection of dashboard parameters.
            dashboard.Parameters.Add(parameter);

            // Includes the created parameter to the dataSource1' filter string.
            dataSource1.Filter = "Categories.CategoryName = ?Category";

            dashboardViewer1.Dashboard = dashboard;
        }
    }
}
