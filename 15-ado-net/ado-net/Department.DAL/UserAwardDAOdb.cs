using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Department.DAL
{
    public class UserAwardDAOdb : IUserAwardDAO
    {
        OleDbCommand command;
        public static string ConnectionString { get; set; }
        public UserAwardDAOdb(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public void Add(UserAwards userAwards)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                string strInsertAwardToUser = "INSERT INTO UserAward(Users_Id, Award_Id) VALUES('" + userAwards.User_ID + "','" + userAwards.Award_ID + "')";
                
                command = new OleDbCommand(strInsertAwardToUser, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public List<UserAwards> GetList()
        {

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand($"SELECT [dbo].[User].UserID, [dbo].[User].FirstName, [dbo].[User].Surname, Awards.AwardID, Awards.Title FROM((UserAward INNER JOIN[dbo].[User] ON UserAward.Users_Id = [dbo].[User].UserID) INNER JOIN Awards ON UserAward.Award_Id = Awards.AwardID); ");
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                List<UserAwards> userAwardList = new List<UserAwards>();
                while (reader.Read())
                {
                    UserAwards userAward = new UserAwards();
                    userAward.User_ID = reader.GetInt32(0);
                    userAward.User_FirstName = reader.GetString(1);
                    userAward.User_LastName = reader.GetString(2);
                    userAward.Award_ID = reader.GetInt32(3);
                    userAward.Award_Title = reader.GetString(4);

                    userAwardList.Add(userAward);
                }
                connection.Close();
                return userAwardList;

            }
        }

        public void Remove(int Award_ID, int User_ID)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM [dbo].[UserAward] WHERE Users_Id = {User_ID} AND Award_Id = {Award_ID}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        //public void UpdateAward(int Award_ID, string Award_Title)
        //{
        //    ConnectionState.Open();
        //    command = new OleDbCommand($"UPDATE [dbo].[UserAward] SET Awards.AwardID=")
        //}

    }
}
