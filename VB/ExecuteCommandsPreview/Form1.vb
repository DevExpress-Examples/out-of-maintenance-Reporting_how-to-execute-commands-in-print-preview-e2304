Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace ExecuteCommandsPreview
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report instance, assigned to a Print Tool.
			Dim pt As New ReportPrintTool(New XtraReport1())

			' Get the Print Tool's printing system.
			Dim ps As PrintingSystemBase = pt.PrintingSystem

			' Show a report's Print Preview.
			pt.ShowPreview()

			' Zoom the print preview, so that it fits the entire page.
			ps.ExecCommand(PrintingSystemCommand.ViewWholePage)

			' Invoke the Hand tool.
			ps.ExecCommand(PrintingSystemCommand.HandTool, New Object() { True })

			' Hide the Hand tool.
			ps.ExecCommand(PrintingSystemCommand.HandTool, New Object() { False })
		End Sub

	End Class
End Namespace
