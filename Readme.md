<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_Parameters/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_Parameters/Form1.vb))
<!-- default file list end -->
# How to Pass a Dashboard Parameter to a Filter String


This example demonstrates how to [create a new dashboard parameter](https://docs.devexpress.com/Dashboard/16169) and [pass](https://docs.devexpress.com/Dashboard/16170) it to a dashboard item filter string.


In this example, the dashboard data source contains two queries - the **SalesPerson** query is used for data visualization while the **Categories** query provides values for the dashboard parameter.

The dashboard parameter is included into the dashboard item's filter expressions. When the parameter changes, the dashboard updates the displayed data.

![](/images/screenshot.png)

API in this example:

* [DashboardParameter ](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter) class
* [DynamicListLookUpSettings](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DynamicListLookUpSettings) class
* [Dashboard.Parameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.Parameters) property
* [DataDashboardItem.FilterString](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataDashboardItem.FilterString) property

## Documentation

* [Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)

## More Examples

* [How to: Pass a Dashboard Parameter to a Calculated Field's Expression in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-calculated-fields-expression-in-code-e5135)
* [How to: Pass a Dashboard Parameter to a Custom SQL Query in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-custom-sql-query-in-code-e5120)
* [How to: Pass a Hidden Dashboard Parameter to a Custom SQL Query in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-pass-a-hidden-dashboard-parameter-to-a-custom-sql-query-in-the-winforms-viewer-t338459)
* [How to: Specify Default Parameter Values in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-specify-default-parameter-values-in-the-winforms-viewer-t475858)
* [How to: Use Dashboard Parameters with the Expression Format Condition](https://github.com/DevExpress-Examples/how-to-usedashboard-parameters-with-the-expressionformat-condition-t260065)
* [How to: Manage Parameters in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-manage-dashboard-parameters-in-code-t635871)
* [How to: Display the Others Slice in the Pie Chart](https://github.com/DevExpress-Examples/how-to-display-pie-chart-others-slice)



