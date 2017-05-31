using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Joe.Models;
using static Dapper.SqlMapper;

namespace Joe.Factories
{
    public class MessageFactory : IFactory<Message>
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
        
        public MessageFactory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        
        internal IDbConnection Connection
        {
            get { return new MySqlConnection(MySqlConfig.Value.ConnectionString);}
        }

        public void Add(Message Item)
        {
            using(IDbConnection dbConnection = Connection)
            {
                Console.WriteLine(Item);
                string Query = "INSERT INTO message (Name, Email, Note, CreatedAt, UpdateAt) VALUES (@Name, @Email, @Note, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(Query, Item);
            }
        }
        public List<Message> All()
        {
            using(IDbConnection dbConnection = Connection)
            {
                string Query = "SELECT * FROM message";
                dbConnection.Open();
                return dbConnection.Query<Message>(Query).ToList();
            }
        }

        public Message GetUserById()
        {
            using(IDbConnection dbConnection = Connection)
            {
                string Query = $"SELECT CURRENT_USER from message;";
                dbConnection.Open();
                  return dbConnection.Query<Message>(Query).Last();
            }
        }
        public void DeleteMessage(int Id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string Query = $"DELETE FROM message WHERE ID = {Id}";
                dbConnection.Open();
                dbConnection.Execute(Query);
            }
        }
    }
}