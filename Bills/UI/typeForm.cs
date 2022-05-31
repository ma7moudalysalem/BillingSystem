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
    public partial class typeForm : Form
    { 
        BillSystemDB db;
        public typeForm()
        {
            InitializeComponent();
            db = new BillSystemDB();
            loadCompanyName();
        }

        private void loadCompanyName()
        {
            cb_companyname.DataSource = db.Companies.ToList();
            cb_companyname.DisplayMember = "company_name";
            cb_companyname.ValueMember = "compan_id";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var Type_data = db.Types.SingleOrDefault(type => type.typ_name == txt_typename.Text);
            if (txt_typename.Text != "")
            {
                if (Type_data == null)
                {
                    Type_p typ = new Type_p()
                    {
                        typ_name = txt_typename.Text,
                        typ_notes = rtxt_typenote.Text,
                        company_id = (int)cb_companyname.SelectedValue
                    };
                    //MessageBox.Show($"{typ.typ_id}");
                    db.Types.Add(typ);
                    lab_typeerror.Text = "";
                    db.SaveChanges();
                    lab_typeerror.Text = "Done";
                    lab_typeerror.ForeColor = Color.Green;
                }
                else
                {
                    lab_typeerror.Text = "Type Name has already existed before";
                    lab_typeerror.ForeColor = Color.Red;
                }
            }
            else
            {
                lab_typeerror.Text = "Type Name is Required";
                lab_typeerror.ForeColor = Color.Red;
            }
            button2_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_companyname.SelectedIndex = 0;
            txt_typename.Text = rtxt_typenote.Text = "";
        }

        private void cb_companyname_MouseDown(object sender, MouseEventArgs e)
        {
            lab_typeerror.Text = "";
        }

        private void txt_typename_MouseDown(object sender, MouseEventArgs e)
        {
            lab_typeerror.Text = "";
        }

        private void rtxt_typenote_MouseDown(object sender, MouseEventArgs e)
        {
            lab_typeerror.Text = "";
        }
    }
}
