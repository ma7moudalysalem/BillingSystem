using Bills.DBcontext;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bills.UI
{
    public partial class item : Form
    {
        BillSystemDB db;
        public item()
        {
            InitializeComponent();
            db = new BillSystemDB();
            loadCompanyName();
            loadTypeName();
            loadUnitName();
        }
        private void loadCompanyName()
        {
            cb_itemcompanyname.DataSource = db.Companies.ToList();
            cb_itemcompanyname.DisplayMember = "company_name";
            cb_itemcompanyname.ValueMember = "compan_id";

        }

        private void loadTypeName()
        {
            cb_itemtypename.DataSource = db.Types.Where(type => type.company_id == (int)cb_itemcompanyname.SelectedValue).ToList();
            cb_itemtypename.DisplayMember = "typ_name";
            cb_itemtypename.ValueMember = "typ_id";

        }
        private void loadUnitName()
        {
            cb_itemtunitname.DataSource = db.Units.ToList();
            cb_itemtunitname.DisplayMember = "unt_name";
            cb_itemtunitname.ValueMember = "unt_id";

        }

        public void clearAllTexts()
        {
            txt_itemname.Text = "";
            rtxt_itemnotes.Text = "";
            nud_itembuyingprice.Value = 0;
            nud_itemsellingprice.Value = 0;
            cb_itemcompanyname.SelectedIndex = 0;
            cb_itemtunitname.SelectedIndex = 0;
            cb_itemtypename.SelectedIndex = 0;
        }

        string erroeMesage;
        bool error;
        private void btn_save_Click(object sender, EventArgs e)
        {
            erroeMesage = "";
            error = false;
            if (txt_itemname.Text.Equals(""))
            {
                error = true;
                erroeMesage += "Item Name is Required";
            }
            var Item_Data = db.Items.SingleOrDefault(its => its.item_name == txt_itemname.Text);
            if (Item_Data != null)
            {
                error = true;
                erroeMesage += "\nItem Name Has already existed before";
            }
            decimal sell = nud_itemsellingprice.Value;
            decimal buy = nud_itembuyingprice.Value;

            if (sell < buy)
            {
                error = true;
                erroeMesage += "\nSelling Price Must Be Grater than or Equal Buying Price";
            }
            if (!error)
            {
                Item it = new Item()
                {
                    item_name = txt_itemname.Text,
                    item_notes = rtxt_itemnotes.Text,
                    buy_price = buy,
                    sell_price = sell,
                    //company_id = (int)cb_itemcompanyname.SelectedValue,
                    unit_id = (int)cb_itemtunitname.SelectedValue,
                    type_id = (int)cb_itemtypename.SelectedValue,
                };

                MessageBox.Show($"{it.item_name},{it.item_Code}," +
                    $"{it.type_id},{it.unit_id}," +
                    $"{it.item_notes},{it.sell_price},{it.buy_price}");
                //try
                {
                db.Items.Add(it);
                db.SaveChanges();

                }
               // catch (Exception ex)
                {
                    //MessageBox.Show($"{ex.InnerException.Message}");
                }
                label_error.ForeColor = Color.Green;
                label_error.Text = "Done";

            }
            else
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = erroeMesage;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearAllTexts();
        }

        private void cb_itemcompanyname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadTypeName();
        }

    }
}
