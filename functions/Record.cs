using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBFP.functions
{
    class Record
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();

        public void LoadDRRErecords()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT category, COUNT(*) as count FROM logsdb.tblitems GROUP BY category";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        var items = new Dictionary<string, int>();

                        if (dt.Rows.Count != 0)
                        {
                            // loop records
                            for(int i = 0; i < dt.Rows.Count; i++)
                            {
                                items.Add(dt.Rows[i].Field<string>("category"), dt.Rows[i].Field<int>("count"));
                                Console.WriteLine(items.ElementAt(i).Key,items.ElementAt(i).Value);
                            }

                            //items["Communication Equipment"]
                            val.DRREequipment = items["DRRE Equipment"];
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error loading records:" + error);
            }
        }
    }
}
