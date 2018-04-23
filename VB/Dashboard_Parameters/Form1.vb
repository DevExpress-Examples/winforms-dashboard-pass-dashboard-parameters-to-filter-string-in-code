Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon

Namespace Dashboard_Parameters
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            ' Loads a dashboard from an XML file.
            Dim dashboard As New Dashboard()
            dashboard.LoadFromXml("..\..\Data\Dashboard.xml")

            ' Obtains dashboard items and specifies idenifiers for required data items.
            Dim grid As GridDashboardItem = CType(dashboard.Items(0), GridDashboardItem)
            Dim pie As PieDashboardItem = CType(dashboard.Items(1), PieDashboardItem)
            CType(grid.Columns(0), GridDimensionColumn).Dimension.UniqueId = "categoryColumn"
            pie.SeriesDimensions(0).UniqueId = "categorySeries"

            ' Obtains the dashboard data source used to provide parameter values.
            Dim parameterDataSource As DashboardSqlDataSource =
                CType(dashboard.DataSources(0), DashboardSqlDataSource)

            ' Creates a new parameter that obtains its values from the Categories query.
            Dim settings As New DynamicListLookUpSettings()
            settings.DataSource = parameterDataSource
            settings.DataMember = "Categories"
            settings.ValueMember = "CategoryName"
            Dim parameter As New DashboardParameter("categoryParameter", GetType(String), _
                                                    "Beverages", "Select categories:", True, settings)
            ' Enables multi-selection for the created parameter.
            parameter.AllowMultiselect = True

            ' Adds the created parameter to a collection of dashboard parameters.
            dashboard.Parameters.Add(parameter)

            ' Includes the created parameter in filter strings as an operand value.
            grid.FilterString = "categoryColumn in (?categoryParameter)"
            pie.FilterString = "categorySeries in (?categoryParameter)"

            dashboardViewer1.Dashboard = dashboard
        End Sub
    End Class
End Namespace
