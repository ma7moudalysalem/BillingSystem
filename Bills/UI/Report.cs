using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills.DBcontext;

namespace Bills
{
    public partial class Report : Form
    {
        BillSystemDB db;
        public Report()
        {
            InitializeComponent();
            db = new BillSystemDB();
            dvg_report.Visible = false;
        }

        private void btn_report_save_Click(object sender, EventArgs e)
        {
            dvg_report.Visible = true;
            dvg_report.DataSource = null;
            dvg_report.AutoGenerateColumns = true;
            dvg_report.DataSource = db.Sales_Invoices.Where(
                inv=>inv.invoice_date >= report_TimePicker1.Value&& inv.invoice_date <= report_TimePicker2.Value).Select(inv=>
                new { inv.invoice_employee.employee_name,inv.invoice_client.client_name,inv.invoice_date,inv.invoice_time,inv.invoice_percentage_discount, itemNumber = inv.invoive_items.Count}).ToList();

            Report_Load(null, null);

            lable_Status.Text = "Done";
            lable_Status.ForeColor = Color.Green;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            report_TimePicker1.Value = report_TimePicker2.Value = DateTime.Today;
        }

        private void btn_report_cancel_Click(object sender, EventArgs e)
        {
            dvg_report.Visible = false;
            report_TimePicker1.Value = report_TimePicker2.Value = DateTime.Today;
            lable_Status.Text = "";
        }

        private void report_TimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            lable_Status.Text = "";
        }

        private void report_TimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            lable_Status.Text = "";
        }
    }
}
