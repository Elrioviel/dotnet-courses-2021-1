using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entities;
using System.Data;
using System.Data.OleDb;

namespace Department.DAL
{
    //public class AwardDAO : IAwardDAO
    //{
    //    private BindingList<Awards> awards = new BindingList<Awards>();

    //    public void Add(Awards award)
    //    {
    //        if (award == null)
    //            throw new ArgumentException("award");
    //        awards.Add(award);
    //    }
    //    public IEnumerable<Awards> GetList()
    //    {
    //        return awards;
    //    }
    //    public void Remove(Awards award)
    //    {
    //        awards.Remove(award);
    //    }

    //    public IEnumerable<Awards> SortAwardsByTitleAsc()
    //    {
    //        var sortedList = new BindingList<Awards>(awards.OrderBy(x => x.Title).ToList());
    //        awards = sortedList;

    //        return awards;
    //    }

    //    public IEnumerable<Awards> SortAwardsByTitleDesc()
    //    {
    //        var sortedListDesc = new BindingList<Awards>(awards.OrderByDescending(x => x.Title).ToList());
    //        awards = sortedListDesc;
    //        return awards;
    //    }
    //}
    public class AwardDAOdb : IAwardDAO
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public static string ConnectionString { get; set; }
        public AwardDAOdb(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
            ConnectionString = Conn;
        }
        public void Add(Awards award)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                string StrInsertToServer = "INSERT INTO [dbo].[Awards] (Title, Description) VALUES('" + award.Title + "','" + award.Description + "')";
                command = new OleDbCommand(StrInsertToServer, connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
        }
        public List<Awards> GetList()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand($"SELECT * FROM Awards");
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                List<Awards> awards = new List<Awards>();
                while (reader.Read())
                {
                    Awards award = new Awards();
                    award.AwardID = reader.GetInt32(0);
                    award.Title = reader.GetString(1);
                    award.Description = reader.GetString(2);

                    awards.Add(award);
                }
                connection.Close();

                return awards;
            }
        }
        public void Remove(int awardID)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                command = new OleDbCommand($"DELETE FROM [dbo].[UserAward] WHERE Award_Id = {awardID}", connection);
                command = new OleDbCommand($"DELETE FROM Awards WHERE AwardID = {awardID}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<Awards> SortAwardsByTitleAsc()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand($"SELECT * FROM Awards ORDER BY Title ASC");
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                List<Awards> awards = new List<Awards>();
                while (reader.Read())
                {
                    Awards award = new Awards();
                    award.AwardID = reader.GetInt32(0);
                    award.Title = reader.GetString(1);
                    award.Description = reader.GetString(2);

                    awards.Add(award);
                }
                connection.Close();

                return awards;
            }
        }

        public IEnumerable<Awards> SortAwardsByTitleDesc()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                command = new OleDbCommand($"SELECT * FROM Awards ORDER BY Title DESC");
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                List<Awards> awards = new List<Awards>();
                while (reader.Read())
                {
                    Awards award = new Awards();
                    award.AwardID = reader.GetInt32(0);
                    award.Title = reader.GetString(1);
                    award.Description = reader.GetString(2);

                    awards.Add(award);
                }
                connection.Close();

                return awards;
            }
        }
    }

}
