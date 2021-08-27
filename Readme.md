<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600708/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2304)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ExecuteCommandsPreview/Form1.cs) (VB: [Form1.vb](./VB/ExecuteCommandsPreview/Form1.vb))
<!-- default file list end -->
# How to execute commands in Print Preview


<p>This example demonstrates how to execute printing system commands in a report's preview. This may be necessary, for example, to emulate a particular action performed when an end-user clicks on a particular toolbar button, or chooses a particular menu item. To do this, assign a report to a <strong>ReportPrintTool</strong> instance, and use the <strong>PrintingSystemBase.ExecCommand</strong> method of the <strong>PrintTool.PrintingSystem</strong>.</p>
<p>The code below illustrates how to change the zoom value of a report's preview, so that it fits the entire page (via the <strong>ViewWholePage</strong> command), and how to invoke and hide the <strong>Hand</strong> tool which is used to scroll the report's pages. Note that in this instance some commands are called without any parameters, while others require parameters to be passed via the overloaded version of the <strong>ExecCommand</strong> method.</p>
<p>See also: <br /><a href="https://www.devexpress.com/Support/Center/p/E105">How to change visibility of toolbar buttons and menu items in print preview</a><br /><a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2571">How to: Execute and Modify Commands in a Print Preview</a> </p>

<br/>


