<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581226/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5117)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for WinForms - How to Pass a Dashboard Parameter to a Filter String

This example demonstrates how to [create a new dashboard parameter](https://docs.devexpress.com/Dashboard/16169) and [pass](https://docs.devexpress.com/Dashboard/16170) it to a dashboard item filter string.

In this example, the dashboard data source contains two queries - the **SalesPerson** query is used for data visualization while the **Categories** query provides values for the dashboard parameter.

The dashboard parameter is included into the dashboard item's filter expressions. When the parameter changes, the dashboard updates the displayed data.

![](/images/screenshot.png)

## Files to Review:

* [Form1.cs](./CS/Dashboard_Parameters/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_Parameters/Form1.vb))

## API

* [DashboardParameter ](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter) class
* [DynamicListLookUpSettings](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DynamicListLookUpSettings) class
* [Dashboard.Parameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.Parameters) property
* [DataDashboardItem.FilterString](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataDashboardItem.FilterString) property

## Documentation

- [Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)
- [Reference Dashboard Parameters](https://docs.devexpress.com/Dashboard/16170/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/data-analysis/dashboard-parameters/pass-parameter-values)

## More Examples

* [How to: Pass a Dashboard Parameter to a Calculated Field's Expression in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-calculated-fields-expression-in-code-e5135)
* [How to: Pass a Dashboard Parameter to a Custom SQL Query in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-custom-sql-query-in-code-e5120)
* [How to: Pass a Hidden Dashboard Parameter to a Custom SQL Query in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-pass-a-hidden-dashboard-parameter-to-a-custom-sql-query-in-the-winforms-viewer-t338459)
* [How to: Specify Default Parameter Values in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-specify-default-parameter-values-in-the-winforms-viewer-t475858)
* [How to: Use Dashboard Parameters with the Expression Format Condition](https://github.com/DevExpress-Examples/how-to-usedashboard-parameters-with-the-expressionformat-condition-t260065)
* [How to: Manage Parameters in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-manage-dashboard-parameters-in-code-t635871)
* [How to: Display the Others Slice in the Pie Chart](https://github.com/DevExpress-Examples/how-to-display-pie-chart-others-slice)



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-pass-dashboard-parameters-to-filter-string-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-pass-dashboard-parameters-to-filter-string-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
