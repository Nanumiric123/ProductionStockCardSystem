using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProductionStockCardSystem
{
    class RegisterINDB
    {
        public string RegisterINBin(string badge_no,string part_no,decimal quantity,string bin_no,string line,string kanban_card_no,string rack_address)
        {
            SqlConnectionClass con = new SqlConnectionClass();
            SqlConnection cnn = con.sqlConn();

            string query = "INSERT INTO [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION] ([MVT_DATE],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY],[BIN_NUMBER]" +
                ",[LINE],[KANBAN_CARD_NUMBER],[RACK_ADDRESS]) VALUES (GETDATE(),@badge,@part,@qqty,@bin,@line_no," +
                "@kanban_card,@rack_address_no);" +
                "INSERT INTO [dbo].[RAW_MATERIAL_STOCK_CARD_TRANSACTION_LOG] ([DATE_IN],[PIC_BADGE_NO],[MATERIAL_PART_NO],[QUANTITY]" +
                ",[BIN_NUMBER],[LINE],[KANBAN_CARD_NUMBER],[RACK_ADDRESS],[IN_OUT_STATUS]) VALUES (GETDATE(),@badge,@part,@qqty,@bin,@line_no," + 
                "@kanban_card,@rack_address_no,'IN');";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@badge", SqlDbType.NVarChar);
            cmd.Parameters["@badge"].Value = badge_no;
            cmd.Parameters.Add("@part", SqlDbType.NVarChar);
            cmd.Parameters["@part"].Value = part_no;
            cmd.Parameters.Add("@qqty", SqlDbType.Decimal);
            cmd.Parameters["@qqty"].Value = quantity;
            cmd.Parameters.Add("@bin", SqlDbType.NVarChar);
            cmd.Parameters["@bin"].Value = bin_no;
            cmd.Parameters.Add("@line_no", SqlDbType.NVarChar);
            cmd.Parameters["@line_no"].Value = line;
            cmd.Parameters.Add("@kanban_card", SqlDbType.NVarChar);
            cmd.Parameters["@kanban_card"].Value = kanban_card_no;
            cmd.Parameters.Add("@rack_address_no", SqlDbType.NVarChar);
            cmd.Parameters["@rack_address_no"].Value = rack_address;
            string result = "";
            try
            {
                cnn.Open();

                cmd.ExecuteNonQuery();

                cnn.Close();
                result = "S$Success";
            }
            catch(SqlException ex)
            {
                result = "E$" + ex.Message.ToString();

            }

            return result;

        }


    }
}
