using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using MyDataStructures;


namespace DataLayer{
    //row data gateway
    public class ActorGateway
    {
        //find actor by unique ID -> return only one actor
        public Actor FindActor(int id)
        {
            Actor actor = new Actor();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT actor_id, first_name, last_name FROM actor WHERE actor_id = {id};";
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        actor.actor_id = reader.GetInt32(0);
                        actor.first_name = reader.GetString(1);
                        actor.last_name = reader.GetString(2);
                    }
                }
            }
            return actor;
        }
        //find actor by first and last name -> possible multiple results -> return list of actors
        public List<Actor> FindActor(string first_name, string last_name)
        {
            List<Actor> actors = new List<Actor>();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT actor_id, first_name, last_name FROM actor WHERE first_name LIKE('%{first_name}%') AND last_name LIKE('%{last_name}%');";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount;)
                        {
                            Actor actor = new Actor();
                            actor.actor_id = reader.GetInt32(i);
                            i++;
                            actor.first_name = reader.GetString(i);
                            i++;
                            actor.last_name = reader.GetString(i);
                            i++;
                            actors.Add(actor);
                        }
                    }
                }
            }
            return actors;
        }

        //insert actor into DB
        public void InsertActor(string first_name, string last_name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                string INSERT_ACTOR = $"INSERT INTO actor(first_name, last_name) VALUES('{first_name}', '{last_name}');";
                connection.Open();
                using (SqlCommand writer = new SqlCommand(INSERT_ACTOR))
                {
                    writer.Connection = connection;
                    writer.ExecuteNonQuery();
                }
            }
        }
        //update actor where actor_id = id
        public void UpdateActor(int id, string first_name, string last_name)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                string UPDATE_ACTOR = $"UPDATE actor SET first_name = '{first_name}', last_name = '{last_name}'WHERE actor.actor_id = {id};";
                connection.Open();
                using (SqlCommand writer = new SqlCommand(UPDATE_ACTOR))
                {
                    writer.Connection = connection;
                    writer.ExecuteNonQuery();
                }
            }
        }
        //delete actor
        public void DeleteActor(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                string DELETE_ACTOR = $"DELETE FROM actor WHERE actor_id = {id};";
                connection.Open();
                using (SqlCommand writer = new SqlCommand(DELETE_ACTOR))
                {
                    writer.Connection = connection;
                    writer.ExecuteNonQuery();
                }
            }
        }
    }
}
