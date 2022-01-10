using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionStockCardSystem
{
    public partial class RegisterIN : Form
    {
        public RegisterIN()
        {
            InitializeComponent();
        }

        private void cb_rack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }
        string kanban_num = "";
        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && txt_barcode.Text != "" && txt_barcode.Text.Contains('$'))
            {
                try {

                    var kanban_info = txt_barcode.Text.Split('$');
                    txt_material.Text = kanban_info[0];
                    txt_line.Text = kanban_info[1];
                    kanban_num = kanban_info[2];
                    txt_barcode.Text = "";
                    txt_bin_num.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                

            }
        }

        private void RegisterIN_Load(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private string determine_rack_address()
        {
            string result = "";
            if (ck_A.Checked == true)
            {
                result = result + "A";
            }
            else if (ck_B.Checked == true)
            {
                result = result + "B";
            }
            else if (ck_C.Checked == true)
            {
                result = result + "C";
            }
            else if (ck_D.Checked == true)
            {
                result = result + "D";
            }
            else
            {
                result = result = "";
            }

            if (CK_1.Checked == true)
            {
                result = result + "1";
            }
            else if (CK_2.Checked == true)
            {
                result = result + "2";
            }
            else if (CK_3.Checked == true)
            {
                result = result + "3";
            }
            else if (CK_4.Checked == true)
            {
                result = result + "4";
            }
            else if (CK_5.Checked == true)
            {
                result = result + "5";
            }

            return result;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_badge_num.Text == "")
            {
                MessageBox.Show("Badge Number Missing !");
            }
            else if (txt_bin_num.Text == "")
            {
                MessageBox.Show("Bin Number Missing !");
            }
            else if (txt_qty.Text == "")
            {
                MessageBox.Show("Quantity Missing !");
            }
            else
            {

                decimal in_qty = decimal.Parse(txt_qty.Text);
                string rack_address = determine_rack_address();

                RegisterINDB regINDB = new RegisterINDB();
                string msg = regINDB.RegisterINBin(txt_badge_num.Text, txt_material.Text, in_qty,txt_bin_num.Text,txt_line.Text, kanban_num, rack_address);
                var msg_array = msg.Split('$');

                MessageBox.Show(msg_array[1] + " !");

                txt_badge_num.Text = "";
                txt_bin_num.Text = "";
                txt_material.Text = "";
                txt_line.Text = "";
                txt_qty.Text = "";
                txt_barcode.Focus();
                kanban_num = "";
                uncheck_check_box();
            }

        }

        private void RegisterIN_Activated(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private void txt_bin_num_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txt_qty.Focus();
            }
        }

        private void uncheck_check_box()
        {
            if (ck_B.Checked == true)
            {
                ck_B.Checked = false;
            }
            else if (ck_A.Checked == true)
            {
                ck_A.Checked = false;
            }
            else if (ck_C.Checked == true)
            {
                ck_C.Checked = false;
            }
            else if (ck_D.Checked == true)
            {
                ck_D.Checked = false;
            }

            if (CK_2.Checked == true)
            {
                CK_2.Checked = false;
            }
            else if (CK_1.Checked == true)
            {
                CK_1.Checked = false;
            }
            else if (CK_3.Checked == true)
            {
                CK_3.Checked = false;
            }
            else if (CK_4.Checked == true)
            {
                CK_4.Checked = false;
            }
            else if (CK_5.Checked == true)
            {
                CK_5.Checked = false;
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ck_A_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ck_B_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ck_C_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ck_D_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ck_A_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void ck_B_CheckStateChanged(object sender, EventArgs e)
        {
          
        }

        private void ck_C_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void ck_D_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void ck_A_Click(object sender, EventArgs e)
        {
            if (ck_B.Checked == true)
            {
                ck_B.Checked = false;
            }
            else if (ck_C.Checked == true)
            {
                ck_C.Checked = false;
            }
            else if (ck_D.Checked == true)
            {
                ck_D.Checked = false;
            }
        }

        private void ck_B_Click(object sender, EventArgs e)
        {
            if (ck_A.Checked == true)
            {
                ck_A.Checked = false;
            }
            else if (ck_C.Checked == true)
            {
                ck_C.Checked = false;
            }
            else if (ck_D.Checked == true)
            {
                ck_D.Checked = false;
            }
        }

        private void ck_C_Click(object sender, EventArgs e)
        {
            if (ck_A.Checked == true)
            {
                ck_A.Checked = false;
            }
            else if (ck_B.Checked == true)
            {
                ck_B.Checked = false;
            }
            else if (ck_D.Checked == true)
            {
                ck_D.Checked = false;
            }
        }

        private void ck_D_Click(object sender, EventArgs e)
        {
            if (ck_A.Checked == true)
            {
                ck_A.Checked = false;
            }
            else if (ck_B.Checked == true)
            {
                ck_B.Checked = false;
            }
            else if (ck_C.Checked == true)
            {
                ck_C.Checked = false;
            }
        }

        private void CK_1_Click(object sender, EventArgs e)
        {
            if (CK_2.Checked == true)
            {
                CK_2.Checked = false;
            }
            else if (CK_3.Checked == true)
            {
                CK_3.Checked = false;
            }
            else if (CK_4.Checked == true)
            {
                CK_4.Checked = false;
            }
            else if (CK_5.Checked == true)
            {
                CK_5.Checked = false;
            }

        }

        private void CK_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CK_2_Click(object sender, EventArgs e)
        {
            if (CK_1.Checked == true)
            {
                CK_1.Checked = false;
            }
            else if (CK_3.Checked == true)
            {
                CK_3.Checked = false;
            }
            else if (CK_4.Checked == true)
            {
                CK_4.Checked = false;
            }
            else if (CK_5.Checked == true)
            {
                CK_5.Checked = false;
            }
        }

        private void CK_3_Click(object sender, EventArgs e)
        {
            if (CK_1.Checked == true)
            {
                CK_1.Checked = false;
            }
            else if (CK_2.Checked == true)
            {
                CK_2.Checked = false;
            }
            else if (CK_4.Checked == true)
            {
                CK_4.Checked = false;
            }
            else if (CK_5.Checked == true)
            {
                CK_5.Checked = false;
            }
        }

        private void CK_4_Click(object sender, EventArgs e)
        {
            if (CK_1.Checked == true)
            {
                CK_1.Checked = false;
            }
            else if (CK_2.Checked == true)
            {
                CK_2.Checked = false;
            }
            else if (CK_3.Checked == true)
            {
                CK_3.Checked = false;
            }
            else if (CK_5.Checked == true)
            {
                CK_5.Checked = false;
            }
        }

        private void CK_5_Click(object sender, EventArgs e)
        {
            if (CK_1.Checked == true)
            {
                CK_1.Checked = false;
            }
            else if (CK_2.Checked == true)
            {
                CK_2.Checked = false;
            }
            else if (CK_3.Checked == true)
            {
                CK_3.Checked = false;
            }
            else if (CK_4.Checked == true)
            {
                CK_4.Checked = false;
            }
        }

        private void txt_bin_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txt_badge_num.Focus();
            }
        }
    }
}
