using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entities;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Department.DAL
{
    //public class UserDAO : IUserDAO
    //{
    //    private BindingList<User> users = new BindingList<User>();
    //    public void Add(User user)
    //    {
    //        if (user == null)
    //            throw new ArgumentException("user");
    //        users.Add(user);
    //    }
    //    public IEnumerable<User> GetList()
    //    {
    //        return users;
    //    }
    //    public void Remove(User user)
    //    {
    //        users.Remove(user);
    //    }
    //    public IEnumerable<User> SortUserByAgeAsc()
    //    {
    //        var sortedList = new BindingList<User>(users.OrderBy(x => x.Age).ToList());
    //        users = sortedList;

    //        return users;
    //    }

    //    public IEnumerable<User> SortUserByAgeDesc()
    //    {
    //        var sortedListDesc = new BindingList<User>(users.OrderByDescending(x => x.Age).ToList());
    //        users = sortedListDesc;
    //        return users;
    //    }
    //}
    public class UserDAOdb : IUserDAO
    {
        OleDbCommand command;
        public static string ConnectionString { get; set; }
        public UserDAOdb(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Add(User user)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                string StrInsertToServer = "INSERT INTO [dbo].[User] (FirstName, Surname, BirthDate) VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.BirthDate.ToString() + "')";
                command = new OleDbCommand(StrInsertToServer, connection);
                
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                
            }
                
        }
        public List<User> GetList()
        {
            List<User> users = new List<User>();
            string queryString = "SELECT * FROM [dbo].[User]";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand(queryString, connection);
                connection.Open();
                //command = new OleDbCommand("SELECT * FROM [dbo].[User]");
                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.BirthDate = (DateTime)reader.GetValue(3);

                    users.Add(user);
                }
                connection.Close();
                return users;
            }
            
        }
        public void Remove(int ID)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM [dbo].[UserAward] WHERE Users_Id = {ID}", connection);
                command = new OleDbCommand($"DELETE FROM [dbo].[User] WHERE UserID = {ID}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }    
            
        }

        public List<User> SortUserByAgeAsc()
        {
            List<User> users = new List<User>();
            string queryString = "SELECT * FROM [dbo].[User] ORDER BY Age ASC";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.BirthDate = (DateTime)reader.GetValue(3);

                    users.Add(user);
                }
                connection.Close();
                return users;
            }
        }

        public List<User> SortUserByAgeDesc()
        {
            List<User> users = new List<User>();
            string queryString = "SELECT * FROM [dbo].[User] ORDER BY Age DESC";
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.BirthDate = (DateTime)reader.GetValue(3);

                    users.Add(user);
                }
                connection.Close();
                return users;
            }
        }
    }
}
