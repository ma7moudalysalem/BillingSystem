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

namespace Bills.UI
{
    public partial class companyForm : Form
    {
        BillSystemDB db;
        public companyForm()
        {
            InitializeComponent();
            db = new BillSystemDB();
        }

        private void btn_compSave_Click(object sender, EventArgs e)
        {
            var Type_data = db.Companies.SingleOrDefault(com => com.company_name == txt_compName.Text);
            if (txt_compName.Text != "")
            {
                if (Type_data == null)
                {
                    Company co = new Company()
                    {
                        company_name = txt_compName.Text,
                        company_notes = txt_compNotes.Text
                    };
                    
                    db.Companies.Add(co);
                    db.SaveChanges();
                    label_error.Text = "Done";
                    label_error.ForeColor = Color.Green;
                }
                else
                {
                    label_error.Text = "Company Name has already existed before";
                    label_error.ForeColor = Color.Red;
                }
            }
            else
            {
                label_error.Text = "company Name is Required";
                label_error.ForeColor = Color.Red;
            }
        }

        private void btn_compCancle_Click(object sender, EventArgs e)
        {
            txt_compName.Text = txt_compNotes.Text = "";
            label_error.Text = "";

        }
    }
}
