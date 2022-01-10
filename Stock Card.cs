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
    public partial class stock_card : Form
    {
        public stock_card()
        {
            InitializeComponent();
        }

        private void b_material_search_Click(object sender, EventArgs e)
        {
            material_search MAT_SER = new material_search();
            MAT_SER.ShowDialog();
        }

        private void b_in_reg_Click(object sender, EventArgs e)
        {
            RegisterIN reg_in = new RegisterIN();

            reg_in.ShowDialog();
        }

        private void b_reg_OUT_Click(object sender, EventArgs e)
        {
            RegisterIOUT reg_out = new RegisterIOUT();
            reg_out.ShowDialog();
        }

        private void b_mat_report_Click(object sender, EventArgs e)
        {
            StockReport stock_report = new StockReport();
            stock_report.ShowDialog();
        }

        private void b_mat_mvt_rep_Click(object sender, EventArgs e)
        {
            MovementReport mvt_report = new MovementReport();
            mvt_report.ShowDialog();

        }
    }
}
