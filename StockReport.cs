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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnectionClass sql_con = new SqlConnectionClass();
            SqlConnection cnn = sql_con.sqlConn();
            string query = "SELECT [MVT_DATE],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY],[BIN_NUMBER],[LINE],[RACK_ADDRESS] FROM [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION]";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);

            try
            {
                cnn.Open();

                da.Fill(dt);
                stockdv.DataSource = dt;
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_mat_srch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnectionClass sql_con = new SqlConnectionClass();
            SqlConnection cnn = sql_con.sqlConn();
            string query = "SELECT [MVT_DATE],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY],[BIN_NUMBER],[LINE],[RACK_ADDRESS] FROM [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION] WHERE [MATERIAL_PART_NO] LIKE '%" + txt_mat.Text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(query, cnn);

            try
            {
                cnn.Open();

                da.Fill(dt);
                stockdv.DataSource = dt;
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
