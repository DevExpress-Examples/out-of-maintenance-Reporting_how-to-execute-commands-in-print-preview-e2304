using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace ExecuteCommandsPreview {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report instance, assigned to a Print Tool.
            ReportPrintTool pt = new ReportPrintTool(new XtraReport1());

            // Get the Print Tool's printing system.
            PrintingSystemBase ps = pt.PrintingSystem;

            // Show a report's Print Preview.
            pt.ShowPreview();

            // Zoom the print preview, so that it fits the entire page.
            ps.ExecCommand(PrintingSystemCommand.ViewWholePage);

            // Invoke the Hand tool.
            ps.ExecCommand(PrintingSystemCommand.HandTool, new object[] { true });

            // Hide the Hand tool.
            ps.ExecCommand(PrintingSystemCommand.HandTool, new object[] { false });
        }

    }
}
