﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Lab5_Bai04
{
    internal class ConfigManager
    {
        private static string connectionString = "Data Source=config.db;Version=3;";

        public static void CreateDatabase()
        {
            string databasePath = "config.db";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + databasePath))
            {
                connection.Open();
                string createTableSql = @"CREATE TABLE IF NOT EXISTS Config (
                                            MailServer TEXT,
                                            Port INTEGER,
                                            Username TEXT,
                                            Password TEXT,
                                            SSL TEXT,
                                            nickname TEXT
                                        )";
                using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SaveConfig(string mailServer, int port, string username, string password, string SSL, string nickname)
        {
            CreateDatabase();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Config (MailServer, Port, Username, Password, SSL, nickname) VALUES (@MailServer, @Port, @Username, @Password, @SSL, @nickname)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MailServer", mailServer);
                    command.Parameters.AddWithValue("@Port", port);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@SSL", SSL);
                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static Config GetConfig()
        {
            Config config = new Config();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Config";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            config.MailServer = reader["MailServer"].ToString();
                            config.Port = Convert.ToInt32(reader["Port"]);
                            config.Username = reader["Username"].ToString();
                            config.Password = reader["Password"].ToString();
                            config.SSL = reader["SSL"].ToString();
                            config.nickname = reader["nickname"].ToString();
                        }
                    }
                }
            }
            return config;
        }
    }
}
