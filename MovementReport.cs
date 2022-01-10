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
    public partial class MovementReport : Form
    {
        public MovementReport()
        {
            InitializeComponent();
        }

        private void MovementReport_Load(object sender, EventArgs e)
        {
            DateTime date_from = DateTime.Now.AddDays(-1);
            DateTime date_to = DateTime.Now;
            txt_date_from.Text = date_from.ToString("yyyy-MM-dd");
            txt_date_to.Text = date_to.ToString("yyyy-MM-dd");

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnectionClass sql_con = new SqlConnectionClass();
            SqlConnection cnn = sql_con.sqlConn();
            string query = "SELECT [DATE_IN],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY],[BIN_NUMBER],[LINE],[RACK_ADDRESS],[IN_OUT_STATUS] FROM [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION_LOG] " +
                "WHERE [DATE_IN] BETWEEN '" + txt_date_from.Text + "' AND '" + txt_date_to.Text + "' AND [MATERIAL_PART_NO] LIKE '%" + txt_material.Text +"%'" ;

            SqlDataAdapter da = new SqlDataAdapter(query, cnn);

            try
            {
                cnn.Open();
                da.Fill(dt);
                movement_Dv.DataSource = dt;
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

           
        }

        private void movement_Dv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in movement_Dv.Rows)
            {
                if (Convert.ToInt32(row.Cells["QUANTITY"].Value) > 1)
                {
                    row.Cells["QUANTITY"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells["QUANTITY"].Style.BackColor = Color.Red;
                }
               
            }
        }
    }
}
