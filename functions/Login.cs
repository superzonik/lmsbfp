﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBFP.functions
{
    class Login
    {

        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        
        //Authenticate username and password
        public bool AuthenticateUser(String username, String password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = "SELECT * FROM logsdb.tblusers WHERE username = @username AND password = MD5(@password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql,con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            val.UserID = dt.Rows[0].Field<int>("id");
                            val.Username = dt.Rows[0].Field<string>("username");
                            val.UserLevel = dt.Rows[0].Field<int>("user_level");

                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Login: Incorrect username or password");
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
