using Bills.DBcontext;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bills.UI
{
    public partial class clients : Form
    {
        BillSystemDB db;
        public clients()
        {
            InitializeComponent();
            db = new BillSystemDB();
        }
        string errormess;
        bool iserror;
        private void btn_client_save_Click(object sender, EventArgs e)
        {

            iserror = false;
            //errormess = "";
            if (txt_client_name.Text == "")
            {
                iserror = true;
                //errormess += "CLIENT NAME is Required";
                ep_client.SetError(txt_client_name, "CLIENT NAME is Required");
            }
            Regex rg = new Regex("[0-9]{14}");
            if (txt_client_phone.Text == "")
            {
                iserror = true;
                //errormess += "\nPHONE is Required";
                ep_client.SetError(txt_client_phone, "PHONE is Required");
            }
            else if (!rg.IsMatch(txt_client_phone.Text))
            {
                iserror = true;
                //errormess += "\nClient Phone Number must be 14 digits:0-9";
                ep_client.SetError(txt_client_phone, "Client Phone Number must be 14 digits:0-9");
            }
            if (txt_client_address.Text == "")
            {
                iserror = true;
                // errormess += "\nAddress is Required";
                ep_client.SetError(txt_client_address, "Address is Required");

            }
            var Type_name = db.Clients.SingleOrDefault(client => client.client_name == txt_client_name.Text);
            if (Type_name != null)
            {
                iserror = true;
                //errormess += "\nClient Name has already existed before";
                ep_client.SetError(txt_client_name, "lient Name has already existed before");

            }


            if (!iserror)
            {
                //lab_typeerror_client.Text = "saving.....";
                Client client1 = new Client()
                {
                    client_name = txt_client_name.Text,
                    client_address = txt_client_address.Text,
                    client_phone = txt_client_phone.Text,
                };
                db.Clients.Add(client1);
                db.SaveChanges();

                lab_typeerror_client.Text = "Done";
                lab_typeerror_client.ForeColor = Color.Green;
                ep_client.SetError(txt_client_name, "");
                ep_client.SetError(txt_client_address, "");
                ep_client.SetError(txt_client_phone, "");
                ep_correct.SetError(txt_client_name, "Correct");
                ep_correct.SetError(txt_client_address, "Correct");
                ep_correct.SetError(txt_client_phone, "Correct");

                btn_client_cancel_Click(null, null);
            }
            else
            {
                lab_typeerror_client.ForeColor = Color.Red;
                lab_typeerror_client.Text = errormess;
            }
        }

        private void clients_Load(object sender, EventArgs e)
        {
            //var Cur_Identity = db.Clients.SqlQuery("select MAX(client_id)+1 from Clients").SingleOrDefault();
            try
            {
                var Cur_Identity = db.Clients.Max(c => c.client_id);
                txt_client_num.Text = Convert.ToString(Cur_Identity + 1);
            }
            catch (Exception ex)
            {
                int Cur_Identity = 1;
                txt_client_num.Text = Convert.ToString(Cur_Identity);
            }
            txt_client_num.Enabled = false;
        }
        private void btn_client_cancel_Click(object sender, EventArgs e)
        {
            txt_client_name.Text = txt_client_phone.Text = txt_client_address.Text = "";
            ep_correct.SetError(txt_client_name, "");
            ep_correct.SetError(txt_client_address, "");
            ep_correct.SetError(txt_client_phone, "");
            clients_Load(null, null);
        }
    }
}
