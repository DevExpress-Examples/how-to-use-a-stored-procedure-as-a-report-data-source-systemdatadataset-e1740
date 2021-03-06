using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace RepStoredProc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            
            report.RequestParameters = false;
            new ReportPrintTool(report).ShowPreview();
            report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, new object[] { true });
        }
    }
}