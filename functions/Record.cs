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

                        if (dt.Rows.Count != 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                String category = row["category"].ToString();
                                String count = row["count"].ToString();
                                SetItemCount(category, count);
                            }

                        }
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error loading records:" + error);
            }
        }

        public void SetItemCount(String category, String count)
        {
            switch (category)
            {
                case "DRRE Equipment":
                    val.DRREEquipment = Convert.ToInt32(count);
                    break;
                case "Office Equipment":
                    val.OfficeEquipment = Convert.ToInt32(count);
                    break;
                case "ICT Equipment":
                    val.ICTequipment = Convert.ToInt32(count);
                    break;
                case "Other Machineries":
                    val.OtherMachineries = Convert.ToInt32(count);
                    break;
                case "Motor Vehicles":
                    val.MotorVehicles = Convert.ToInt32(count);
                    break;
                case "Medical Dental":
                    val.MedicalDental = Convert.ToInt32(count);
                    break;
                case "SAGF":
                    val.SAGF = Convert.ToInt32(count);
                    break;
                case "Foreign Grants":
                    val.ForeignGrants = Convert.ToInt32(count);
                    break;
                case "Communication Equipment":
                    val.CommunicationEquipment = Convert.ToInt32(count);
                    break;
                case "Motorpool Tools":
                    val.MotorpoolTools = Convert.ToInt32(count);
                    break;
                case "MPASE Firearms":
                    val.MPASEFirearms = Convert.ToInt32(count);
                    break;
            }
        }
    }
}
