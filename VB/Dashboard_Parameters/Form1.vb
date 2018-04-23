Imports Microsoft.VisualBasic
Imports System
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

			' Obtains dashboard data sources.
			Dim dataSource1 As DataSource = dashboard.DataSources(0)
			Dim dataSource2 As DataSource = dashboard.DataSources(1)

			' Creates a new parameter that obtains its values from dataSource2.
			Dim settings As New DynamicListLookUpSettings()
			settings.DataSource = dataSource2
			settings.ValueMember = "CategoryName"
			settings.DisplayMember = "CategoryName"
            Dim parameter _
                As New DashboardParameter("Category", GetType(String), "Beverages", "", True, settings)

			' Adds the created parameter to a collection of dashboard parameters.
			dashboard.Parameters.Add(parameter)

			' Includes the created parameter to the dataSource1' filter string.
			dataSource1.Filter = "Categories.CategoryName = ?Category"

			dashboardViewer1.Dashboard = dashboard
		End Sub
	End Class
End Namespace
