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
    public partial class material_search : Form
    {
        public material_search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                try
                {
                    var kanban_info = txt_barcode.Text.Split('$');
                    txt_mat_num.Text = kanban_info[0];
                    txt_line.Text = kanban_info[1];
                    lbl_location.Visible = false;
                    txt_bin_num.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void material_search_Load(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private void material_search_Activated(object sender, EventArgs e)
        {
            txt_barcode.Focus();
        }

        private void txt_bin_num_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_bin_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                RegisterOutDB reg_out_get_data = new RegisterOutDB();
                List<string> db_result = reg_out_get_data.Read_sql_data(txt_mat_num.Text, txt_bin_num.Text, txt_line.Text);

                lbl_location.Visible = true;
                lbl_location.Text = "Material Located in Rack " + db_result[2];
            }
                


        }
    }
}
