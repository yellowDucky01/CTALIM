using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EMPLOYEE_MANAGEMENT_SYSTEM
{
    public class DatabaseHelper
    {
        private string connString = "Server=localhost;Database=mydb;Uid=root;Pwd=;";


        public bool CheckLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // We check if a user exists with this name AND password
                    string query = "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Returns True if found, False if not
                }
                catch (Exception ex)
                {
                    // If there is an error (like the DB is off), this shows why
                    System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
