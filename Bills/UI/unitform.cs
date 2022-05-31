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
    public partial class unitform : Form
    {
        BillSystemDB db;
        public unitform()
        {
            InitializeComponent();
            db = new BillSystemDB();
        }

        private void btn_unitsave_Click(object sender, EventArgs e)
        {
            var Type_data = db.Units.SingleOrDefault(ui => ui.unt_name == txt_unitName.Text);
            if (txt_unitName.Text != "")
            {
                if (Type_data == null)
                {
                    Unit u = new Unit()
                    {
                      unt_name = txt_unitName.Text,
                      unt_notes = txt_unitNotes.Text
                    };

                    db.Units.Add(u);
                    db.SaveChanges();
                    label_error.Text = "Done";
                    label_error.ForeColor = Color.Green;
                }
                else
                {
                    label_error.Text = "Unit Name has already existed before";
                    label_error.ForeColor = Color.Red;
                }
            }
            else
            {
                label_error.Text = "Unit Name is Required";
                label_error.ForeColor = Color.Red;
            }
        }

        private void btn_unitCancel_Click(object sender, EventArgs e)
        {
            txt_unitName.Text = txt_unitNotes.Text = "";
            label_error.Text = "";
        }
    }
}
