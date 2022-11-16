using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBFP.functions
{
    class Items
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        
        public bool AddItemRecord(string item_name, string category, string description, string prop_num, string unit, DateTime date_acquired, double unit_value, int quantity, string region, string par, string reference)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO logsdb.tblitems(item_name, category, description, prop_num, measure_unit, date_acquired, unit_value, quantity, region, par_num, reference)
                                VALUES(@item_name, @category, @description, @prop_num, @unit, @date_acquired, @unit_value, @quantity, @region, @par, @reference)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@prop_num", prop_num);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@date_acquired", date_acquired);
                        cmd.Parameters.AddWithValue("@unit_value", unit_value);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@region", region);
                        cmd.Parameters.AddWithValue("@par", par);
                        cmd.Parameters.AddWithValue("@reference", reference);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }

                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errror Adding Item Data: " + e);
                return false;
            }
        }

    }
}
