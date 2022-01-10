using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionStockCardSystem
{
    public partial class RegisterIOUT : Form
    {
        public RegisterIOUT()
        {
            InitializeComponent();
        }

        private void cb_rack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && txt_barcode.Text != "" && txt_barcode.Text.Contains('$'))
            {
                var kanban_info = txt_barcode.Text.Split('$');
                txt_material.Text = kanban_info[0];
                txt_line.Text = kanban_info[1];
                kanban_number = kanban_info[2];
                txt_barcode.Text = "";
                txt_bin_num.Focus();

            }
        }
        string kanban_number = "";
        private void txt_bin_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                RegisterOutDB reg_out_get_data = new RegisterOutDB();
                List<string> db_result = reg_out_get_data.Read_sql_data(txt_material.Text, txt_bin_num.Text, txt_line.Text);
                txt_badge_num.Text = db_result[0];
                txt_qty.Text = db_result[1];
                lbl_loc.Visible = true;
                lbl_loc.Text = db_result[2];
            }

        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RegisterIOUT_Load(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private void RegisterIOUT_Activated(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            if(txt_bin_num.Text == "")
            {
                MessageBox.Show("Bin number missing !");

            }
            else
            {
                RegisterOutDB reg_out_data_io = new RegisterOutDB();
                string result = reg_out_data_io.RegisterOUTBin(txt_badge_num.Text, txt_material.Text, decimal.Parse(txt_qty.Text), txt_bin_num.Text, txt_line.Text, kanban_number, lbl_loc.Text);
                var result_details = result.Split('$');
                if (result_details[0] == "S")
                {
                    MessageBox.Show(result_details[1] + " !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result_details[1] + " !");
                }

            }
        }

        private void txt_badge_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
