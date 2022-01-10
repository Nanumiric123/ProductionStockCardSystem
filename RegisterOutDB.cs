using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductionStockCardSystem
{
    class RegisterOutDB
    {
        public List<string> Read_sql_data(string part_num, string bin_num, string line_num)
        {
            var results = new List<string>();
            SqlConnectionClass lib_con = new SqlConnectionClass();
            SqlConnection con = lib_con.sqlConn();
            string qry = "SELECT * FROM [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION] WHERE [MATERIAL_PART_NO] = @part_no AND [BIN_NUMBER] = @bin_no AND [LINE] = @line_no";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.Add("@part_no", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@part_no"].Value = part_num;
            cmd.Parameters.Add("@bin_no", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@bin_no"].Value = bin_num;
            cmd.Parameters.Add("@line_no", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@line_no"].Value = line_num;

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string badg = rdr["PIC_BADGE_NO"].ToString();
                    decimal quantity = Convert.ToDecimal(rdr["QUANTITY"]);
                    string rck_add = rdr["RACK_ADDRESS"].ToString();
                    results.Add(badg);
                    results.Add(quantity.ToString());
                    results.Add(rck_add);
                }

                con.Close();
            }
            catch (SqlException ex)
            {

            }
            return results;
        }

        public string RegisterOUTBin(string badge_no, string part_no, decimal quantity, string bin_no, string line, string kanban_card_no, string rack_address)
        {
            string result = "";
            SqlConnectionClass con = new SqlConnectionClass();
            SqlConnection cnn = con.sqlConn();
            string query = "DELETE FROM [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION] WHERE [MATERIAL_PART_NO] = @part_num AND PIC_BADGE_NO = @badge_num AND BIN_NUMBER = @bin_num AND LINE = @line_num AND RACK_ADDRESS = @rack_add;" +
                "INSERT INTO [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION_LOG] ([DATE_IN],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY]" +
                ",[BIN_NUMBER],[LINE],[KANBAN_CARD_NUMBER],[RACK_ADDRESS],[IN_OUT_STATUS]) VALUES (GETDATE(),@badge_num,@part_num,(-1 * @qqty),@bin_num,@line_num," +
                "@kanban_card,@rack_add,'OUT');";

            SqlCommand cmd = new SqlCommand(query,cnn);
            cmd.Parameters.Add("@part_num", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@part_num"].Value = part_no;

            cmd.Parameters.Add("@badge_num", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@badge_num"].Value = badge_no;

            cmd.Parameters.Add("@bin_num", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@bin_num"].Value = bin_no;

            cmd.Parameters.Add("@line_num", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@line_num"].Value = line;

            cmd.Parameters.Add("@rack_add", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@rack_add"].Value = rack_address;

            cmd.Parameters.Add("@qqty", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@qqty"].Value = quantity;

            cmd.Parameters.Add("@kanban_card", System.Data.SqlDbType.NVarChar);
            cmd.Parameters["@kanban_card"].Value = kanban_card_no;

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                result = "S$Success";
            }
            catch (SqlException ex)
            {
                result = "E:" + ex.Message.ToString();
            }
            return result;
        }

    }
}
