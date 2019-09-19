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

See also:

* [Member Table: Dashboard Parameters](https://docs.devexpress.com/Dashboard/17505)

